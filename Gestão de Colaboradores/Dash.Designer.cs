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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dash));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.t = new System.Windows.Forms.Label();
            this.u = new System.Windows.Forms.Label();
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
            this.HoursNow = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.Size = new System.Drawing.Size(175, 561);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.time);
            this.panel2.Controls.Add(this.user);
            this.panel2.Controls.Add(this.t);
            this.panel2.Controls.Add(this.u);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 162);
            this.panel2.TabIndex = 0;
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(44, 122);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(39, 17);
            this.time.TabIndex = 3;
            this.time.Text = "Time";
            // 
            // user
            // 
            this.user.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.user.ForeColor = System.Drawing.Color.White;
            this.user.Location = new System.Drawing.Point(8, 96);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(33, 15);
            this.user.TabIndex = 2;
            this.user.Text = "User";
            this.user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(0, 0);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(100, 23);
            this.t.TabIndex = 0;
            // 
            // u
            // 
            this.u.Location = new System.Drawing.Point(0, 0);
            this.u.Name = "u";
            this.u.Size = new System.Drawing.Size(100, 23);
            this.u.TabIndex = 1;
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
            this.panelPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPrincipal.CausesValidation = false;
            this.panelPrincipal.Controls.Add(this.menuStrip1);
            this.panelPrincipal.Location = new System.Drawing.Point(175, 0);
            this.panelPrincipal.MinimumSize = new System.Drawing.Size(492, 561);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(492, 561);
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
            this.menuStrip1.Size = new System.Drawing.Size(490, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.TabStop = true;
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
            this.ConsultarColaborador.Click += new System.EventHandler(this.ConsultarColaborador_Click);
            // 
            // AlterarColaborador
            // 
            this.AlterarColaborador.Name = "AlterarColaborador";
            this.AlterarColaborador.Size = new System.Drawing.Size(125, 22);
            this.AlterarColaborador.Text = "Alterar";
            this.AlterarColaborador.Click += new System.EventHandler(this.AlterarColaborador_Click);
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
            // HoursNow
            // 
            this.HoursNow.Enabled = true;
            this.HoursNow.Tick += new System.EventHandler(this.HoursNow_Tick);
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
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(683, 600);
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
        private Label u;
        private PictureBox pictureBox1;
        private Label t;
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
        private Label time;
        private Label user;
        private System.Windows.Forms.Timer HoursNow;
    }
}