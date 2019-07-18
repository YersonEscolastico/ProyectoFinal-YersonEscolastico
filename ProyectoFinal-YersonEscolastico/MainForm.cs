﻿using ProyectoFinal_YersonEscolastico.UI.Consultas;
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
            us.MdiParent = this;
            us.Show();
        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rClientes  Cl = new rClientes();
            Cl.StartPosition = FormStartPosition.CenterScreen;
            Cl.MdiParent = this;
            Cl.Show();
        }

        private void VehiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVehiculos vh = new rVehiculos();
            vh.StartPosition = FormStartPosition.CenterScreen;
            vh.MdiParent = this;
            vh.Show();
        }

        private void ProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rProveedores prov = new rProveedores();
            prov.StartPosition = FormStartPosition.CenterScreen;
            prov.MdiParent = this;
            prov.Show();
        }

        private void VentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rVentas ve = new rVentas();
            ve.StartPosition = FormStartPosition.CenterScreen;
            ve.MdiParent = this;
            ve.Show();
        }
    }
}
