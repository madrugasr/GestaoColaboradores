namespace GestaoColaboradores.Colaborador
{
    partial class Novo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sair = new System.Windows.Forms.Button();
            this.nomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.telefone = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.ComboBox();
            this.dataNascimento = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.CadastrarColaborador = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.equipa = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.iban = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ordenado_bruto = new System.Windows.Forms.TextBox();
            this.ingresso = new System.Windows.Forms.DateTimePicker();
            this.contrato = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cargo = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.codigo_postal = new System.Windows.Forms.TextBox();
            this.rua = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numero_casa = new System.Windows.Forms.TextBox();
            this.concelho = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.niss = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nif = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatAppearance.BorderSize = 2;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sair.Location = new System.Drawing.Point(358, 514);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(122, 35);
            this.Sair.TabIndex = 8;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // nomeCompleto
            // 
            this.nomeCompleto.Location = new System.Drawing.Point(110, 22);
            this.nomeCompleto.Name = "nomeCompleto";
            this.nomeCompleto.Size = new System.Drawing.Size(180, 23);
            this.nomeCompleto.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome Completo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefone";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(312, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sexo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data de Nascimento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(68, 20);
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(86, 23);
            this.telefone.TabIndex = 14;
            // 
            // sexo
            // 
            this.sexo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sexo.FormattingEnabled = true;
            this.sexo.Items.AddRange(new object[] {
            "Feminimo",
            "Masculino"});
            this.sexo.Location = new System.Drawing.Point(353, 22);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(109, 23);
            this.sexo.TabIndex = 15;
            // 
            // dataNascimento
            // 
            this.dataNascimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataNascimento.Location = new System.Drawing.Point(130, 49);
            this.dataNascimento.Margin = new System.Windows.Forms.Padding(2);
            this.dataNascimento.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dataNascimento.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dataNascimento.Name = "dataNascimento";
            this.dataNascimento.Size = new System.Drawing.Size(101, 23);
            this.dataNascimento.TabIndex = 16;
            this.dataNascimento.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.email);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.telefone);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 259);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 56);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contatos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(160, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(202, 20);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(256, 23);
            this.email.TabIndex = 16;
            // 
            // CadastrarColaborador
            // 
            this.CadastrarColaborador.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CadastrarColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CadastrarColaborador.FlatAppearance.BorderSize = 2;
            this.CadastrarColaborador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CadastrarColaborador.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CadastrarColaborador.Location = new System.Drawing.Point(12, 514);
            this.CadastrarColaborador.Name = "CadastrarColaborador";
            this.CadastrarColaborador.Size = new System.Drawing.Size(125, 35);
            this.CadastrarColaborador.TabIndex = 19;
            this.CadastrarColaborador.Text = "Cadastrar";
            this.CadastrarColaborador.UseVisualStyleBackColor = true;
            this.CadastrarColaborador.Click += new System.EventHandler(this.CadastrarColaborador_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.equipa);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.iban);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.ordenado_bruto);
            this.groupBox4.Controls.Add(this.ingresso);
            this.groupBox4.Controls.Add(this.contrato);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.cargo);
            this.groupBox4.Controls.Add(this.cliente);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(12, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(468, 145);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Profissão";
            // 
            // equipa
            // 
            this.equipa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.equipa.FormattingEnabled = true;
            this.equipa.Items.AddRange(new object[] {
            "Desenvolvimento",
            "Engenharia",
            "Suporte IT",
            "Produto",
            "Financeiro",
            "Recursos Humanos",
            "Infraestrutura",
            "Teste"});
            this.equipa.Location = new System.Drawing.Point(56, 112);
            this.equipa.Name = "equipa";
            this.equipa.Size = new System.Drawing.Size(140, 23);
            this.equipa.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(8, 120);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Equipa";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iban
            // 
            this.iban.Location = new System.Drawing.Point(48, 51);
            this.iban.Name = "iban";
            this.iban.Size = new System.Drawing.Size(206, 23);
            this.iban.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(6, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "IBAN";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordenado_bruto
            // 
            this.ordenado_bruto.Location = new System.Drawing.Point(320, 22);
            this.ordenado_bruto.Name = "ordenado_bruto";
            this.ordenado_bruto.Size = new System.Drawing.Size(74, 23);
            this.ordenado_bruto.TabIndex = 26;
            // 
            // ingresso
            // 
            this.ingresso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ingresso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ingresso.Location = new System.Drawing.Point(70, 79);
            this.ingresso.Margin = new System.Windows.Forms.Padding(2);
            this.ingresso.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.ingresso.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.ingresso.Name = "ingresso";
            this.ingresso.Size = new System.Drawing.Size(101, 23);
            this.ingresso.TabIndex = 25;
            this.ingresso.Value = new System.DateTime(2022, 6, 20, 0, 0, 0, 0);
            // 
            // contrato
            // 
            this.contrato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.contrato.FormattingEnabled = true;
            this.contrato.Items.AddRange(new object[] {
            "Efetivo",
            "Temporário",
            "Sem Termo"});
            this.contrato.Location = new System.Drawing.Point(245, 79);
            this.contrato.Name = "contrato";
            this.contrato.Size = new System.Drawing.Size(98, 23);
            this.contrato.TabIndex = 24;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(183, 87);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 23;
            this.label14.Text = "Contrato";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(8, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "Ingresso";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(220, 30);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 15);
            this.label16.TabIndex = 19;
            this.label16.Text = "Ordenado Bruto";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(260, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(46, 15);
            this.label18.TabIndex = 15;
            this.label18.Text = "Cliente";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cargo
            // 
            this.cargo.Location = new System.Drawing.Point(48, 22);
            this.cargo.Name = "cargo";
            this.cargo.Size = new System.Drawing.Size(166, 23);
            this.cargo.TabIndex = 14;
            // 
            // cliente
            // 
            this.cliente.Location = new System.Drawing.Point(312, 51);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(150, 23);
            this.cliente.TabIndex = 16;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(6, 30);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 11;
            this.label19.Text = "Cargo";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.codigo_postal);
            this.groupBox2.Controls.Add(this.rua);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.numero_casa);
            this.groupBox2.Controls.Add(this.concelho);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 90);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Morada";
            // 
            // codigo_postal
            // 
            this.codigo_postal.Location = new System.Drawing.Point(332, 51);
            this.codigo_postal.Name = "codigo_postal";
            this.codigo_postal.Size = new System.Drawing.Size(63, 23);
            this.codigo_postal.TabIndex = 28;
            // 
            // rua
            // 
            this.rua.Location = new System.Drawing.Point(38, 22);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(287, 23);
            this.rua.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(245, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Código Postal";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(6, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 15);
            this.label10.TabIndex = 17;
            this.label10.Text = "Rua";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(8, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 15);
            this.label11.TabIndex = 15;
            this.label11.Text = "Concelho";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numero_casa
            // 
            this.numero_casa.Location = new System.Drawing.Point(361, 22);
            this.numero_casa.Name = "numero_casa";
            this.numero_casa.Size = new System.Drawing.Size(33, 23);
            this.numero_casa.TabIndex = 14;
            // 
            // concelho
            // 
            this.concelho.Location = new System.Drawing.Point(70, 51);
            this.concelho.Name = "concelho";
            this.concelho.Size = new System.Drawing.Size(169, 23);
            this.concelho.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(340, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "Nª";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.niss);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nif);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nomeCompleto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.sexo);
            this.groupBox1.Controls.Add(this.dataNascimento);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(468, 115);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // niss
            // 
            this.niss.Location = new System.Drawing.Point(279, 48);
            this.niss.Name = "niss";
            this.niss.Size = new System.Drawing.Size(100, 23);
            this.niss.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(239, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "NISS";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(38, 80);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(100, 23);
            this.nif.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "NIF";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(492, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.CadastrarColaborador);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.Sair);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(430, 493);
            this.Name = "Novo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Colaborador";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button Sair;
        private TextBox nomeCompleto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox telefone;
        private ComboBox sexo;
        private DateTimePicker dataNascimento;
        private GroupBox groupBox3;
        private Label label5;
        private TextBox email;
        private Button CadastrarColaborador;
        private GroupBox groupBox4;
        private TextBox ordenado_bruto;
        private DateTimePicker ingresso;
        private Label label15;
        private Label label16;
        private Label label18;
        private TextBox cargo;
        private TextBox cliente;
        private Label label19;
        private GroupBox groupBox2;
        private Label label7;
        private Label label10;
        private Label label11;
        private TextBox numero_casa;
        private TextBox concelho;
        private Label label12;
        private TextBox rua;
        private GroupBox groupBox1;
        private TextBox iban;
        private Label label9;
        private TextBox niss;
        private Label label8;
        private TextBox nif;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox codigo_postal;
        private ComboBox equipa;
        private Label label13;
        private ComboBox contrato;
        private Label label14;
    }
}