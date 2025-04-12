namespace GeradorProtocolo
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label_Requerente = new Label();
            textBox_Requerente = new TextBox();
            label_CpfCnpj = new Label();
            textBox_CpfCnpj = new TextBox();
            panel1 = new Panel();
            button_Limpar = new Button();
            button_Editar = new Button();
            label_CpfPartes = new Label();
            textBox_CpfPartes = new TextBox();
            checkBox_Cpf = new CheckBox();
            label_HorarioRetirada = new Label();
            timePicker = new DateTimePicker();
            label_Total = new Label();
            checkBox_ProtocoloLivro = new CheckBox();
            button_Gerar = new Button();
            button_Remover = new Button();
            button_Adicionar = new Button();
            dataGridView = new DataGridView();
            label_RetiradaCertidao = new Label();
            datePicker_Retirada = new DateTimePicker();
            textBox_TipoRegistro = new TextBox();
            label_Ato = new Label();
            textBox_Descricao = new TextBox();
            label_RefRegistro = new Label();
            numericUpDown_Certidao = new NumericUpDown();
            label_Quantidade = new Label();
            textBox_Valor = new TextBox();
            label_ValorCertidao = new Label();
            textBox_PartesCertidao = new TextBox();
            label_PartesCertidao = new Label();
            textBox_ReciboProv = new TextBox();
            checkBox_ReciboProvisorio = new CheckBox();
            label_NumeroReciboProv = new Label();
            label_Atendente = new Label();
            textBox_Atendente = new TextBox();
            textBox_Telefone = new TextBox();
            label_Telefone = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Certidao).BeginInit();
            SuspendLayout();
            // 
            // label_Requerente
            // 
            label_Requerente.Anchor = AnchorStyles.Left;
            label_Requerente.AutoSize = true;
            label_Requerente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Requerente.ForeColor = Color.Black;
            label_Requerente.Location = new Point(12, 10);
            label_Requerente.Name = "label_Requerente";
            label_Requerente.Size = new Size(81, 17);
            label_Requerente.TabIndex = 0;
            label_Requerente.Text = "Requerente:";
            label_Requerente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Requerente
            // 
            textBox_Requerente.BackColor = SystemColors.ControlLight;
            textBox_Requerente.BorderStyle = BorderStyle.None;
            textBox_Requerente.CharacterCasing = CharacterCasing.Upper;
            textBox_Requerente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Requerente.ForeColor = Color.Black;
            textBox_Requerente.Location = new Point(96, 10);
            textBox_Requerente.Name = "textBox_Requerente";
            textBox_Requerente.Size = new Size(400, 18);
            textBox_Requerente.TabIndex = 0;
            // 
            // label_CpfCnpj
            // 
            label_CpfCnpj.Anchor = AnchorStyles.Left;
            label_CpfCnpj.AutoSize = true;
            label_CpfCnpj.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_CpfCnpj.ForeColor = Color.Black;
            label_CpfCnpj.Location = new Point(12, 30);
            label_CpfCnpj.Name = "label_CpfCnpj";
            label_CpfCnpj.Size = new Size(77, 17);
            label_CpfCnpj.TabIndex = 3;
            label_CpfCnpj.Text = "CPF / CNPJ:";
            label_CpfCnpj.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_CpfCnpj
            // 
            textBox_CpfCnpj.BackColor = SystemColors.ControlLight;
            textBox_CpfCnpj.BorderStyle = BorderStyle.None;
            textBox_CpfCnpj.CharacterCasing = CharacterCasing.Upper;
            textBox_CpfCnpj.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_CpfCnpj.ForeColor = Color.Black;
            textBox_CpfCnpj.Location = new Point(96, 30);
            textBox_CpfCnpj.Name = "textBox_CpfCnpj";
            textBox_CpfCnpj.Size = new Size(200, 18);
            textBox_CpfCnpj.TabIndex = 3;
            textBox_CpfCnpj.KeyPress += textBox_CpfCnpj_KeyPress;
            // 
            // panel1
            // 
            panel1.Controls.Add(button_Limpar);
            panel1.Controls.Add(button_Editar);
            panel1.Controls.Add(label_CpfPartes);
            panel1.Controls.Add(textBox_CpfPartes);
            panel1.Controls.Add(checkBox_Cpf);
            panel1.Controls.Add(label_HorarioRetirada);
            panel1.Controls.Add(timePicker);
            panel1.Controls.Add(label_Total);
            panel1.Controls.Add(checkBox_ProtocoloLivro);
            panel1.Controls.Add(button_Gerar);
            panel1.Controls.Add(button_Remover);
            panel1.Controls.Add(button_Adicionar);
            panel1.Controls.Add(dataGridView);
            panel1.Controls.Add(label_RetiradaCertidao);
            panel1.Controls.Add(datePicker_Retirada);
            panel1.Controls.Add(textBox_TipoRegistro);
            panel1.Controls.Add(label_Ato);
            panel1.Controls.Add(textBox_Descricao);
            panel1.Controls.Add(label_RefRegistro);
            panel1.Controls.Add(numericUpDown_Certidao);
            panel1.Controls.Add(label_Quantidade);
            panel1.Controls.Add(textBox_Valor);
            panel1.Controls.Add(label_ValorCertidao);
            panel1.Controls.Add(textBox_PartesCertidao);
            panel1.Controls.Add(label_PartesCertidao);
            panel1.Location = new Point(12, 54);
            panel1.Name = "panel1";
            panel1.Size = new Size(760, 395);
            panel1.TabIndex = 6;
            // 
            // button_Limpar
            // 
            button_Limpar.BackColor = SystemColors.ControlLight;
            button_Limpar.FlatAppearance.BorderSize = 0;
            button_Limpar.FlatStyle = FlatStyle.Flat;
            button_Limpar.Location = new Point(645, 176);
            button_Limpar.Name = "button_Limpar";
            button_Limpar.Size = new Size(115, 23);
            button_Limpar.TabIndex = 20;
            button_Limpar.Text = "Limpar Campos";
            button_Limpar.UseVisualStyleBackColor = false;
            button_Limpar.Click += button_Limpar_Click;
            // 
            // button_Editar
            // 
            button_Editar.BackColor = SystemColors.ControlLight;
            button_Editar.FlatAppearance.BorderSize = 0;
            button_Editar.FlatStyle = FlatStyle.Flat;
            button_Editar.Location = new Point(84, 175);
            button_Editar.Name = "button_Editar";
            button_Editar.Size = new Size(79, 23);
            button_Editar.TabIndex = 17;
            button_Editar.Text = "Editar";
            button_Editar.UseVisualStyleBackColor = false;
            button_Editar.Click += button_Editar_Click;
            // 
            // label_CpfPartes
            // 
            label_CpfPartes.Anchor = AnchorStyles.Left;
            label_CpfPartes.AutoSize = true;
            label_CpfPartes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_CpfPartes.ForeColor = Color.Black;
            label_CpfPartes.Location = new Point(290, 54);
            label_CpfPartes.Name = "label_CpfPartes";
            label_CpfPartes.Size = new Size(97, 15);
            label_CpfPartes.TabIndex = 10;
            label_CpfPartes.Text = "CPFs Respectivos";
            label_CpfPartes.TextAlign = ContentAlignment.MiddleLeft;
            label_CpfPartes.Visible = false;
            // 
            // textBox_CpfPartes
            // 
            textBox_CpfPartes.BackColor = SystemColors.ControlLight;
            textBox_CpfPartes.BorderStyle = BorderStyle.None;
            textBox_CpfPartes.Font = new Font("Segoe UI", 9F);
            textBox_CpfPartes.ForeColor = Color.Black;
            textBox_CpfPartes.Location = new Point(290, 73);
            textBox_CpfPartes.Name = "textBox_CpfPartes";
            textBox_CpfPartes.PlaceholderText = "XXX.XXX.XXX-XX // XXX.XXX.XXX-XX";
            textBox_CpfPartes.Size = new Size(318, 16);
            textBox_CpfPartes.TabIndex = 10;
            textBox_CpfPartes.Visible = false;
            // 
            // checkBox_Cpf
            // 
            checkBox_Cpf.AutoSize = true;
            checkBox_Cpf.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox_Cpf.Location = new Point(429, 35);
            checkBox_Cpf.Name = "checkBox_Cpf";
            checkBox_Cpf.Size = new Size(118, 19);
            checkBox_Cpf.TabIndex = 8;
            checkBox_Cpf.Text = "CPF no Protocolo";
            checkBox_Cpf.UseVisualStyleBackColor = true;
            checkBox_Cpf.Visible = false;
            checkBox_Cpf.CheckedChanged += checkBox_Cpf_CheckedChanged;
            checkBox_Cpf.KeyDown += checkBox_Cpf_KeyDown;
            // 
            // label_HorarioRetirada
            // 
            label_HorarioRetirada.Anchor = AnchorStyles.Left;
            label_HorarioRetirada.AutoSize = true;
            label_HorarioRetirada.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_HorarioRetirada.ForeColor = Color.Black;
            label_HorarioRetirada.Location = new Point(290, 131);
            label_HorarioRetirada.Name = "label_HorarioRetirada";
            label_HorarioRetirada.Size = new Size(47, 15);
            label_HorarioRetirada.TabIndex = 15;
            label_HorarioRetirada.Text = "Horário";
            label_HorarioRetirada.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // timePicker
            // 
            timePicker.CalendarForeColor = SystemColors.ControlLight;
            timePicker.CalendarMonthBackground = SystemColors.ControlLight;
            timePicker.CalendarTitleBackColor = Color.OliveDrab;
            timePicker.CalendarTrailingForeColor = Color.OliveDrab;
            timePicker.CustomFormat = "HH:mm";
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(290, 148);
            timePicker.Name = "timePicker";
            timePicker.RightToLeft = RightToLeft.No;
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(55, 23);
            timePicker.TabIndex = 15;
            timePicker.Value = new DateTime(2025, 3, 18, 14, 0, 0, 0);
            // 
            // label_Total
            // 
            label_Total.Anchor = AnchorStyles.Left;
            label_Total.AutoSize = true;
            label_Total.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Total.ForeColor = Color.Black;
            label_Total.Location = new Point(375, 178);
            label_Total.Name = "label_Total";
            label_Total.Size = new Size(40, 17);
            label_Total.TabIndex = 20;
            label_Total.Text = "Total:\r\n";
            label_Total.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBox_ProtocoloLivro
            // 
            checkBox_ProtocoloLivro.AutoSize = true;
            checkBox_ProtocoloLivro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox_ProtocoloLivro.Location = new Point(290, 35);
            checkBox_ProtocoloLivro.Name = "checkBox_ProtocoloLivro";
            checkBox_ProtocoloLivro.Size = new Size(133, 19);
            checkBox_ProtocoloLivro.TabIndex = 7;
            checkBox_ProtocoloLivro.Text = "Protocolo para Livro";
            checkBox_ProtocoloLivro.UseVisualStyleBackColor = true;
            checkBox_ProtocoloLivro.CheckedChanged += checkBox_ProtocoloLivro_CheckedChanged;
            checkBox_ProtocoloLivro.KeyDown += checkBox_ProtocoloLivro_KeyDown;
            // 
            // button_Gerar
            // 
            button_Gerar.BackColor = SystemColors.ControlLight;
            button_Gerar.FlatAppearance.BorderSize = 0;
            button_Gerar.FlatStyle = FlatStyle.Flat;
            button_Gerar.Location = new Point(254, 175);
            button_Gerar.Name = "button_Gerar";
            button_Gerar.Size = new Size(115, 23);
            button_Gerar.TabIndex = 19;
            button_Gerar.Text = "Gerar Protocolo";
            button_Gerar.UseVisualStyleBackColor = false;
            button_Gerar.Click += button_Gerar_Click;
            // 
            // button_Remover
            // 
            button_Remover.BackColor = SystemColors.ControlLight;
            button_Remover.FlatAppearance.BorderSize = 0;
            button_Remover.FlatStyle = FlatStyle.Flat;
            button_Remover.Location = new Point(169, 175);
            button_Remover.Name = "button_Remover";
            button_Remover.Size = new Size(79, 23);
            button_Remover.TabIndex = 18;
            button_Remover.Text = "Remover";
            button_Remover.UseVisualStyleBackColor = false;
            button_Remover.Click += button_Remover_Click;
            // 
            // button_Adicionar
            // 
            button_Adicionar.BackColor = SystemColors.ControlLight;
            button_Adicionar.FlatAppearance.BorderSize = 0;
            button_Adicionar.FlatStyle = FlatStyle.Flat;
            button_Adicionar.Location = new Point(0, 175);
            button_Adicionar.Name = "button_Adicionar";
            button_Adicionar.Size = new Size(77, 23);
            button_Adicionar.TabIndex = 16;
            button_Adicionar.Text = "Adicionar";
            button_Adicionar.UseVisualStyleBackColor = false;
            button_Adicionar.Click += button_Adicionar_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new Point(0, 203);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(760, 196);
            dataGridView.TabIndex = 21;
            dataGridView.CellClick += dataGridView_CellClick;
            // 
            // label_RetiradaCertidao
            // 
            label_RetiradaCertidao.Anchor = AnchorStyles.Left;
            label_RetiradaCertidao.AutoSize = true;
            label_RetiradaCertidao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_RetiradaCertidao.ForeColor = Color.Black;
            label_RetiradaCertidao.Location = new Point(169, 131);
            label_RetiradaCertidao.Name = "label_RetiradaCertidao";
            label_RetiradaCertidao.Size = new Size(50, 15);
            label_RetiradaCertidao.TabIndex = 14;
            label_RetiradaCertidao.Text = "Retirada";
            label_RetiradaCertidao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // datePicker_Retirada
            // 
            datePicker_Retirada.CalendarForeColor = SystemColors.ControlLight;
            datePicker_Retirada.CalendarMonthBackground = SystemColors.ControlLight;
            datePicker_Retirada.CalendarTitleBackColor = Color.OliveDrab;
            datePicker_Retirada.CalendarTrailingForeColor = Color.OliveDrab;
            datePicker_Retirada.CustomFormat = "";
            datePicker_Retirada.Format = DateTimePickerFormat.Short;
            datePicker_Retirada.Location = new Point(169, 148);
            datePicker_Retirada.Name = "datePicker_Retirada";
            datePicker_Retirada.Size = new Size(115, 23);
            datePicker_Retirada.TabIndex = 14;
            // 
            // textBox_TipoRegistro
            // 
            textBox_TipoRegistro.BackColor = SystemColors.ControlLight;
            textBox_TipoRegistro.BorderStyle = BorderStyle.None;
            textBox_TipoRegistro.CharacterCasing = CharacterCasing.Upper;
            textBox_TipoRegistro.Font = new Font("Segoe UI", 9F);
            textBox_TipoRegistro.ForeColor = Color.Black;
            textBox_TipoRegistro.Location = new Point(0, 36);
            textBox_TipoRegistro.Name = "textBox_TipoRegistro";
            textBox_TipoRegistro.PlaceholderText = "Certidão / Averbação / ...";
            textBox_TipoRegistro.Size = new Size(284, 16);
            textBox_TipoRegistro.TabIndex = 6;
            // 
            // label_Ato
            // 
            label_Ato.Anchor = AnchorStyles.Left;
            label_Ato.AutoSize = true;
            label_Ato.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Ato.ForeColor = Color.Black;
            label_Ato.Location = new Point(0, 17);
            label_Ato.Name = "label_Ato";
            label_Ato.Size = new Size(26, 15);
            label_Ato.TabIndex = 6;
            label_Ato.Text = "Ato";
            label_Ato.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Descricao
            // 
            textBox_Descricao.BackColor = SystemColors.ControlLight;
            textBox_Descricao.BorderStyle = BorderStyle.None;
            textBox_Descricao.CharacterCasing = CharacterCasing.Upper;
            textBox_Descricao.Font = new Font("Segoe UI", 9F);
            textBox_Descricao.ForeColor = Color.Black;
            textBox_Descricao.Location = new Point(0, 110);
            textBox_Descricao.Name = "textBox_Descricao";
            textBox_Descricao.PlaceholderText = "Lº , fls., nº ";
            textBox_Descricao.Size = new Size(284, 16);
            textBox_Descricao.TabIndex = 11;
            // 
            // label_RefRegistro
            // 
            label_RefRegistro.Anchor = AnchorStyles.Left;
            label_RefRegistro.AutoSize = true;
            label_RefRegistro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_RefRegistro.ForeColor = Color.Black;
            label_RefRegistro.Location = new Point(0, 91);
            label_RefRegistro.Name = "label_RefRegistro";
            label_RefRegistro.Size = new Size(186, 15);
            label_RefRegistro.TabIndex = 11;
            label_RefRegistro.Text = "Descrição | Referência do Registro";
            label_RefRegistro.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numericUpDown_Certidao
            // 
            numericUpDown_Certidao.BackColor = SystemColors.ControlLight;
            numericUpDown_Certidao.BorderStyle = BorderStyle.None;
            numericUpDown_Certidao.Location = new Point(84, 150);
            numericUpDown_Certidao.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown_Certidao.Name = "numericUpDown_Certidao";
            numericUpDown_Certidao.Size = new Size(79, 19);
            numericUpDown_Certidao.TabIndex = 13;
            numericUpDown_Certidao.TextAlign = HorizontalAlignment.Center;
            numericUpDown_Certidao.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label_Quantidade
            // 
            label_Quantidade.Anchor = AnchorStyles.Left;
            label_Quantidade.AutoSize = true;
            label_Quantidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Quantidade.ForeColor = Color.Black;
            label_Quantidade.Location = new Point(84, 131);
            label_Quantidade.Name = "label_Quantidade";
            label_Quantidade.Size = new Size(69, 15);
            label_Quantidade.TabIndex = 13;
            label_Quantidade.Text = "Quantidade";
            label_Quantidade.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Valor
            // 
            textBox_Valor.BackColor = SystemColors.ControlLight;
            textBox_Valor.BorderStyle = BorderStyle.None;
            textBox_Valor.CharacterCasing = CharacterCasing.Upper;
            textBox_Valor.Font = new Font("Segoe UI", 9.5F);
            textBox_Valor.ForeColor = Color.Black;
            textBox_Valor.Location = new Point(0, 151);
            textBox_Valor.Name = "textBox_Valor";
            textBox_Valor.Size = new Size(77, 17);
            textBox_Valor.TabIndex = 12;
            textBox_Valor.KeyPress += textBox_Valor_KeyPress;
            // 
            // label_ValorCertidao
            // 
            label_ValorCertidao.Anchor = AnchorStyles.Left;
            label_ValorCertidao.AutoSize = true;
            label_ValorCertidao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_ValorCertidao.ForeColor = Color.Black;
            label_ValorCertidao.Location = new Point(0, 131);
            label_ValorCertidao.Name = "label_ValorCertidao";
            label_ValorCertidao.Size = new Size(62, 15);
            label_ValorCertidao.TabIndex = 12;
            label_ValorCertidao.Text = "Valor Item";
            label_ValorCertidao.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_PartesCertidao
            // 
            textBox_PartesCertidao.BackColor = SystemColors.ControlLight;
            textBox_PartesCertidao.BorderStyle = BorderStyle.None;
            textBox_PartesCertidao.CharacterCasing = CharacterCasing.Upper;
            textBox_PartesCertidao.Font = new Font("Segoe UI", 9F);
            textBox_PartesCertidao.ForeColor = Color.Black;
            textBox_PartesCertidao.Location = new Point(0, 73);
            textBox_PartesCertidao.Name = "textBox_PartesCertidao";
            textBox_PartesCertidao.Size = new Size(284, 16);
            textBox_PartesCertidao.TabIndex = 9;
            textBox_PartesCertidao.Visible = false;
            // 
            // label_PartesCertidao
            // 
            label_PartesCertidao.Anchor = AnchorStyles.Left;
            label_PartesCertidao.AutoSize = true;
            label_PartesCertidao.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_PartesCertidao.ForeColor = Color.Black;
            label_PartesCertidao.Location = new Point(0, 54);
            label_PartesCertidao.Name = "label_PartesCertidao";
            label_PartesCertidao.Size = new Size(47, 15);
            label_PartesCertidao.TabIndex = 9;
            label_PartesCertidao.Text = "Parte(s)";
            label_PartesCertidao.TextAlign = ContentAlignment.MiddleLeft;
            label_PartesCertidao.Visible = false;
            // 
            // textBox_ReciboProv
            // 
            textBox_ReciboProv.BackColor = SystemColors.ControlLight;
            textBox_ReciboProv.BorderStyle = BorderStyle.None;
            textBox_ReciboProv.CharacterCasing = CharacterCasing.Upper;
            textBox_ReciboProv.Font = new Font("Segoe UI", 9.75F);
            textBox_ReciboProv.ForeColor = Color.Black;
            textBox_ReciboProv.Location = new Point(634, 10);
            textBox_ReciboProv.Name = "textBox_ReciboProv";
            textBox_ReciboProv.Size = new Size(137, 18);
            textBox_ReciboProv.TabIndex = 2;
            textBox_ReciboProv.Visible = false;
            textBox_ReciboProv.KeyPress += textBox_ReciboProv_KeyPress;
            // 
            // checkBox_ReciboProvisorio
            // 
            checkBox_ReciboProvisorio.AutoSize = true;
            checkBox_ReciboProvisorio.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox_ReciboProvisorio.Location = new Point(502, 11);
            checkBox_ReciboProvisorio.Name = "checkBox_ReciboProvisorio";
            checkBox_ReciboProvisorio.Size = new Size(118, 19);
            checkBox_ReciboProvisorio.TabIndex = 1;
            checkBox_ReciboProvisorio.Text = "Recibo Provisório";
            checkBox_ReciboProvisorio.UseVisualStyleBackColor = true;
            checkBox_ReciboProvisorio.CheckedChanged += checkBox_ReciboProvisorio_CheckedChanged;
            checkBox_ReciboProvisorio.KeyDown += checkBox_ReciboProvisorio_KeyDown;
            // 
            // label_NumeroReciboProv
            // 
            label_NumeroReciboProv.Anchor = AnchorStyles.Left;
            label_NumeroReciboProv.AutoSize = true;
            label_NumeroReciboProv.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_NumeroReciboProv.ForeColor = Color.Black;
            label_NumeroReciboProv.Location = new Point(616, 12);
            label_NumeroReciboProv.Name = "label_NumeroReciboProv";
            label_NumeroReciboProv.Size = new Size(19, 15);
            label_NumeroReciboProv.TabIndex = 21;
            label_NumeroReciboProv.Text = "nº";
            label_NumeroReciboProv.TextAlign = ContentAlignment.MiddleLeft;
            label_NumeroReciboProv.Visible = false;
            // 
            // label_Atendente
            // 
            label_Atendente.Anchor = AnchorStyles.Left;
            label_Atendente.AutoSize = true;
            label_Atendente.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Atendente.ForeColor = Color.Black;
            label_Atendente.Location = new Point(560, 30);
            label_Atendente.Name = "label_Atendente";
            label_Atendente.Size = new Size(75, 17);
            label_Atendente.TabIndex = 20;
            label_Atendente.Text = "Atendente:";
            label_Atendente.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox_Atendente
            // 
            textBox_Atendente.BackColor = SystemColors.ControlLight;
            textBox_Atendente.BorderStyle = BorderStyle.None;
            textBox_Atendente.CharacterCasing = CharacterCasing.Upper;
            textBox_Atendente.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Atendente.ForeColor = Color.Black;
            textBox_Atendente.Location = new Point(634, 30);
            textBox_Atendente.Name = "textBox_Atendente";
            textBox_Atendente.Size = new Size(137, 18);
            textBox_Atendente.TabIndex = 5;
            // 
            // textBox_Telefone
            // 
            textBox_Telefone.BackColor = SystemColors.ControlLight;
            textBox_Telefone.BorderStyle = BorderStyle.None;
            textBox_Telefone.CharacterCasing = CharacterCasing.Upper;
            textBox_Telefone.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox_Telefone.ForeColor = Color.Black;
            textBox_Telefone.Location = new Point(369, 30);
            textBox_Telefone.Name = "textBox_Telefone";
            textBox_Telefone.Size = new Size(190, 18);
            textBox_Telefone.TabIndex = 4;
            // 
            // label_Telefone
            // 
            label_Telefone.Anchor = AnchorStyles.Left;
            label_Telefone.AutoSize = true;
            label_Telefone.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Telefone.ForeColor = Color.Black;
            label_Telefone.Location = new Point(302, 30);
            label_Telefone.Name = "label_Telefone";
            label_Telefone.Size = new Size(61, 17);
            label_Telefone.TabIndex = 4;
            label_Telefone.Text = "Telefone:";
            label_Telefone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(784, 461);
            Controls.Add(textBox_Telefone);
            Controls.Add(label_Telefone);
            Controls.Add(textBox_Atendente);
            Controls.Add(textBox_ReciboProv);
            Controls.Add(label_Atendente);
            Controls.Add(label_NumeroReciboProv);
            Controls.Add(checkBox_ReciboProvisorio);
            Controls.Add(panel1);
            Controls.Add(textBox_CpfCnpj);
            Controls.Add(label_CpfCnpj);
            Controls.Add(textBox_Requerente);
            Controls.Add(label_Requerente);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gerador de Protocolos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown_Certidao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_Requerente;
        private TextBox textBox_Requerente;
        private Label label_CpfCnpj;
        private TextBox textBox_CpfCnpj;
        private Panel panel1;
        private TextBox textBox_PartesCertidao;
        private Label label_PartesCertidao;
        private TextBox textBox_Valor;
        private Label label_ValorCertidao;
        private NumericUpDown numericUpDown_Certidao;
        private Label label_Quantidade;
        private TextBox textBox_TipoRegistro;
        private Label label_Ato;
        private TextBox textBox_Descricao;
        private Label label_RefRegistro;
        private DateTimePicker datePicker_Retirada;
        private Label label_RetiradaCertidao;
        private Button button_Adicionar;
        private DataGridView dataGridView;
        private CheckBox checkBox_ReciboProvisorio;
        private CheckBox checkBox_ProtocoloLivro;
        private TextBox textBox_ReciboProv;
        private Label label_NumeroReciboProv;
        private Button button_Gerar;
        private Button button_Remover;
        private Label label_Total;
        private Label label_Atendente;
        private TextBox textBox_Atendente;
        private Label label_HorarioRetirada;
        private DateTimePicker timePicker;
        private Label label_CpfPartes;
        private TextBox textBox_CpfPartes;
        private CheckBox checkBox_Cpf;
        private TextBox textBox_Telefone;
        private Label label_Telefone;
        private Button button_Editar;
        private Button button_Limpar;
    }
}
