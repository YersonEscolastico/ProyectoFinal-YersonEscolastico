﻿using BLL;
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
        public rVehiculos()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            VinTextBox.Text = string.Empty;
            MarcaTextBox.Text = string.Empty;
            PlacaTextBox.Text = string.Empty;
            ModeloTextBox.Text = string.Empty;
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

            vehiculos.VehiculoId = (int)IdNumericUpDown.Value;
            vehiculos.Vin = VinTextBox.Text;
            vehiculos.Marca = MarcaTextBox.Text;
            vehiculos.Placa = PlacaTextBox.Text;
            vehiculos.Modelo = ModeloTextBox.Text;
            vehiculos.Color = ColorComboBox.Text;
            vehiculos.Anio = AnioTextBox.Text;
            vehiculos.Descripcion = DescripcionTextBox.Text;
            vehiculos.Costo = (decimal)CostoNumericUpDown.Value;
            vehiculos.Precio = (decimal)PrecioNumericUpDown.Value;
            vehiculos.Estado = EstadoComboBox.Text;
            vehiculos.FechaRegistro = FechaRegistroDateTimePicker.Value;

            return vehiculos;
        }

      
        private void LlenaCampos(Vehiculos vehiculos)
        {
            IdNumericUpDown.Value = vehiculos.VehiculoId;
            VinTextBox.Text = vehiculos.Vin;
            MarcaTextBox.Text = vehiculos.Marca;
            PlacaTextBox.Text = vehiculos.Placa;
            ModeloTextBox.Text = vehiculos.Modelo;
            ColorComboBox.Text = vehiculos.Color;
            AnioTextBox.Text = vehiculos.Anio;
            DescripcionTextBox.Text = vehiculos.Descripcion;
            CostoNumericUpDown.Value = vehiculos.Costo;
            PrecioNumericUpDown.Value = vehiculos.Precio;
            EstadoComboBox.Text = vehiculos.Estado;
            FechaRegistroDateTimePicker.Value = vehiculos.FechaRegistro;
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


            vehiculos = LlenaClase();


            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(vehiculos);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = db.Modificar(vehiculos);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
            try
            {

                if (IdNumericUpDown.Value > 0)
                {
                    Vehiculos vehiculos = new Vehiculos();
                    if ((vehiculos = db.Buscar((int)IdNumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenaCampos(vehiculos);
                    }
                    else
                    {
                        MessageBox.Show("No se pudo encontrar", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo buscar", "Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
