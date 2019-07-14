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
    public partial class rProveedores : Form
    {
        public rProveedores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            FechaRegistroateTimePicker.Value = DateTime.Now;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Proveedores LLenaCLase()
        {
            Proveedores proveedores = new Proveedores();

            proveedores.ProveedorId = (int)IdNumericUpDown.Value;
            proveedores.Nombres = NombresTextBox.Text;
            proveedores.Telefono = TelefonoMaskedTextBox.Text;
            proveedores.Celular = CelularMaskedTextBox.Text;
            proveedores.Email = EmailTextBox.Text;
            proveedores.Direccion = DireccionTextBox.Text;
            proveedores.FechaRegistro = FechaRegistroateTimePicker.Value;

            return proveedores;
        }

        private void LLenaCampos(Proveedores proveedores)
        {
            IdNumericUpDown.Value = proveedores.ProveedorId;
            NombresTextBox.Text = proveedores.Nombres;
            TelefonoMaskedTextBox.Text = proveedores.Telefono;
            CelularMaskedTextBox.Text = proveedores.Celular;
            EmailTextBox.Text = proveedores.Email;
            DireccionTextBox.Text = proveedores.Direccion;
            FechaRegistroateTimePicker.Value = proveedores.FechaRegistro;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            Proveedores proveedores = db.Buscar((int)IdNumericUpDown.Value);
            return (proveedores != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            Proveedores proveedores = new Proveedores();
            bool paso = false;


            proveedores = LLenaCLase();


            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(proveedores);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = db.Modificar(proveedores);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
            try
            {

                if (IdNumericUpDown.Value > 0)
                {
                    Proveedores proveedores = new Proveedores();
                    if ((proveedores = db.Buscar((int)IdNumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LLenaCampos(proveedores);
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
            RepositorioBase<Proveedores> db = new RepositorioBase<Proveedores>();
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
    }
}
