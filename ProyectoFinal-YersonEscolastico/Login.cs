using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_YersonEscolastico
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }
        public void IniciarSesion()
        {

            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Expression<Func<Usuarios, bool>> filtro = x => true;
            List<Usuarios> usuario = new List<Usuarios>();
            var username = UsuarioTextBox.Text;
            var password = ContrasenaTextBox.Text;
            filtro = x => x.Usuario.Equals(username);
            usuario = Repositorio.GetList(filtro);
            if (usuario.Count > 0)
            {
                if (usuario.Exists(x => x.Usuario.Equals(username)))
                {
                    if (usuario.Exists(x => x.Clave.Equals(Eramake.eCryptography.Encrypt(password))))
                    {

                        List<Usuarios> id = Repositorio.GetList(U => U.Usuario == UsuarioTextBox.Text);
                        MainForm f = new MainForm(id[0].UsuarioId);
                        f.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Clave incorrecta.");
                        return;
                    }
                }
            }
            else
            {
                if (UsuarioTextBox.Text == string.Empty)
                    MessageBox.Show("Ingrese un usuario.");
                else
                {
                    if (usuario.Count == 0)
                    {
                        Repositorio.Guardar(new Usuarios()
                        {
                            Nombre = "Yerson",
                            Usuario = "admin",
                            Email = "yerson@gmail.com",
                            Clave = Eramake.eCryptography.Encrypt("admin"), 
                            NivelAcceso="Administrador",
                            TotalVentas=0,
                            Fecha = DateTime.Now
                        });
                        MessageBox.Show("Nombre de usuarios o contraseña incorrectos");
                        return;
                    }
                }
            }
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
