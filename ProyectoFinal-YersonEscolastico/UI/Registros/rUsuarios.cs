using BLL;
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
    public partial class rUsuarios : Form
    {
        public rUsuarios()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            UsuarioTextBox.Text = string.Empty;
            NivelAccesocomboBox.Text = string.Empty;
            TotalVentasTextBox.Text = string.Empty;
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

            usuarios.UsuarioId = (int)(IdNumericUpDown.Value);
            usuarios.Nombre = NombresTextBox.Text;
            usuarios.Email = EmailTextBox.Text;
            usuarios.NivelAcceso = NivelAccesocomboBox.Text;
            usuarios.Usuario = UsuarioTextBox.Text;
            usuarios.TotalVentas = 0;
            usuarios.Clave = Eramake.eCryptography.Encrypt(ContrasenaMaskedTextBox.Text);
            usuarios.Fecha = FechaRegistroDateTimePicker.Value;
            return usuarios;
        }

        private void LlenarCampos(Usuarios usuarios)
        {
            IdNumericUpDown.Value = usuarios.UsuarioId;
            NombresTextBox.Text = usuarios.Nombre;
            EmailTextBox.Text = usuarios.Email;
            NivelAccesocomboBox.Text = usuarios.NivelAcceso;
            UsuarioTextBox.Text = usuarios.Usuario;
            TotalVentasTextBox.Text = usuarios.TotalVentas.ToString();
            ContrasenaMaskedTextBox.Text = Eramake.eCryptography.Decrypt(usuarios.Clave);
            ContrasenaMaskedTextBox.Text = Eramake.eCryptography.Decrypt(usuarios.Clave);
            FechaRegistroDateTimePicker.Value = usuarios.Fecha;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            string clave = ContrasenaMaskedTextBox.Text;
            string confirmacion = ConfirmarContrasenaMaskedTextBox.Text;

            int result = 0;
            result = string.Compare(clave, confirmacion);

            if (result != 0)
            {
                MyErrorProvider.SetError(ConfirmarContrasenaMaskedTextBox, "Las claves no coinciden");
                ConfirmarContrasenaMaskedTextBox.Focus();
                paso = false;
            }
            if (NombresTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombresTextBox, "Este campo no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }
            if (EmailTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EmailTextBox, "Este campo no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }
            if (UsuarioTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(UsuarioTextBox, "Este campo no puede estar vacio");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (NivelAccesocomboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NivelAccesocomboBox, "No puede dejar este campo vacio");
                NivelAccesocomboBox.Focus();
                paso = false;
            }
            if (ContrasenaMaskedTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ContrasenaMaskedTextBox, "Este campo no puede estar vacio");
                ContrasenaMaskedTextBox.Focus();
                paso = false;
            }
            if (ConfirmarContrasenaMaskedTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ConfirmarContrasenaMaskedTextBox, "Este campo no puede estar vacio");
                ConfirmarContrasenaMaskedTextBox.Focus();
                paso = false;
            }
            if (RepetidosNo(UsuarioTextBox.Text))
            {
                MessageBox.Show("Ya existe un usuario con este nombre");
                UsuarioTextBox.Focus();
                paso = false;
            }
            if (RepetidosNo(EmailTextBox.Text))
            {
                MessageBox.Show("Ya existe este email, cree otro");
                EmailTextBox.Focus();
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios usuarios = db.Buscar((int)IdNumericUpDown.Value);
            return (usuarios != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
            Usuarios usuarios;
            bool paso = false;

            if (!Validar())
                return;

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
                        Limpiar();
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

        private void NivelAccesocomboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static bool RepetidosNo(string usuarios)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Usuarios.Any(p => p.Usuario.Equals(usuarios)))
                {
                    paso = true;
                }
                if (db.Usuarios.Any(p => p.Email.Equals(usuarios)))
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

    }
}
