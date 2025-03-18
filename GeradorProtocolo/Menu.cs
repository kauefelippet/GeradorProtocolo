using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using GeradorProtocolo.Models;
using GeradorProtocolo.Util;

namespace GeradorProtocolo
{
    public partial class Menu : Form
    {
        PdfService pdfService;
        string Atendente;
        DateOnly Retirada;
        BindingSource BindingSource;
        BindingList<Item> ProtocoloRetirada;
        BindingList<Item> ProtocoloLivro;
        int ClickedRowIndex;

        public Menu()
        {
            InitializeComponent();
            pdfService = new();
            Atendente = "";
            BindingSource = new();
            ProtocoloRetirada = new();
            ProtocoloLivro = new();
            BindData(); // Ensure this is called to set up the data binding
        }

        public void BindData()
        {
            // Binds ProtocoloRetirada to dataGridView, only.
            BindingSource.DataSource = ProtocoloRetirada;
            dataGridView.DataSource = BindingSource;

            // Configure dataGridView columns: autoGenerateColumns = false; Clear columns; Add columns.
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Quantidade" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TipoRegistro", HeaderText = "Ato" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descrição" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Total", HeaderText = "Valor" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "ProtocoloLivro", HeaderText = "Protocolo para Livro" });
        }

        private void checkBox_ReciboProvisorio_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ReciboProvisorio.Checked)
            {
                label_NumeroReciboProv.Visible = true;
                textBox_ReciboProv.Visible = true;
            }
            else
            {
                label_NumeroReciboProv.Visible = false;
                textBox_ReciboProv.Visible = false;
                textBox_ReciboProv.Clear();
            }
        }

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            // Add item to ProtocoloRetirada. If checkBox_Apostila is checked, add item to ProtocoloApostila. If checkBox_ReciboProvisorio is checked, add item to ReciboProvisorio.
            Item item = new()
            {
                Requerente = textBox_Requerente.Text,
                CpfCnpj = textBox_CpfCnpj.Text,
                Quantidade = (int)numericUpDown_Certidao.Value,
                TipoRegistro = textBox_TipoRegistro.Text,
                NomeParte = textBox_PartesCertidao.Text,
                Descricao = textBox_Descricao.Text,
                Valor = Convert.ToDouble(textBox_Valor.Text),
                ProtocoloLivro = checkBox_ProtocoloLivro.Checked
            };
            if (checkBox_ProtocoloLivro.Checked)
            {
                ProtocoloLivro.Add(item);
            }
            ProtocoloRetirada.Add(item);

            ClearFields();

            // Calculate total value of ProtocoloRetirada.
            double total = 0;
            foreach (Item i in ProtocoloRetirada)
            {
                total += i.Valor * i.Quantidade;
            }
            label_Total.Text = "Total: R$ " + total.ToString();
        }

        private void ClearFields()
        {
            numericUpDown_Certidao.Value = 1;
            textBox_TipoRegistro.Clear();
            textBox_PartesCertidao.Clear();
            textBox_Descricao.Clear();
            textBox_Valor.Clear();
            checkBox_ProtocoloLivro.Checked = false;
        }

        private void textBox_CpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, -, ., /, and backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != '/')
            {
                e.Handled = true;
            }
        }

        private void textBox_Valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers, ., ,, and backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void textBox_ReciboProv_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button_Gerar_Click(object sender, EventArgs e)
        {
            // Generate the PDF document
            Atendente = textBox_Atendente.Text;
            Retirada = DateOnly.FromDateTime(datePicker_Retirada.Value);
            ProtocoloRetiradaPdfDocument document;

            if (checkBox_ReciboProvisorio.Checked)
            {
                document = new(ProtocoloRetirada, Retirada, Atendente, Convert.ToInt32(textBox_ReciboProv.Text));
            }
            else
            {
                document = new(ProtocoloRetirada, Retirada, Atendente);
            }

            try
            {
                // Generate and show the PDF document
                pdfService.GenerateProtocoloRetiradaPdfAndShow(document);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o arquivo. Verifique se os campos necessários estão preenchidos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickedRowIndex = e.RowIndex;
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            // Remove item from ProtocoloRetirada. If checkBox_ProtocoloLivro is checked, remove item from ProtocoloLivro.
            if (ClickedRowIndex >= 0)
            {
                ProtocoloRetirada.RemoveAt(ClickedRowIndex);
                if (checkBox_ProtocoloLivro.Checked)
                {
                    ProtocoloLivro.RemoveAt(ClickedRowIndex);
                }
            }
        }

        private void checkBox_ReciboProvisorio_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks when Enter key is pressed.
            if (e.KeyCode == Keys.Enter)
            {
                checkBox_ReciboProvisorio.Checked = !checkBox_ReciboProvisorio.Checked;
            }
        }

        private void checkBox_ProtocoloLivro_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks when Enter key is pressed.
            if (e.KeyCode == Keys.Enter)
            {
                checkBox_ProtocoloLivro.Checked = !checkBox_ProtocoloLivro.Checked;
            }
        }
    }
}
