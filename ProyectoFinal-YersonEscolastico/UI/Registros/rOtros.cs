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
    public partial class rOtros : Form
    {
        public rOtros()
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

        private Otros LlenarClase()
        { 
            Otros ubicaciones = new Otros();

            ubicaciones.UbicacionId = (int)(IdNumericUpDown.Value);
            ubicaciones.Descripcion = DescripcionTextBox.Text;
            return ubicaciones;
        }

        private void LlenarCampos(Otros ubicaciones)
        {
            IdNumericUpDown.Value = ubicaciones.UbicacionId;
            DescripcionTextBox.Text = ubicaciones.Descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Otros> db = new RepositorioBase<Otros>();
            Otros ubicaciones = db.Buscar((int)IdNumericUpDown.Value);
            return (ubicaciones != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Otros> db = new RepositorioBase<Otros>();
            Otros ubicaciones;
            bool paso = false;

            ubicaciones = LlenarClase();


            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(ubicaciones);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Otros> db = new RepositorioBase<Otros>();
            try
            {

                if (IdNumericUpDown.Value > 0)
                {
                    Otros ubicaciones = new Otros();
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
            RepositorioBase<Otros> db = new RepositorioBase<Otros>();
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
