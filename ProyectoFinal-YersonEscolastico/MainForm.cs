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
        public int id { get; set; }
        public MainForm(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void UsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rUsuarios us = new rUsuarios();
            us.MdiParent = this;
            us.StartPosition = FormStartPosition.CenterScreen;
            us.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes  Cl = new rClientes(id);
            Cl.MdiParent = this;
            Cl.StartPosition = FormStartPosition.CenterScreen;
            Cl.Show();
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos vh = new rVehiculos(id);
            vh.MdiParent = this;
            vh.StartPosition = FormStartPosition.CenterScreen;
            vh.Show();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas ve = new rVentas(id);
            ve.MdiParent = this;
            ve.StartPosition = FormStartPosition.CenterScreen;
            ve.Show();
        }

        private void UsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cUsuarios us = new cUsuarios();
            us.StartPosition = FormStartPosition.CenterScreen;
            us.Show();
        }

        private void ClientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cClientes cl= new cClientes();
            cl.StartPosition = FormStartPosition.CenterScreen;
            cl.Show();
        }

        private void VehiculosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cVehiculos vh = new cVehiculos();
            vh.StartPosition = FormStartPosition.CenterScreen;
            vh.Show();
        }

        private void VentasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cVentas v = new cVentas();
            v.StartPosition = FormStartPosition.CenterScreen;
            v.Show();
        }
    }
}
