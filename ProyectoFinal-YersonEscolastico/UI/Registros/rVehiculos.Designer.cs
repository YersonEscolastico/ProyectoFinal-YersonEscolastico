﻿namespace ProyectoFinal_YersonEscolastico.UI.Registros
{
    partial class rVehiculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rVehiculos));
            this.ColorComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CostoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.FechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PlacaTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.VinTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EstadoComboBox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.MarcaComboBox = new System.Windows.Forms.ComboBox();
            this.ModeloComboBox = new System.Windows.Forms.ComboBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.OtraMarcaButton = new System.Windows.Forms.Button();
            this.OtroModeloButton = new System.Windows.Forms.Button();
            this.OtroColorButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.AnioTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorComboBox
            // 
            this.ColorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ColorComboBox.FormattingEnabled = true;
            this.ColorComboBox.Items.AddRange(new object[] {
            "Blanco",
            "Negro ",
            "Rojo",
            "Azul",
            "Gris",
            "Verde"});
            this.ColorComboBox.Location = new System.Drawing.Point(72, 194);
            this.ColorComboBox.Name = "ColorComboBox";
            this.ColorComboBox.Size = new System.Drawing.Size(122, 21);
            this.ColorComboBox.TabIndex = 8;
            this.ColorComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ColorComboBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "Color";
            // 
            // CostoNumericUpDown
            // 
            this.CostoNumericUpDown.Location = new System.Drawing.Point(397, 90);
            this.CostoNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.CostoNumericUpDown.Name = "CostoNumericUpDown";
            this.CostoNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.CostoNumericUpDown.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Vin";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(72, 17);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(64, 20);
            this.IdNumericUpDown.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "ID";
            // 
            // FechaRegistroDateTimePicker
            // 
            this.FechaRegistroDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaRegistroDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaRegistroDateTimePicker.Location = new System.Drawing.Point(397, 196);
            this.FechaRegistroDateTimePicker.Name = "FechaRegistroDateTimePicker";
            this.FechaRegistroDateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.FechaRegistroDateTimePicker.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Fecha Registro";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(397, 55);
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(161, 20);
            this.DescripcionTextBox.TabIndex = 11;
            this.DescripcionTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DescripcionTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Descripcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Año";
            // 
            // PlacaTextBox
            // 
            this.PlacaTextBox.Location = new System.Drawing.Point(72, 85);
            this.PlacaTextBox.MaxLength = 6;
            this.PlacaTextBox.Name = "PlacaTextBox";
            this.PlacaTextBox.Size = new System.Drawing.Size(119, 20);
            this.PlacaTextBox.TabIndex = 3;
            this.PlacaTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PlacaTextBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(296, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Costo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Marca";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Modelo";
            // 
            // VinTextBox
            // 
            this.VinTextBox.Location = new System.Drawing.Point(72, 55);
            this.VinTextBox.MaxLength = 8;
            this.VinTextBox.Name = "VinTextBox";
            this.VinTextBox.Size = new System.Drawing.Size(122, 20);
            this.VinTextBox.TabIndex = 2;
            this.VinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VinTextBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(296, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Precio";
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(397, 127);
            this.PrecioNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.PrecioNumericUpDown.TabIndex = 13;
            // 
            // EstadoComboBox
            // 
            this.EstadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EstadoComboBox.FormattingEnabled = true;
            this.EstadoComboBox.Items.AddRange(new object[] {
            "Disponible",
            "Vendido",
            "En reparacion"});
            this.EstadoComboBox.Location = new System.Drawing.Point(397, 163);
            this.EstadoComboBox.Name = "EstadoComboBox";
            this.EstadoComboBox.Size = new System.Drawing.Size(122, 21);
            this.EstadoComboBox.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 61;
            this.label12.Text = "Estado";
            // 
            // MarcaComboBox
            // 
            this.MarcaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MarcaComboBox.FormattingEnabled = true;
            this.MarcaComboBox.Items.AddRange(new object[] {
            "Blanco",
            "Negro ",
            "Rojo",
            "Azul",
            "Gris",
            "Verde"});
            this.MarcaComboBox.Location = new System.Drawing.Point(72, 121);
            this.MarcaComboBox.Name = "MarcaComboBox";
            this.MarcaComboBox.Size = new System.Drawing.Size(122, 21);
            this.MarcaComboBox.TabIndex = 4;
            // 
            // ModeloComboBox
            // 
            this.ModeloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeloComboBox.FormattingEnabled = true;
            this.ModeloComboBox.Items.AddRange(new object[] {
            "Blanco",
            "Negro ",
            "Rojo",
            "Azul",
            "Gris",
            "Verde"});
            this.ModeloComboBox.Location = new System.Drawing.Point(72, 158);
            this.ModeloComboBox.Name = "ModeloComboBox";
            this.ModeloComboBox.Size = new System.Drawing.Size(122, 21);
            this.ModeloComboBox.TabIndex = 6;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // OtraMarcaButton
            // 
            this.OtraMarcaButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.otro;
            this.OtraMarcaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OtraMarcaButton.Location = new System.Drawing.Point(200, 117);
            this.OtraMarcaButton.Name = "OtraMarcaButton";
            this.OtraMarcaButton.Size = new System.Drawing.Size(64, 27);
            this.OtraMarcaButton.TabIndex = 5;
            this.OtraMarcaButton.Text = "Otro";
            this.OtraMarcaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OtraMarcaButton.UseVisualStyleBackColor = true;
            this.OtraMarcaButton.Click += new System.EventHandler(this.OtraMarcaButton_Click);
            // 
            // OtroModeloButton
            // 
            this.OtroModeloButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.otro;
            this.OtroModeloButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OtroModeloButton.Location = new System.Drawing.Point(200, 155);
            this.OtroModeloButton.Name = "OtroModeloButton";
            this.OtroModeloButton.Size = new System.Drawing.Size(64, 24);
            this.OtroModeloButton.TabIndex = 7;
            this.OtroModeloButton.Text = "Otro";
            this.OtroModeloButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OtroModeloButton.UseVisualStyleBackColor = true;
            this.OtroModeloButton.Click += new System.EventHandler(this.OtroModeloButton_Click);
            // 
            // OtroColorButton
            // 
            this.OtroColorButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.otro;
            this.OtroColorButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OtroColorButton.Location = new System.Drawing.Point(200, 191);
            this.OtroColorButton.Name = "OtroColorButton";
            this.OtroColorButton.Size = new System.Drawing.Size(64, 24);
            this.OtroColorButton.TabIndex = 9;
            this.OtroColorButton.Text = "  Otro";
            this.OtroColorButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.OtroColorButton.UseVisualStyleBackColor = true;
            this.OtroColorButton.Click += new System.EventHandler(this.OtroColorButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Search_icon__1_;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(142, 15);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(89, 22);
            this.BuscarButton.TabIndex = 19;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.delete;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.Location = new System.Drawing.Point(387, 280);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(75, 71);
            this.EliminarButton.TabIndex = 18;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Save;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.Location = new System.Drawing.Point(255, 280);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(75, 71);
            this.GuardarButton.TabIndex = 17;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click_1);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.add;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.Location = new System.Drawing.Point(119, 280);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(75, 71);
            this.NuevoButton.TabIndex = 16;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // AnioTextBox
            // 
            this.AnioTextBox.Location = new System.Drawing.Point(393, 17);
            this.AnioTextBox.MaxLength = 4;
            this.AnioTextBox.Name = "AnioTextBox";
            this.AnioTextBox.Size = new System.Drawing.Size(122, 20);
            this.AnioTextBox.TabIndex = 10;
            this.AnioTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AnioTextBox_KeyPress);
            // 
            // rVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Toyota;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(565, 359);
            this.Controls.Add(this.AnioTextBox);
            this.Controls.Add(this.OtraMarcaButton);
            this.Controls.Add(this.OtroModeloButton);
            this.Controls.Add(this.ModeloComboBox);
            this.Controls.Add(this.MarcaComboBox);
            this.Controls.Add(this.OtroColorButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.EstadoComboBox);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.VinTextBox);
            this.Controls.Add(this.ColorComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CostoNumericUpDown);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FechaRegistroDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PlacaTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "rVehiculos";
            this.Text = "Registro de vehiculos";
            ((System.ComponentModel.ISupportInitialize)(this.CostoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ColorComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown CostoNumericUpDown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FechaRegistroDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PlacaTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox VinTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.ComboBox EstadoComboBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button OtroColorButton;
        private System.Windows.Forms.ComboBox MarcaComboBox;
        private System.Windows.Forms.ComboBox ModeloComboBox;
        private System.Windows.Forms.Button OtroModeloButton;
        private System.Windows.Forms.Button OtraMarcaButton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
        private System.Windows.Forms.TextBox AnioTextBox;
    }
}