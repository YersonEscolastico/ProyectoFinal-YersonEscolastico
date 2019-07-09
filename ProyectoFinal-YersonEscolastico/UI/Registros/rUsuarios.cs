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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            NombresTextBox.Text = string.Empty;
            UsuarioTextBox.Text = string.Empty;
            ContrasenaMaskedTextBox.Text = string.Empty;
            ConfirmarContrasenaMaskedTextBox.Text = string.Empty;
            FechaRegistroDateTimePicker.Value = DateTime.Now;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios ();

            usuarios.UsuarioId = (int)IdNumericUpDown.Value;
            usuarios.Nombre = NombresTextBox.Text;
            usuarios.Usuario = UsuarioTextBox.Text;
            usuarios.Clave = ContrasenaMaskedTextBox.Text;
            usuarios.ConfirmarClave = ConfirmarContrasenaMaskedTextBox.Text;
            usuarios.Fecha = FechaRegistroDateTimePicker.Value;
            return usuarios;
        }


        private void LlenarCampos(Usuarios usuarios)
        {
            IdNumericUpDown.Value = usuarios.UsuarioId;
            NombresTextBox.Text = usuarios.Nombre;
            UsuarioTextBox.Text = usuarios.Usuario;
            ContrasenaMaskedTextBox.Text = usuarios.Clave;
            ConfirmarContrasenaMaskedTextBox.Text = usuarios.ConfirmarClave;
            FechaRegistroDateTimePicker.Value = usuarios.Fecha;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios estudiante = db.Buscar((int)IdNumericUpDown.Value);
            return (estudiante != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios usuarios;
            bool paso = false;


            usuarios = LlenarClase();


            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(usuarios);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Usuario que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = db.Modificar(usuarios);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            try
            {

                if (IdNumericUpDown.Value > 0)
                {
                    Usuarios usuarios = new Usuarios();
                    if ((usuarios = db.Buscar((int)IdNumericUpDown.Value)) != null)
                    {
                        Limpiar();
                        LlenarCampos(usuarios);
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
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
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
