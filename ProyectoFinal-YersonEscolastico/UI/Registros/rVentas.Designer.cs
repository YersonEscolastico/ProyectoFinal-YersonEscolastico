namespace ProyectoFinal_YersonEscolastico.UI.Registros
{
    partial class rVentas
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.IdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ClienteComboBox = new System.Windows.Forms.ComboBox();
            this.PrecioNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.FechaVentaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Removerbutton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.Agregarbutton = new System.Windows.Forms.Button();
            this.VehiculoComboBox = new System.Windows.Forms.ComboBox();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente";
            // 
            // IdNumericUpDown
            // 
            this.IdNumericUpDown.Location = new System.Drawing.Point(102, 18);
            this.IdNumericUpDown.Name = "IdNumericUpDown";
            this.IdNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.IdNumericUpDown.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fecha Venta";
            // 
            // ClienteComboBox
            // 
            this.ClienteComboBox.FormattingEnabled = true;
            this.ClienteComboBox.Location = new System.Drawing.Point(102, 53);
            this.ClienteComboBox.Name = "ClienteComboBox";
            this.ClienteComboBox.Size = new System.Drawing.Size(161, 21);
            this.ClienteComboBox.TabIndex = 7;
            // 
            // PrecioNumericUpDown
            // 
            this.PrecioNumericUpDown.Location = new System.Drawing.Point(102, 89);
            this.PrecioNumericUpDown.Name = "PrecioNumericUpDown";
            this.PrecioNumericUpDown.Size = new System.Drawing.Size(161, 20);
            this.PrecioNumericUpDown.TabIndex = 9;
            // 
            // FechaVentaDateTimePicker
            // 
            this.FechaVentaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaVentaDateTimePicker.Location = new System.Drawing.Point(102, 125);
            this.FechaVentaDateTimePicker.Name = "FechaVentaDateTimePicker";
            this.FechaVentaDateTimePicker.Size = new System.Drawing.Size(96, 20);
            this.FechaVentaDateTimePicker.TabIndex = 10;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(337, 182);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(66, 20);
            this.TotalTextBox.TabIndex = 56;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Total";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalTextBox);
            this.groupBox1.Controls.Add(this.Removerbutton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.Agregarbutton);
            this.groupBox1.Controls.Add(this.VehiculoComboBox);
            this.groupBox1.Controls.Add(this.detalleDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(15, 176);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(407, 222);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // Removerbutton
            // 
            this.Removerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Removerbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Removerbutton.Location = new System.Drawing.Point(16, 183);
            this.Removerbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Removerbutton.Name = "Removerbutton";
            this.Removerbutton.Size = new System.Drawing.Size(114, 28);
            this.Removerbutton.TabIndex = 37;
            this.Removerbutton.Text = "Remover fila";
            this.Removerbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Removerbutton.UseVisualStyleBackColor = true;
            this.Removerbutton.Click += new System.EventHandler(this.Removerbutton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Vehiculo";
            // 
            // Agregarbutton
            // 
            this.Agregarbutton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Nuevo;
            this.Agregarbutton.Location = new System.Drawing.Point(371, 17);
            this.Agregarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Agregarbutton.Name = "Agregarbutton";
            this.Agregarbutton.Size = new System.Drawing.Size(32, 31);
            this.Agregarbutton.TabIndex = 35;
            this.Agregarbutton.UseVisualStyleBackColor = true;
            this.Agregarbutton.Click += new System.EventHandler(this.Agregarbutton_Click);
            // 
            // VehiculoComboBox
            // 
            this.VehiculoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VehiculoComboBox.FormattingEnabled = true;
            this.VehiculoComboBox.Location = new System.Drawing.Point(87, 18);
            this.VehiculoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.VehiculoComboBox.Name = "VehiculoComboBox";
            this.VehiculoComboBox.Size = new System.Drawing.Size(161, 21);
            this.VehiculoComboBox.TabIndex = 7;
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(16, 56);
            this.detalleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.RowTemplate.Height = 24;
            this.detalleDataGridView.Size = new System.Drawing.Size(387, 122);
            this.detalleDataGridView.TabIndex = 0;
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardarbutton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Guardar;
            this.Guardarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Guardarbutton.Location = new System.Drawing.Point(173, 428);
            this.Guardarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(60, 57);
            this.Guardarbutton.TabIndex = 57;
            this.Guardarbutton.Text = "  Guardar";
            this.Guardarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminarbutton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Eliminar;
            this.Eliminarbutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Eliminarbutton.Location = new System.Drawing.Point(352, 428);
            this.Eliminarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(60, 57);
            this.Eliminarbutton.TabIndex = 56;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevobutton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Nuevo;
            this.Nuevobutton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Nuevobutton.Location = new System.Drawing.Point(15, 428);
            this.Nuevobutton.Margin = new System.Windows.Forms.Padding(2);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(60, 57);
            this.Nuevobutton.TabIndex = 55;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = global::ProyectoFinal_YersonEscolastico.Properties.Resources.Buscar;
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(336, 11);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(82, 40);
            this.Buscarbutton.TabIndex = 58;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 492);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaVentaDateTimePicker);
            this.Controls.Add(this.PrecioNumericUpDown);
            this.Controls.Add(this.ClienteComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IdNumericUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "rVentas";
            this.Text = "Registro de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.IdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrecioNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown IdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ClienteComboBox;
        private System.Windows.Forms.NumericUpDown PrecioNumericUpDown;
        private System.Windows.Forms.DateTimePicker FechaVentaDateTimePicker;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Removerbutton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Agregarbutton;
        private System.Windows.Forms.ComboBox VehiculoComboBox;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}