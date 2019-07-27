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
    public partial class ClientesReport : Form
    {
        private List<Clientes> ListaClientes;
        public ClientesReport(List<Clientes> clientes)
        {
            this.ListaClientes = clientes;
            InitializeComponent();
        }

        private void ClientesReport_Load(object sender, EventArgs e)
        {
            ListadoClientes listadoClientes = new ListadoClientes();
            listadoClientes.SetDataSource(ListaClientes);

            crystalReportViewer1.ReportSource = listadoClientes;
            crystalReportViewer1.Refresh();
        }
    }
}
