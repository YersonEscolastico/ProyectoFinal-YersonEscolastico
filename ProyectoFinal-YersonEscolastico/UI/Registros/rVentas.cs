using BLL;
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
    public partial class rVentas : Form
    {
        public List<VentasDetalle> Detalle { get; set; }
        public rVentas()
        {
            InitializeComponent();
            this.Detalle = new List<VentasDetalle>();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            TotalTextBox.Text = string.Empty;
            ClienteComboBox.Text = string.Empty;
            VehiculoComboBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            this.Detalle = new List<VentasDetalle>();
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Ventas LlenaClase()
        {
            Ventas ventas = new Ventas();
            ventas.Vehiculos = this.Detalle;

            if (IdNumericUpDown.Value == 0)
            {
                ventas.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            }
            else
            {
                ventas.ClienteId = Convert.ToInt32(ClienteComboBox.SelectedValue);
            }
            ventas.VentaId = Convert.ToInt32(IdNumericUpDown.Value);
            ventas.Precio = PrecioNumericUpDown.Value;
            ventas.FechaVenta = FechaVentaDateTimePicker.Value;

            return ventas;
        }

        private void LlenaCampos(Ventas ventas)
        {
            IdNumericUpDown.Value = ventas.VentaId;
            ClienteComboBox.SelectedValue = ventas.VentaId;
            PrecioNumericUpDown.Value = ventas.Precio;
            TotalTextBox.Text = ventas.Precio.ToString();
            FechaVentaDateTimePicker.Value = ventas.FechaVenta;
            this.Detalle = ventas.Vehiculos;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            Ventas ventas = db.Buscar((int)IdNumericUpDown.Value);
            return (ventas != null);
        }
    }
}
