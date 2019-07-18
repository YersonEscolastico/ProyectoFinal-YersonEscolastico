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
            LlenarComboBox();
            LLenarComboBoxTwo();
            this.Detalle = new List<VentasDetalle>();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            TotalTextBox.Text = string.Empty;
            ClienteComboBox.Text = string.Empty;
            VehiculoComboBox.Text = string.Empty;
            PrecioNumericUpDown.Value = 0;
            MyErrorProvider.Clear();
            CargarGrid();
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
            ventas.CalcularMonto();
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
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            Ventas ventas = db.Buscar((int)IdNumericUpDown.Value);
            return (ventas != null);
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ventas ventas;
            bool paso = false;


            ventas = LlenaClase();
            ventas.CalcularMonto();
            if (IdNumericUpDown.Value == 0)
            {
                paso = RepositorioVentas.Guardar(ventas);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Estudiante que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                    MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    paso = RepositorioVentas.Modificar(ventas);          
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            LlenaClase();
            Limpiar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
            int id;
            Ventas ventas = new Ventas();

            int.TryParse(IdNumericUpDown.Text, out id);
            Limpiar();

            ventas = RepositorioVentas.Buscar(id);

            if (ventas != null)
            {
                LlenaCampos(ventas);
            }
            else
            {
                MessageBox.Show("Inscripcion no existe");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
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

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            if (VehiculoComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(VehiculoComboBox, "Este campo no puede estar vacio");
                VehiculoComboBox.Focus();
                return;
            }

            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
            Vehiculos vehiculos = db.Buscar((int)VehiculoComboBox.SelectedValue);
            if (detalleDataGridView.DataSource != null)
                this.Detalle = (List<VentasDetalle>)detalleDataGridView.DataSource;

            var subtotal = vehiculos.Precio = PrecioNumericUpDown.Value;

            this.Detalle.Add(new VentasDetalle()
            {
                VentaId = (int)IdNumericUpDown.Value,
                VehiculoId = (int)VehiculoComboBox.SelectedValue,
                VentasDetalleID = 0,
                SubTotal = subtotal
            });
            CargarGrid();
        }


        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (detalleDataGridView.Rows.Count > 0 && detalleDataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(detalleDataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }


        private void CargarGrid()
        {
            detalleDataGridView.DataSource = null;
            detalleDataGridView.DataSource = Detalle;
        }

        private void LlenarComboBox()
        {
            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
            var listado2 = new List<Vehiculos>();
            listado2 = db.GetList(p => true);
            VehiculoComboBox.DataSource = listado2;
            VehiculoComboBox.DisplayMember = "Descripcion";
            VehiculoComboBox.ValueMember = "VehiculoId";
        }

        private void LLenarComboBoxTwo()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            var listado = new List<Clientes>();
            listado = db.GetList(l => true);
            ClienteComboBox.DataSource = listado;
            ClienteComboBox.DisplayMember = "Nombres";
            ClienteComboBox.ValueMember = "ClienteId";
        }
    }
}
