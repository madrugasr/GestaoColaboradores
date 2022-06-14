namespace Gestão_de_Colaboradores
{
    partial class Editar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editar));
            this.repeatPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.EditarRegistro = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Remover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // repeatPassword
            // 
            this.repeatPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.repeatPassword.Location = new System.Drawing.Point(157, 205);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.PasswordChar = '#';
            this.repeatPassword.Size = new System.Drawing.Size(142, 23);
            this.repeatPassword.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(35, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Repetir Senha";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditarRegistro
            // 
            this.EditarRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditarRegistro.FlatAppearance.BorderSize = 2;
            this.EditarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditarRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditarRegistro.Location = new System.Drawing.Point(38, 267);
            this.EditarRegistro.Name = "EditarRegistro";
            this.EditarRegistro.Size = new System.Drawing.Size(90, 32);
            this.EditarRegistro.TabIndex = 19;
            this.EditarRegistro.Text = "Editar";
            this.EditarRegistro.UseVisualStyleBackColor = true;
            this.EditarRegistro.Click += new System.EventHandler(this.EditarRegistro_Click);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password.Location = new System.Drawing.Point(98, 176);
            this.password.Name = "password";
            this.password.PasswordChar = '#';
            this.password.Size = new System.Drawing.Size(201, 23);
            this.password.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Senha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.email.Enabled = false;
            this.email.Location = new System.Drawing.Point(98, 147);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(201, 23);
            this.email.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GestaoColaboradores.Properties.Resources.edit_profile;
            this.pictureBox1.Location = new System.Drawing.Point(189, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(35, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alterar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Remover
            // 
            this.Remover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remover.FlatAppearance.BorderSize = 2;
            this.Remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Remover.Location = new System.Drawing.Point(209, 267);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(90, 32);
            this.Remover.TabIndex = 22;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // Editar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.Remover);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditarRegistro);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Editar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox repeatPassword;
        private Label label4;
        private Button EditarRegistro;
        private TextBox password;
        private Label label3;
        private TextBox email;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Button Remover;

        public EventHandler CriarRegistro_Click { get; private set; }
    }
}