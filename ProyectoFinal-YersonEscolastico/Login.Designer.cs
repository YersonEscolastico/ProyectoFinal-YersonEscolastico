namespace ProyectoFinal_YersonEscolastico
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ContrasenaTextBox = new System.Windows.Forms.TextBox();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalirButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(113, 168);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.pictureBox1.ErrorImage = global::ProyectoFinal_YersonEscolastico.Properties.Resources.User;
            this.pictureBox1.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(113, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.LoginButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 382);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(612, 68);
            this.panel2.TabIndex = 14;
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.MidnightBlue;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.LoginButton.Image = ((System.Drawing.Image)(resources.GetObject("LoginButton.Image")));
            this.LoginButton.Location = new System.Drawing.Point(220, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(168, 51);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "ENTRAR";
            this.LoginButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ContrasenaTextBox
            // 
            this.ContrasenaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContrasenaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ContrasenaTextBox.ForeColor = System.Drawing.Color.Black;
            this.ContrasenaTextBox.Location = new System.Drawing.Point(148, 161);
            this.ContrasenaTextBox.Multiline = true;
            this.ContrasenaTextBox.Name = "ContrasenaTextBox";
            this.ContrasenaTextBox.PasswordChar = '*';
            this.ContrasenaTextBox.Size = new System.Drawing.Size(341, 38);
            this.ContrasenaTextBox.TabIndex = 12;
            this.ContrasenaTextBox.Text = "admin";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UsuarioTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsuarioTextBox.ForeColor = System.Drawing.Color.Black;
            this.UsuarioTextBox.Location = new System.Drawing.Point(148, 104);
            this.UsuarioTextBox.Multiline = true;
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(341, 38);
            this.UsuarioTextBox.TabIndex = 10;
            this.UsuarioTextBox.Text = "Usuario";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.SalirButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 62);
            this.panel1.TabIndex = 17;
     
            // 
            // SalirButton
            // 
            this.SalirButton.BackColor = System.Drawing.Color.Azure;
            this.SalirButton.FlatAppearance.BorderSize = 0;
            this.SalirButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SalirButton.Image = ((System.Drawing.Image)(resources.GetObject("SalirButton.Image")));
            this.SalirButton.Location = new System.Drawing.Point(539, 12);
            this.SalirButton.Name = "SalirButton";
            this.SalirButton.Size = new System.Drawing.Size(90, 35);
            this.SalirButton.TabIndex = 4;
            this.SalirButton.Text = "Salir";
            this.SalirButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SalirButton.UseVisualStyleBackColor = false;
            this.SalirButton.Click += new System.EventHandler(this.SalirButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Toyota;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(612, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ContrasenaTextBox);
            this.Controls.Add(this.UsuarioTextBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox ContrasenaTextBox;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SalirButton;
    }
}