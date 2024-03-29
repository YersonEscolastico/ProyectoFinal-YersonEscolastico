﻿using BLL;
using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_YersonEscolastico.UI.Registros
{
    public partial class rVehiculos : Form
    {
        private int id;
        public rVehiculos(int id)
        {
            this.id = id;
            InitializeComponent();
            LlenarComboBox();
            LlenarComboBox1();
            LlenarComboBox2();
        }
        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            VinTextBox.Text = string.Empty;
            MarcaComboBox.Text = string.Empty;
            PlacaTextBox.Text = string.Empty;
            ModeloComboBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            ColorComboBox.Text = string.Empty;
            AnioTextBox.Text = string.Empty;
            DescripcionTextBox.Text = string.Empty;
            CostoNumericUpDown.Value = 0;
            PrecioNumericUpDown.Value = 0;
            EstadoComboBox.Text = string.Empty;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Vehiculos LlenaClase()
        {
            Vehiculos vehiculos = new Vehiculos();

            vehiculos.VehiculoId = (int)(IdNumericUpDown.Value);
            vehiculos.Vin = VinTextBox.Text;
            vehiculos.Marca = MarcaComboBox.Text;
            vehiculos.Placa = PlacaTextBox.Text;
            vehiculos.Modelo = ModeloComboBox.Text;
            vehiculos.Color = ColorComboBox.Text;
            vehiculos.Anio = AnioTextBox.Text;
            vehiculos.Descripcion = DescripcionTextBox.Text;
            vehiculos.Costo = (decimal)CostoNumericUpDown.Value;
            vehiculos.Precio = (decimal)PrecioNumericUpDown.Value;
            vehiculos.UsuarioId = id;
            vehiculos.Estado = EstadoComboBox.Text;
            vehiculos.FechaRegistro = FechaRegistroDateTimePicker.Value;

            return vehiculos;
        }


        private void LlenaCampos(Vehiculos vehiculos)
        {
            IdNumericUpDown.Value = vehiculos.VehiculoId;
            VinTextBox.Text = vehiculos.Vin;
            MarcaComboBox.Text = vehiculos.Marca;
            PlacaTextBox.Text = vehiculos.Placa;
            ModeloComboBox.Text = vehiculos.Modelo;
            ColorComboBox.Text = vehiculos.Color;
            AnioTextBox.Text = vehiculos.Anio;
            DescripcionTextBox.Text = vehiculos.Descripcion;
            CostoNumericUpDown.Value = vehiculos.Costo;
            PrecioNumericUpDown.Value = vehiculos.Precio;
            EstadoComboBox.Text = vehiculos.Estado;
            FechaRegistroDateTimePicker.Value = vehiculos.FechaRegistro;
        }

        public bool Repetidos()
        {
            bool paso = true;
            MyErrorProvider.Clear();
            if (RepetidosNo(VinTextBox.Text))
            {
                MyErrorProvider.SetError(VinTextBox, "Ya se ha registrado un vehiculo con este vin, intente de nuevo");
                VinTextBox.Focus();
                paso = false;
            }
            if (RepetidosNo(PlacaTextBox.Text))
            {
                MyErrorProvider.SetError(PlacaTextBox, "Ya se ha registrado un vehiculo con esta placa, intente de nuevo");
                PlacaTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (VinTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(VinTextBox, "Este campo no puede estar vacio");
                VinTextBox.Focus();
                paso = false;
            }
            if (MarcaComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(MarcaComboBox, "Este campo no puede estar vacio");
                MarcaComboBox.Focus();
                paso = false;
            }
            if (PlacaTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(PlacaTextBox, "Este campo no puede estar vacio");
                PlacaTextBox.Focus();
                paso = false;
            }
            if (ModeloComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ModeloComboBox, "No puede dejar este campo vacio");
                ModeloComboBox.Focus();
                paso = false;
            }
            if (ColorComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ColorComboBox, "No puede dejar este campo vacio");
                ColorComboBox.Focus();
                paso = false;
            }
            if (AnioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(AnioTextBox, "No puede dejar este campo vacio");
                AnioTextBox.Focus();
                paso = false;
            }

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "No puede dejar este campo vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }
            if (CostoNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostoNumericUpDown, "Debe ser mayor que 0");
                CostoNumericUpDown.Focus();
                paso = false;
            }
            if (PrecioNumericUpDown.Value <= CostoNumericUpDown.Value)
            {
                MyErrorProvider.SetError(PrecioNumericUpDown, "Debe ser mayor que el costo");
                PrecioNumericUpDown.Focus();
                paso = false;
            }
            if (EstadoComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EstadoComboBox, "Este campo no puede estar vacio");
                EstadoComboBox.Focus();
                paso = false;
            }
            return paso;
        }

        public bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Vehiculos> repositorio = new RepositorioBase<Vehiculos>();
            Vehiculos vehiculos = new Vehiculos();
            vehiculos = repositorio.Buscar((int)IdNumericUpDown.Value);
            return (vehiculos != null);
        }

        private void GuardarButton_Click_1(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
            Vehiculos vehiculos;
            bool paso = false;

            if (!Validar())
                return;

            vehiculos = LlenaClase();


            if (IdNumericUpDown.Value == 0)
            {
                if (!Repetidos())
                    return;
                paso = db.Guardar(vehiculos);

            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Vehiculo que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = db.Modificar(vehiculos);
                Limpiar();
                return;
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private int ToInt(object valor)
        {
            int retorno = 0;
            int.TryParse(valor.ToString(), out retorno);

            return retorno;
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
            int id;
            Vehiculos vehiculos = new Vehiculos();
            id = ToInt(IdNumericUpDown.Value);
            Limpiar();

            vehiculos = db.Buscar(id);

            if (vehiculos != null)
            {
                LlenaCampos(vehiculos);
            }
            else
            {
                Limpiar();
                MessageBox.Show("Vehiculo no existe");
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
            try
            {
                if (IdNumericUpDown.Value > 0)
                {
                    if (db.Eliminar((int)IdNumericUpDown.Value))
                    {
                        MessageBox.Show("Eliminado", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Limpiar();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("NO se pudo eliminar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ColorComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void LlenarComboBox()
        {
            RepositorioBase<OtrosColores> db = new RepositorioBase<OtrosColores>();
            var listado = new List<OtrosColores>();
            listado = db.GetList(p => true);
            ColorComboBox.DataSource = listado;
            ColorComboBox.DisplayMember = "Descripcion";
        }

        private void LlenarComboBox1()
        {
            RepositorioBase<OtrasMarcas> db = new RepositorioBase<OtrasMarcas>();
            var listado = new List<OtrasMarcas>();
            listado = db.GetList(p => true);
            MarcaComboBox.DataSource = listado;
            MarcaComboBox.DisplayMember = "Descripcion";
        }

        private void LlenarComboBox2()
        {
            RepositorioBase<OtrosModelos> db = new RepositorioBase<OtrosModelos>();
            var listado = new List<OtrosModelos>();
            listado = db.GetList(p => true);
            ModeloComboBox.DataSource = listado;
            ModeloComboBox.DisplayMember = "Descripcion";
        }

        private void OtroColorButton_Click(object sender, EventArgs e)
        {
            rOtrosColores ub = new rOtrosColores();
            ub.ShowDialog();
            this.Hide();
            var form2 = new rVehiculos(id);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void OtraMarcaButton_Click(object sender, EventArgs e)
        {
            rOtrasMarcas ub = new rOtrasMarcas();
            ub.ShowDialog();
            this.Hide();
            var form2 = new rVehiculos(id);
            form2.Closed += (s, args) => this.Close();
            form2.Show();

        }

        private void OtroModeloButton_Click(object sender, EventArgs e)
        {
            rOtrosModelos ub = new rOtrosModelos();
            ub.ShowDialog();
            this.Hide();
            var form2 = new rVehiculos(id);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        public static bool RepetidosNo(string vehiculo)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Vehiculos.Any(p => p.Vin.Equals(vehiculo)))
                {
                    paso = true;
                }

                if (db.Vehiculos.Any(p => p.Placa.Equals(vehiculo)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        private void PlacaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void DescripcionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || (e.KeyChar >= 97 && e.KeyChar <= 122) || (e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar == 8))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void AnioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void VinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}



