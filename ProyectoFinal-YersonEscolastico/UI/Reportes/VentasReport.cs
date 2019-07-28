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

namespace ProyectoFinal_YersonEscolastico.UI.Reportes
{
    public partial class VentasReport : Form
    {
        private List<Ventas> ListaVentas;
        public VentasReport(List<Ventas> ventas)
        {
            this.ListaVentas = ventas;
            InitializeComponent();
        }

        private void UsuariosReport_Load(object sender, EventArgs e)
        {
            ListadoVentas listadoVentas = new ListadoVentas();
            listadoVentas.SetDataSource(ListaVentas);

            crystalReportViewer1.ReportSource = listadoVentas;
            crystalReportViewer1.Refresh();

        }
    }
}
