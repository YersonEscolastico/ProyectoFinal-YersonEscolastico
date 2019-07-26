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
        public void InciarSesion()
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            Expression<Func<Usuarios, bool>> filtro = x => true;
            List<Usuarios> usuario = new List<Usuarios>();
            var username = UsuarioTextBox.Text;
            var password = ContrasenaTextBox.Text;
            filtro = x => x.Usuario.Equals(username);
            usuario = Repositorio.GetList(filtro);

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
                    MessageBox.Show("Clave incorrecta.", "Supermarket Software", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                if (UsuarioTextBox.Text == string.Empty || ContrasenaTextBox.Text == string.Empty)
                    MessageBox.Show("Ingrese en todos los campos");
                else if (!usuario.Exists(x => x.Usuario.Equals(username)))
                    MessageBox.Show("Usuario no existe");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            InciarSesion();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            RepositorioBase<Usuarios> Repositorio = new RepositorioBase<Usuarios>();
            List<Usuarios> user = new List<Usuarios>();
            user = Repositorio.GetList(p => true);
            if (user.Count == 0)
            {
                Repositorio.Guardar(new Usuarios()
                {
                    Usuario = "admin",
                    Clave = Eramake.eCryptography.Encrypt("admin"),
                    Nombre = "Yerson",
                    Email = "yerson@gmail.com",
                    Fecha = DateTime.Now
                });
                return;
            }
        }
    }
}
