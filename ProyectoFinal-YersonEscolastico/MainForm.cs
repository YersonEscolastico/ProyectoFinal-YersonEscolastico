using ProyectoFinal_YersonEscolastico.UI.Consultas;
using ProyectoFinal_YersonEscolastico.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_YersonEscolastico
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios us = new rUsuarios();
            us.StartPosition = FormStartPosition.CenterScreen;
            us.Show();
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios us = new cUsuarios();
            us.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes  Cl = new rClientes();
            Cl.StartPosition = FormStartPosition.CenterScreen;
            Cl.Show();
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos vh = new rVehiculos();
            vh.StartPosition = FormStartPosition.CenterScreen;
            vh.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProveedores prov = new rProveedores();
            prov.StartPosition = FormStartPosition.CenterScreen;
            prov.Show();
        }
    }
}
