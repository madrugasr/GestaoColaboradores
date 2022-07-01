namespace GestaoColaboradores.Arquivos
{
    partial class SalvarArquivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalvarArquivos));
            this.label1 = new System.Windows.Forms.Label();
            this.Sair = new System.Windows.Forms.Button();
            this.CaminhoArquivo = new System.Windows.Forms.Button();
            this.Abrir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nif = new System.Windows.Forms.TextBox();
            this.caminho = new System.Windows.Forms.ComboBox();
            this.VerArquivo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.VerArquivo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(125, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salvar Arquivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatAppearance.BorderSize = 2;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sair.Location = new System.Drawing.Point(305, 445);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(109, 35);
            this.Sair.TabIndex = 10;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // CaminhoArquivo
            // 
            this.CaminhoArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CaminhoArquivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CaminhoArquivo.FlatAppearance.BorderSize = 2;
            this.CaminhoArquivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CaminhoArquivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CaminhoArquivo.Location = new System.Drawing.Point(20, 445);
            this.CaminhoArquivo.Name = "CaminhoArquivo";
            this.CaminhoArquivo.Size = new System.Drawing.Size(109, 35);
            this.CaminhoArquivo.TabIndex = 11;
            this.CaminhoArquivo.Text = "Salvar";
            this.CaminhoArquivo.UseVisualStyleBackColor = true;
            this.CaminhoArquivo.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Abrir
            // 
            this.Abrir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Abrir.FlatAppearance.BorderSize = 0;
            this.Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Abrir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Abrir.Image = ((System.Drawing.Image)(resources.GetObject("Abrir.Image")));
            this.Abrir.Location = new System.Drawing.Point(373, 108);
            this.Abrir.Margin = new System.Windows.Forms.Padding(0);
            this.Abrir.Name = "Abrir";
            this.Abrir.Size = new System.Drawing.Size(41, 46);
            this.Abrir.TabIndex = 12;
            this.Abrir.UseVisualStyleBackColor = true;
            this.Abrir.Click += new System.EventHandler(this.Abrir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(20, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "NIF";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(55, 94);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(100, 23);
            this.nif.TabIndex = 16;
            // 
            // caminho
            // 
            this.caminho.FormattingEnabled = true;
            this.caminho.Location = new System.Drawing.Point(20, 123);
            this.caminho.Name = "caminho";
            this.caminho.Size = new System.Drawing.Size(343, 23);
            this.caminho.TabIndex = 18;
            // 
            // VerArquivo
            // 
            this.VerArquivo.AllowUserToAddRows = false;
            this.VerArquivo.AllowUserToDeleteRows = false;
            this.VerArquivo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerArquivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerArquivo.Location = new System.Drawing.Point(20, 157);
            this.VerArquivo.Name = "VerArquivo";
            this.VerArquivo.ReadOnly = true;
            this.VerArquivo.RowTemplate.Height = 25;
            this.VerArquivo.Size = new System.Drawing.Size(394, 282);
            this.VerArquivo.TabIndex = 19;
            // 
            // SalvarArquivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 495);
            this.Controls.Add(this.VerArquivo);
            this.Controls.Add(this.caminho);
            this.Controls.Add(this.nif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Abrir);
            this.Controls.Add(this.CaminhoArquivo);
            this.Controls.Add(this.Sair);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalvarArquivos";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salvar";
            ((System.ComponentModel.ISupportInitialize)(this.VerArquivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button Sair;
        private Button CaminhoArquivo;
        private Button Abrir;
        private Label label4;
        private TextBox nif;
        private ComboBox caminho;
        private DataGridView VerArquivo;
    }
}