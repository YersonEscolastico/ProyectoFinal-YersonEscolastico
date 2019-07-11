﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_YersonEscolastico.UI.Reportes
{
    public partial class UsuariosReport : Form
    {
        private List<Usuarios> ListaUsuarios;
        public UsuariosReport(List<Usuarios> usuarios)
        {
            this.ListaUsuarios = usuarios;
            InitializeComponent();
        }

        private void UsuariosReport_Load(object sender, EventArgs e)
        {
            ListadoUsuario listadoUsuarios = new ListadoUsuario();
            listadoUsuarios.SetDataSource(ListaUsuarios);

            crystalReportViewer1.ReportSource = listadoUsuarios;
            crystalReportViewer1.Refresh();

        }
    }
}
