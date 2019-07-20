namespace ProyectoFinal_YersonEscolastico.UI.Registros
{
    partial class rClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.NombresTextBox = new System.Windows.Forms.TextBox();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.CedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TelefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CelularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.FechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FechaRegistroateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // NombresTextBox
            // 
            this.NombresTextBox.Location = new System.Drawing.Point(127, 59);
            this.NombresTextBox.Name = "NombresTextBox";
            this.NombresTextBox.Size = new System.Drawing.Size(188, 20);
            this.NombresTextBox.TabIndex = 2;
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(127, 19);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(47, 20);
            this.IdNumericUpDown.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cedula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sexo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombres";
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.SexoComboBox.Location = new System.Drawing.Point(127, 98);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(130, 21);
            this.SexoComboBox.TabIndex = 8;
            this.SexoComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SexoComboBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 211);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Direccion";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Fecha Registro";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Fecha Nacimiento";
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(127, 204);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(188, 20);
            this.DireccionTextBox.TabIndex = 15;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(127, 134);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(188, 20);
            this.EmailTextBox.TabIndex = 16;
            // 
            // CedulaMaskedTextBox
            // 
            this.CedulaMaskedTextBox.Location = new System.Drawing.Point(127, 169);
            this.CedulaMaskedTextBox.Mask = "999-9999999-9";
            this.CedulaMaskedTextBox.Name = "CedulaMaskedTextBox";
            this.CedulaMaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.CedulaMaskedTextBox.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 283);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Celular";
            // 
            // TelefonoMaskedTextBox
            // 
            this.TelefonoMaskedTextBox.Location = new System.Drawing.Point(127, 239);
            this.TelefonoMaskedTextBox.Mask = "000-000-0000";
            this.TelefonoMaskedTextBox.Name = "TelefonoMaskedTextBox";
            this.TelefonoMaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.TelefonoMaskedTextBox.TabIndex = 19;
            // 
            // CelularMaskedTextBox
            // 
            this.CelularMaskedTextBox.Location = new System.Drawing.Point(127, 276);
            this.CelularMaskedTextBox.Mask = "000-000-0000";
            this.CelularMaskedTextBox.Name = "CelularMaskedTextBox";
            this.CelularMaskedTextBox.Size = new System.Drawing.Size(130, 20);
            this.CelularMaskedTextBox.TabIndex = 20;
            // 
            // FechaNacimientoDateTimePicker
            // 
            this.FechaNacimientoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaNacimientoDateTimePicker.Location = new System.Drawing.Point(127, 314);
            this.FechaNacimientoDateTimePicker.Name = "FechaNacimientoDateTimePicker";
            this.FechaNacimientoDateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.FechaNacimientoDateTimePicker.TabIndex = 21;
            // 
            // FechaRegistroateTimePicker
            // 
            this.FechaRegistroateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaRegistroateTimePicker.Location = new System.Drawing.Point(127, 350);
            this.FechaRegistroateTimePicker.Name = "FechaRegistroateTimePicker";
            this.FechaRegistroateTimePicker.Size = new System.Drawing.Size(130, 20);
            this.FechaRegistroateTimePicker.TabIndex = 22;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Search_icon__1_;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BuscarButton.Location = new System.Drawing.Point(274, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(87, 27);
            this.BuscarButton.TabIndex = 25;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.Location = new System.Drawing.Point(286, 397);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 73);
            this.EliminarButton.TabIndex = 24;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuardarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.Location = new System.Drawing.Point(147, 397);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 73);
            this.GuardarButton.TabIndex = 23;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.add;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.Location = new System.Drawing.Point(12, 397);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 73);
            this.NuevoButton.TabIndex = 1;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // rClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Toyota;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(373, 488);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.FechaRegistroateTimePicker);
            this.Controls.Add(this.FechaNacimientoDateTimePicker);
            this.Controls.Add(this.CelularMaskedTextBox);
            this.Controls.Add(this.TelefonoMaskedTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CedulaMaskedTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.NombresTextBox);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rClientes";
            this.RightToLeftLayout = true;
            this.Text = "Registro de clientes";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.TextBox NombresTextBox;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SexoComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMaskedTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox TelefonoMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox CelularMaskedTextBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientoDateTimePicker;
        private System.Windows.Forms.DateTimePicker FechaRegistroateTimePicker;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}