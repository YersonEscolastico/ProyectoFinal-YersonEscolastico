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
    public partial class rClientes : Form
    {
        private int id;
        public rClientes(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdNumericUpDown.Value = 0;
            NombresTextBox.Text = string.Empty;
            SexoComboBox.Text = string.Empty;
            EmailTextBox.Text = string.Empty;
            CedulaMaskedTextBox.Text = string.Empty;
            DireccionTextBox.Text = string.Empty;
            TelefonoMaskedTextBox.Text = string.Empty;
            CelularMaskedTextBox.Text = string.Empty;
            FechaNacimientoDateTimePicker.Value = DateTime.Now;
            FechaRegistroateTimePicker.Value = DateTime.Now;
        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private Clientes LlenarClase()
        {
            Clientes clientes = new Clientes();

            clientes.ClienteId = (int)(IdNumericUpDown.Value);
            clientes.Nombres = NombresTextBox.Text;
            clientes.Sexo = SexoComboBox.Text;
            clientes.Email = EmailTextBox.Text;
            clientes.Cedula = CedulaMaskedTextBox.Text;
            clientes.Direccion = DireccionTextBox.Text;
            clientes.Telefono = TelefonoMaskedTextBox.Text;
            clientes.Celular = CelularMaskedTextBox.Text;
            clientes.UsuarioId = id;
            clientes.FechaNacimiento = FechaNacimientoDateTimePicker.Value;
            clientes.FechaRegistro = FechaNacimientoDateTimePicker.Value;
            return clientes;
        }

        private void LlenarCampos(Clientes clientes)
        {
            IdNumericUpDown.Value = clientes.ClienteId;
            NombresTextBox.Text = clientes.Nombres;
            SexoComboBox.Text = clientes.Sexo;
            EmailTextBox.Text = clientes.Email;
            CedulaMaskedTextBox.Text = clientes.Cedula;
            DireccionTextBox.Text = clientes.Direccion;
            TelefonoMaskedTextBox.Text = clientes.Telefono;
            CelularMaskedTextBox.Text = clientes.Celular;
            FechaNacimientoDateTimePicker.Value = clientes.FechaNacimiento;
            FechaRegistroateTimePicker.Value = clientes.FechaRegistro;
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (NombresTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(NombresTextBox, "Este campo no puede estar vacio");
                NombresTextBox.Focus();
                paso = false;
            }
            if (SexoComboBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(SexoComboBox, "Este campo no puede estar vacio");
                SexoComboBox.Focus();
                paso = false;
            }
            if (EmailTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(EmailTextBox, "Este campo no puede estar vacio");
                EmailTextBox.Focus();
                paso = false;
            }
            if (DireccionTextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DireccionTextBox, "No puede dejar este campo vacio");
                DireccionTextBox.Focus();
                paso = false;
            }
            if (FechaNacimientoDateTimePicker.Value >= DateTime.Now)
            {
                MyErrorProvider.SetError(FechaNacimientoDateTimePicker, "Fecha de nacimiento debe ser menor que hoy");
                FechaNacimientoDateTimePicker.Focus();
                paso = false;
            }
            if (FechaRegistroateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaRegistroateTimePicker, "Fecha de registro no puede ser mayor a hoy");
                FechaRegistroateTimePicker.Focus();
                paso = false;
            }
            if (!TelefonoMaskedTextBox.MaskCompleted)
            {
                MyErrorProvider.SetError(TelefonoMaskedTextBox, "Ingrese un telefono correcto!!");
                paso = false;
            }
            if (!CelularMaskedTextBox.MaskCompleted)
            {
                MyErrorProvider.SetError(CelularMaskedTextBox, "Ingrese un celular correcto!!");
                paso = false;
            }
            if (!CedulaMaskedTextBox.MaskCompleted)
            {
                MyErrorProvider.SetError(CedulaMaskedTextBox, "Ingrese una cedula correcto!!");
                paso = false;
            }
            return paso;
        }

        public bool repetidos()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (RepetidosNo(EmailTextBox.Text))
            {
                MessageBox.Show("Ya existe este email, cree otro");
                EmailTextBox.Focus();
                paso = false;
            }
            if (RepetidosNo(CedulaMaskedTextBox.Text))
            {
                MessageBox.Show("Ya existe esta cedula, intente de nuevo");
                CedulaMaskedTextBox.Focus();
                paso = false;
            }

            if (RepetidosNo(TelefonoMaskedTextBox.Text))
            {
                MessageBox.Show("Ya existe este telefono, intente de nuevo");
                TelefonoMaskedTextBox.Focus();
                paso = false;
            }
            if (RepetidosNo(CelularMaskedTextBox.Text))
            {
                MessageBox.Show("Ya existe este celular, intente de nuevo");
                CelularMaskedTextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Clientes clientes= db.Buscar((int)IdNumericUpDown.Value);
            return (clientes != null);
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Clientes clientes;
            bool paso = false;

            if (!Validar())
                return;

            clientes = LlenarClase();


            if (IdNumericUpDown.Value == 0)
            {
                paso = db.Guardar(clientes);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un Cliente que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                paso = db.Modificar(clientes);
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
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            int id;
            Clientes clientes = new Clientes();
            id = ToInt(IdNumericUpDown.Value);
            Limpiar();

            clientes = db.Buscar(id);

            if (clientes != null)
            {
                LlenarCampos(clientes);
            }
            else
            {
                Limpiar();
                MessageBox.Show("cliente no existe");
            }
        }


        private void EliminarButton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
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

        private void SexoComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        public static bool RepetidosNo(string cliente)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Clientes.Any(p => p.Email.Equals(cliente)))
                {
                    paso = true;
                }

                if (db.Clientes.Any(p => p.Cedula.Equals(cliente)))
                {
                    paso = true;
                }
                if (db.Clientes.Any(p => p.Telefono.Equals(cliente)))
                {
                    paso = true;
                }
                if (db.Clientes.Any(p => p.Celular.Equals(cliente)))
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
