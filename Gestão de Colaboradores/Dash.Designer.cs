namespace Gestão_de_Colaboradores
{
    partial class Dash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.SalvarArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.SalvarComoArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.NovoColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultarColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.AlterarColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarColbadorador = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.MapaColaborador = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 162);
            this.panel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.label3.Location = new System.Drawing.Point(35, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Logged in Time";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(62, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoColaboradores.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(44, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.CausesValidation = false;
            this.panelPrincipal.Controls.Add(this.menuStrip1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(166, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(501, 561);
            this.panelPrincipal.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AbrirArquivo,
            this.SalvarArquivo,
            this.SalvarComoArquivo});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem1.Text = "Arquivo";
            // 
            // AbrirArquivo
            // 
            this.AbrirArquivo.Name = "AbrirArquivo";
            this.AbrirArquivo.Size = new System.Drawing.Size(150, 22);
            this.AbrirArquivo.Text = "Abrir";
            // 
            // SalvarArquivo
            // 
            this.SalvarArquivo.Name = "SalvarArquivo";
            this.SalvarArquivo.Size = new System.Drawing.Size(150, 22);
            this.SalvarArquivo.Text = "Salvar";
            // 
            // SalvarComoArquivo
            // 
            this.SalvarComoArquivo.Name = "SalvarComoArquivo";
            this.SalvarComoArquivo.Size = new System.Drawing.Size(150, 22);
            this.SalvarComoArquivo.Text = "Salvar Como...";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NovoColaborador,
            this.ConsultarColaborador,
            this.AlterarColaborador,
            this.EliminarColbadorador});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(85, 20);
            this.toolStripMenuItem4.Text = "Colaborador";
            // 
            // NovoColaborador
            // 
            this.NovoColaborador.Name = "NovoColaborador";
            this.NovoColaborador.Size = new System.Drawing.Size(125, 22);
            this.NovoColaborador.Text = "Novo";
            this.NovoColaborador.Click += new System.EventHandler(this.NovoColaborador_Click);
            // 
            // ConsultarColaborador
            // 
            this.ConsultarColaborador.Name = "ConsultarColaborador";
            this.ConsultarColaborador.Size = new System.Drawing.Size(125, 22);
            this.ConsultarColaborador.Text = "Consultar";
            // 
            // AlterarColaborador
            // 
            this.AlterarColaborador.Name = "AlterarColaborador";
            this.AlterarColaborador.Size = new System.Drawing.Size(125, 22);
            this.AlterarColaborador.Text = "Alterar";
            // 
            // EliminarColbadorador
            // 
            this.EliminarColbadorador.Name = "EliminarColbadorador";
            this.EliminarColbadorador.Size = new System.Drawing.Size(125, 22);
            this.EliminarColbadorador.Text = "Eliminar";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MapaColaborador});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(43, 20);
            this.toolStripMenuItem5.Text = "Lista";
            // 
            // MapaColaborador
            // 
            this.MapaColaborador.Name = "MapaColaborador";
            this.MapaColaborador.Size = new System.Drawing.Size(206, 22);
            this.MapaColaborador.Text = "Mapa dos Colaboradores";
            // 
            // Dash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(667, 561);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão de Colaboradores";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private Panel panelPrincipal;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem AbrirArquivo;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem NovoColaborador;
        private ToolStripMenuItem ConsultarColaborador;
        private ToolStripMenuItem AlterarColaborador;
        private ToolStripMenuItem EliminarColbadorador;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem MapaColaborador;
        private ToolStripMenuItem SalvarArquivo;
        private ToolStripMenuItem SalvarComoArquivo;
    }
}