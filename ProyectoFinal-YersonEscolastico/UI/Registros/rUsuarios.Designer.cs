namespace ProyectoFinal_YersonEscolastico.UI.Registros
{
    partial class rUsuarios
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
            this.FechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.ConfirmarContrasenaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ContrasenaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.Contraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.NivelAccesocomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.EliminarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaRegistroDateTimePicker
            // 
            this.FechaRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaRegistroDateTimePicker.Location = new System.Drawing.Point(130, 269);
            this.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker";
            this.FechaRegistroDateTimePicker.Size = new System.Drawing.Size(160, 20);
            this.FechaRegistroDateTimePicker.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fecha Registro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Nivel de Acceso";
            // 
            // BuscarButton
            // 
            this.BuscarButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BuscarButton.BackColor = System.Drawing.Color.White;
            this.BuscarButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BuscarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Buscar;
            this.BuscarButton.Location = new System.Drawing.Point(271, 11);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(91, 35);
            this.BuscarButton.TabIndex = 42;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BuscarButton.UseVisualStyleBackColor = false;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // ConfirmarContrasenaMaskedTextBox
            // 
            this.ConfirmarContrasenaMaskedTextBox.Location = new System.Drawing.Point(130, 236);
            this.ConfirmarContrasenaMaskedTextBox.Name = "ConfirmarContrasenaMaskedTextBox";
            this.ConfirmarContrasenaMaskedTextBox.PasswordChar = '*';
            this.ConfirmarContrasenaMaskedTextBox.Size = new System.Drawing.Size(160, 20);
            this.ConfirmarContrasenaMaskedTextBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Confirmar Contraseña";
            // 
            // ContrasenaMaskedTextBox
            // 
            this.ContrasenaMaskedTextBox.Location = new System.Drawing.Point(130, 201);
            this.ContrasenaMaskedTextBox.Name = "ContrasenaMaskedTextBox";
            this.ContrasenaMaskedTextBox.PasswordChar = '*';
            this.ContrasenaMaskedTextBox.Size = new System.Drawing.Size(160, 20);
            this.ContrasenaMaskedTextBox.TabIndex = 35;
            // 
            // Contraseña
            // 
            this.Contraseña.AutoSize = true;
            this.Contraseña.Location = new System.Drawing.Point(9, 208);
            this.Contraseña.Name = "Contraseña";
            this.Contraseña.Size = new System.Drawing.Size(61, 13);
            this.Contraseña.TabIndex = 34;
            this.Contraseña.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Usuario";
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(130, 169);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(160, 20);
            this.UsuarioTextBox.TabIndex = 32;
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(130, 61);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(160, 20);
            this.NombresTextBox.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Nombres";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(130, 26);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(78, 20);
            this.IdNumericUpDown.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "ID";
            // 
            // NivelAccesocomboBox
            // 
            this.NivelAccesocomboBox.FormattingEnabled = true;
            this.NivelAccesocomboBox.Items.AddRange(new object[] {
            "Administrador",
            "Usuario"});
            this.NivelAccesocomboBox.Location = new System.Drawing.Point(130, 132);
            this.NivelAccesocomboBox.Name = "NivelAccesocomboBox";
            this.NivelAccesocomboBox.Size = new System.Drawing.Size(100, 21);
            this.NivelAccesocomboBox.TabIndex = 46;
            this.NivelAccesocomboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NivelAccesocomboBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Email";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(130, 95);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(160, 20);
            this.EmailTextBox.TabIndex = 48;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // EliminarButton
            // 
            this.EliminarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.EliminarButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.EliminarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Eliminar;
            this.EliminarButton.Location = new System.Drawing.Point(271, 303);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(89, 57);
            this.EliminarButton.TabIndex = 41;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.EliminarButton.UseVisualStyleBackColor = false;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.NuevoButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NuevoButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Nuevo;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.Location = new System.Drawing.Point(12, 303);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(89, 57);
            this.NuevoButton.TabIndex = 40;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.NuevoButton.UseVisualStyleBackColor = false;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.GuardarButton.BackColor = System.Drawing.Color.White;
            this.GuardarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Guardar;
            this.GuardarButton.Location = new System.Drawing.Point(141, 303);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(89, 57);
            this.GuardarButton.TabIndex = 38;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.GuardarButton.UseVisualStyleBackColor = false;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // rUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 372);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NivelAccesocomboBox);
            this.Controls.Add(this.FechaRegistroDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.ConfirmarContrasenaMaskedTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ContrasenaMaskedTextBox);
            this.Controls.Add(this.Contraseña);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "rUsuarios";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "rUsuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker FechaRegistroDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.MaskedTextBox ConfirmarContrasenaMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox ContrasenaMaskedTextBox;
        private System.Windows.Forms.Label Contraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox NivelAccesocomboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}