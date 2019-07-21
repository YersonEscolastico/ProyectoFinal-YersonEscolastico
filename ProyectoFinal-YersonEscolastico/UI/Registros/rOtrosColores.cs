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
    public partial class rOtrosColores : Form
    {
        public rOtrosColores()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            DescripcionTextBox.Text = string.Empty;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private OtrosColores LlenarClase()
        { 
            OtrosColores ubicaciones = new OtrosColores();

            ubicaciones.UbicacionId = (int)(IdNumericUpDown.Value);
            ubicaciones.Descripcion = DescripcionTextBox.Text;
            return ubicaciones;
        }

        private void LlenarCampos(OtrosColores ubicaciones)
        {
            IdNumericUpDown.Value = ubicaciones.UbicacionId;
            DescripcionTextBox.Text = ubicaciones.Descripcion;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripcionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripcionTextBox, "Este campo no puede estar vacio");
                DescripcionTextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<OtrosColores> db = new RepositorioBase<OtrosColores>();
            OtrosColores ubicaciones = db.Buscar((int)IdNumericUpDown.Value);
            return (ubicaciones != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<OtrosColores> db = new RepositorioBase<OtrosColores>();
            OtrosColores ubicaciones;
            bool paso = false;

            if (!Validar())
                return;

            ubicaciones = LlenarClase();

            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(ubicaciones);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Color que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = db.Modificar(ubicaciones);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();

            Close();
            rVehiculos rVehiculos = new rVehiculos();
            rVehiculos.Show();
           
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<OtrosColores> db = new RepositorioBase<OtrosColores>();
            try
            {

                if (IdNumericUpDown.Value > 0)
                {
                    OtrosColores ubicaciones = new OtrosColores();
                    if ((ubicaciones= db.Buscar((int)IdNumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenarCampos(ubicaciones);
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
            RepositorioBase<OtrosColores> db = new RepositorioBase<OtrosColores>();
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
