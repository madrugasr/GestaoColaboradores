namespace GestaoColaboradores.Colaborador
{
    partial class Eliminar
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
            this.listaColaboradores = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nif = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaColaboradores)).BeginInit();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sair.FlatAppearance.BorderSize = 2;
            this.Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Sair.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sair.Location = new System.Drawing.Point(331, 450);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(88, 35);
            this.Sair.TabIndex = 10;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // listaColaboradores
            // 
            this.listaColaboradores.AllowUserToAddRows = false;
            this.listaColaboradores.AllowUserToDeleteRows = false;
            this.listaColaboradores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listaColaboradores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaColaboradores.Location = new System.Drawing.Point(12, 83);
            this.listaColaboradores.Name = "listaColaboradores";
            this.listaColaboradores.ReadOnly = true;
            this.listaColaboradores.RowTemplate.Height = 25;
            this.listaColaboradores.Size = new System.Drawing.Size(407, 326);
            this.listaColaboradores.TabIndex = 11;
            // 
            // Excluir
            // 
            this.Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Excluir.FlatAppearance.BorderSize = 2;
            this.Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Excluir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Excluir.Location = new System.Drawing.Point(12, 450);
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(88, 35);
            this.Excluir.TabIndex = 12;
            this.Excluir.Text = "Excluir";
            this.Excluir.UseVisualStyleBackColor = true;
            this.Excluir.Click += new System.EventHandler(this.Excluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "NIF";
            // 
            // nif
            // 
            this.nif.Location = new System.Drawing.Point(47, 45);
            this.nif.Name = "nif";
            this.nif.Size = new System.Drawing.Size(78, 23);
            this.nif.TabIndex = 14;
            // 
            // Buscar
            // 
            this.Buscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Buscar.FlatAppearance.BorderSize = 2;
            this.Buscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Buscar.Image = global::GestaoColaboradores.Properties.Resources.buscar;
            this.Buscar.Location = new System.Drawing.Point(354, 32);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(65, 38);
            this.Buscar.TabIndex = 15;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(431, 497);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.nif);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Excluir);
            this.Controls.Add(this.listaColaboradores);
            this.Controls.Add(this.Sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eliminar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Colaborador";
            ((System.ComponentModel.ISupportInitialize)(this.listaColaboradores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Sair;
        private DataGridView listaColaboradores;
        private Button Excluir;
        private Label label1;
        private TextBox nif;
        private Button Buscar;
    }
}