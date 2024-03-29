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
    public partial class VehiculosReport : Form
    {
        private List<Vehiculos> ListaVehiculos;
        public VehiculosReport(List<Vehiculos> vehiculos)
        {
            this.ListaVehiculos = vehiculos;
            InitializeComponent();
        }

        private void VehiculosReport_Load(object sender, EventArgs e)
        {
            ListadoVehiculos l = new ListadoVehiculos();
            l.SetDataSource(ListaVehiculos);

            crystalReportViewer1.ReportSource = l;
            crystalReportViewer1.Refresh();
        }
    }
}