using GeradorProtocolo.Models;
using GeradorProtocolo.Util;

namespace GeradorProtocolo
{
    public partial class Menu : Form
    {
        PdfService pdfService;
        Protocolo protocolo;
        int ClickedRowIndex;

        public Menu()
        {
            InitializeComponent();
            pdfService = new();
            protocolo = new();
            BindData(); // Ensure this is called to set up the data binding
            timePicker.Value = DateTime.Today.AddHours(14);
            label_Total.Text = "Total: " + protocolo.Total.ToString("C");
        }

        public void BindData()
        {
            // Binds ProtocoloRetirada to dataGridView, only.
            protocolo.BindingSource.DataSource = protocolo.ProtocoloRetirada;
            dataGridView.DataSource = protocolo.BindingSource;

            // Configure dataGridView columns: autoGenerateColumns = false; Clear columns; Add columns.
            dataGridView.AutoGenerateColumns = false;
            dataGridView.Columns.Clear();
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantidade", HeaderText = "Qtd." });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TipoRegistro", HeaderText = "Ato" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Descricao", HeaderText = "Descri��o" });
            dataGridView.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Total", HeaderText = "Valor" });
            dataGridView.Columns.Add(new DataGridViewCheckBoxColumn { DataPropertyName = "ProtocoloLivro", HeaderText = "Protocolo para Livro" });

            // Set AutoSizeColumnsMode to AllCells to adjust the columns' width based on the content
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClickedRowIndex = e.RowIndex;

            Item item = protocolo.ProtocoloRetirada[ClickedRowIndex];
            // Fill the fields with the item data
            textBox_TipoRegistro.Text = item.TipoRegistro;
            textBox_PartesCertidao.Text = item.NomeParte;
            checkBox_ProtocoloLivro.Checked = item.ProtocoloLivro;
            checkBox_Cpf.Checked = !string.IsNullOrEmpty(item.CpfParte) || !string.IsNullOrEmpty(item.CpfParte2);
            textBox_CpfDele.Text = item.CpfParte;
            textBox_CpfDela.Text = item.CpfParte2;
            textBox_Descricao.Text = item.Descricao;
            textBox_Valor.Text = item.Valor.ToString();
            numericUpDown_Certidao.Value = item.Quantidade;
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

        private void button_Adicionar_Click(object sender, EventArgs e)
        {
            // Add item to ProtocoloRetirada. If checkBox_Apostila is checked, add item to ProtocoloApostila. If checkBox_ReciboProvisorio is checked, add item to ReciboProvisorio.
            try
            {
                Item item = new()
                {
                    TipoRegistro = textBox_TipoRegistro.Text,
                    NomeParte = textBox_PartesCertidao.Text,
                    CpfParte = textBox_CpfDele.Text,
                    CpfParte2 = textBox_CpfDela.Text,
                    Descricao = textBox_Descricao.Text,
                    Valor = Convert.ToDouble(textBox_Valor.Text),
                    Quantidade = (int)numericUpDown_Certidao.Value,
                    ProtocoloLivro = checkBox_ProtocoloLivro.Checked
                };
                if (checkBox_ProtocoloLivro.Checked)
                {
                    protocolo.ProtocoloLivro.Add(item);
                }
                protocolo.ProtocoloRetirada.Add(item);
                ClearFields();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao adicionar o item. Verifique se os campos necess�rios est�o preenchidos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // Return focus to textBox_TipoRegistro.
            textBox_TipoRegistro.Focus();

            // Calculate total value of ProtocoloRetirada.
            label_Total.Text = "Total: " + protocolo.Total.ToString("C");
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            if (ClickedRowIndex >= 0)
            {
                // Edit item in ProtocoloRetirada. If checkBox_ProtocoloLivro is checked, edit item in ProtocoloLivro.
                try
                {
                    Item item = protocolo.ProtocoloRetirada[ClickedRowIndex];

                    item.TipoRegistro = textBox_TipoRegistro.Text;
                    item.NomeParte = textBox_PartesCertidao.Text;
                    item.CpfParte = textBox_CpfDele.Text;
                    item.CpfParte2 = textBox_CpfDela.Text;
                    item.Descricao = textBox_Descricao.Text;
                    item.Valor = Convert.ToDouble(textBox_Valor.Text);
                    item.Quantidade = (int)numericUpDown_Certidao.Value;
                    item.ProtocoloLivro = checkBox_ProtocoloLivro.Checked;

                    if (!checkBox_ProtocoloLivro.Checked)
                    {
                        protocolo.ProtocoloLivro.Remove(item);
                    }
                    else
                    {
                        if (protocolo.ProtocoloLivro.Count <= ClickedRowIndex)
                        {
                            protocolo.ProtocoloLivro.Add(item);
                        }
                    }
                    ClearFields();

                    // Update the DataGridView and Total to reflect the changes
                    dataGridView.Refresh();
                    label_Total.Text = "Total: " + protocolo.Total.ToString("C");

                    // Return focus to textBox_TipoRegistro.
                    textBox_TipoRegistro.Focus();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao editar o item. Verifique se os campos necess�rios est�o preenchidos e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_Remover_Click(object sender, EventArgs e)
        {
            // Remove item from ProtocoloRetirada. If checkBox_ProtocoloLivro is checked, remove item from ProtocoloLivro.
            if (ClickedRowIndex >= 0)
            {
                try
                {
                    if (protocolo.ProtocoloRetirada[ClickedRowIndex].ProtocoloLivro)
                    {
                        protocolo.ProtocoloLivro.RemoveAt(ClickedRowIndex);
                    }
                    protocolo.ProtocoloRetirada.RemoveAt(ClickedRowIndex);
                    ClearFields();

                    label_Total.Text = "Total: " + protocolo.Total.ToString("C");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocorreu um erro ao remover o item. Verifique se um item na lista foi selecionado e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button_Gerar_Click(object sender, EventArgs e)
        {
            // Check if ProtocoloRetirada is empty
            if (protocolo.ProtocoloRetirada.Count == 0)
            {
                MessageBox.Show("A lista de itens est� vazia. Adicione pelo menos um item antes de gerar o PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                button_Adicionar.Focus();
                return;
            }
            // Check if checkBox_ReciboProvisorio is checked but textBox_ReciboProv is empty
            if (checkBox_ReciboProvisorio.Checked && string.IsNullOrEmpty(textBox_ReciboProv.Text))
            {
                MessageBox.Show("A caixa de sele��o do Recibo Provis�rio foi assinalada mas n�o tem conte�do. Por favor, verifique.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox_ReciboProvisorio.Focus();
                return;
            }
            // Check if textBox_Requerente is empty
            if (string.IsNullOrEmpty(textBox_Requerente.Text))
            {
                MessageBox.Show("O campo do requerente est� vazio. Preencha-o antes de gerar o PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Requerente.Focus();
                return;
            }
            // Check if textBox_Atendente is empty
            if (string.IsNullOrEmpty(textBox_Atendente.Text))
            {
                MessageBox.Show("O campo do atendente est� vazio. Preencha-o antes de gerar o PDF.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Atendente.Focus();
                return;
            }

            // Generate the PDF document
            protocolo.Requerente = textBox_Requerente.Text;
            protocolo.CpfCnpj = textBox_CpfCnpj.Text;
            protocolo.Telefone = textBox_Telefone.Text;
            protocolo.Atendente = textBox_Atendente.Text;
            protocolo.Retirada = DateOnly.FromDateTime(datePicker_Retirada.Value);
            protocolo.HorarioRetirada = timePicker.Value;
            protocolo.IdProvisorio = string.IsNullOrEmpty(textBox_ReciboProv.Text) ? null : Convert.ToInt32(textBox_ReciboProv.Text);

            // Generate the document
            ProtocoloRetiradaPdfDocument document = new(protocolo);

            // Generate and show the PDF file
            try
            {
                pdfService.GenerateProtocoloRetiradaPdfAndShow(document);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocorreu um erro ao gerar o arquivo. Verifique se os campos do requerente est�o preenchidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_Limpar_Click(object sender, EventArgs e)
        {
            // Clears all fields and data
            textBox_Requerente.Clear();
            textBox_ReciboProv.Clear();
            textBox_CpfCnpj.Clear();
            textBox_Telefone.Clear();
            textBox_Atendente.Clear();
            textBox_TipoRegistro.Clear();
            textBox_PartesCertidao.Clear();
            textBox_CpfDele.Clear();
            textBox_Descricao.Clear();
            textBox_Valor.Clear();
            checkBox_ReciboProvisorio.Checked = false;
            checkBox_ProtocoloLivro.Checked = false;
            checkBox_Cpf.Checked = false;
            numericUpDown_Certidao.Value = 1;
            datePicker_Retirada.Value = DateTime.Today;
            timePicker.Value = DateTime.Today.AddHours(14);
            // Remove all items from ProtocoloRetirada and ProtocoloLivro
            protocolo.ProtocoloRetirada.Clear();
            protocolo.ProtocoloLivro.Clear();
            // Updates Total label
            label_Total.Text = "Total: " + protocolo.Total.ToString("C");
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

        private void checkBox_ProtocoloLivro_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Cpf.Visible = checkBox_ProtocoloLivro.Checked;
            label_PartesCertidao.Visible = checkBox_ProtocoloLivro.Checked;
            textBox_PartesCertidao.Visible = checkBox_ProtocoloLivro.Checked;
            if (!checkBox_ProtocoloLivro.Checked)
            {
                checkBox_Cpf.Checked = false;
                textBox_PartesCertidao.Clear();
            }
        }

        private void checkBox_Cpf_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Cpf.Checked)
            {
                label_CpfPartes.Visible = true;
                textBox_CpfDele.Visible = true;
                textBox_CpfDela.Visible = true;
            }
            else
            {
                label_CpfPartes.Visible = false;
                textBox_CpfDele.Visible = false;
                textBox_CpfDela.Visible = false;
                textBox_CpfDele.Clear();
                textBox_CpfDela.Clear();
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

        private void checkBox_Cpf_KeyDown(object sender, KeyEventArgs e)
        {
            // Checks when Enter key is pressed.
            if (e.KeyCode == Keys.Enter)
            {
                checkBox_Cpf.Checked = !checkBox_Cpf.Checked;
            }
        }

        private void textBox_CpfCnpj_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and backspace.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
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

        private void textBox_Telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows only numbers and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_CpfDele_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows only numbers and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_CpfDela_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allows only numbers and backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_CpfCnpj_Leave(object sender, EventArgs e)
        {
            // Identify if is CNPJ or CPF
            if (String.IsNullOrEmpty(textBox_CpfCnpj.Text))
            {
                return;
            }
            else if (Validation.ValidateCPF(textBox_CpfCnpj.Text))
            {
                if (textBox_CpfCnpj.Text.Length == 11)
                {
                    textBox_CpfCnpj.Text = Convert.ToUInt64(textBox_CpfCnpj.Text).ToString(@"000\.000\.000\-00");
                }
                label_CpfCnpj.Text = "CPF: ";
            }
            else if (Validation.ValidateCNPJ(textBox_CpfCnpj.Text))
            {
                if (textBox_CpfCnpj.Text.Length == 14)
                {
                    textBox_CpfCnpj.Text = Convert.ToUInt64(textBox_CpfCnpj.Text).ToString(@"00\.000\.000\/0000\-00");
                }
                label_CpfCnpj.Text = "CNPJ: ";
            }
            else
            {
                MessageBox.Show("O CPF ou CNPJ informado n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CpfCnpj.Clear();
                textBox_CpfCnpj.Focus();
            }
        }

        private void textBox_Telefone_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Telefone.Text))
            {
                return;
            }

            // Remove any existing formatting before validating and reformatting
            string telefone = new string(textBox_Telefone.Text.Where(char.IsDigit).ToArray());

            if (telefone.Length == 10)
            {
                textBox_Telefone.Text = Convert.ToUInt64(telefone).ToString(@"\(00\)\ 0000\-0000");
            }
            else if (telefone.Length == 11)
            {
                textBox_Telefone.Text = Convert.ToUInt64(telefone).ToString(@"\(00\)\ 00000\-0000");
            }
            else
            {
                MessageBox.Show("O formato de n�mero informado n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_Telefone.Clear();
                textBox_Telefone.Focus();
            }
        }

        private void textBox_CpfDele_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_CpfDele.Text)) { return; }
            if (Validation.ValidateCPF(textBox_CpfDele.Text))
            {
                if (textBox_CpfDele.Text.Length == 11)
                {
                    textBox_CpfDele.Text = Convert.ToUInt64(textBox_CpfDele.Text).ToString(@"000\.000\.000\-00");
                }
            }
            else
            {
                MessageBox.Show("O CPF informado n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CpfDele.Clear();
                textBox_CpfDele.Focus();
            }
        }

        private void textBox_CpfDela_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_CpfDela.Text)) { return; }
            if (Validation.ValidateCPF(textBox_CpfDela.Text))
            {
                if (textBox_CpfDela.Text.Length == 11)
                {
                    textBox_CpfDela.Text = Convert.ToUInt64(textBox_CpfDela.Text).ToString(@"000\.000\.000\-00");
                }
            }
            else
            {
                MessageBox.Show("O CPF informado n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox_CpfDela.Clear();
                textBox_CpfDela.Focus();
            }
        }
    }
}
