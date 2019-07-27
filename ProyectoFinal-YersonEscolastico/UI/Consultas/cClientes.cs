using BLL;
using Entidades;
using ProyectoFinal_YersonEscolastico.UI.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal_YersonEscolastico.UI.Consultas
{
    public partial class cClientes : Form
    {
        public List<Clientes> ListaClientes;
        public cClientes()
        {
            InitializeComponent();
            FiltrocomboBox.Text = "Todo";
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            var listado = new List<Clientes>();
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            if (FiltroFechacheckBox.Checked == true)
            {
                try
                {
                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.SelectedIndex)
                        {
                            case 0:
                                listado = db.GetList(p => true);
                                break;

                            case 1:
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ClienteId == id);
                                break;

                            case 2:
                                listado = db.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                                break;

                            case 3:
                                listado = db.GetList(p => p.Sexo.Contains(CriteriotextBox.Text));
                                break;

                            case 4:
                                listado = db.GetList(p => p.Email.Contains(CriteriotextBox.Text));
                                break;

                            case 5:
                                listado = db.GetList(p => p.Cedula.Contains(CriteriotextBox.Text));
                                break;

                            case 6:
                                listado = db.GetList(p => p.Direccion.Contains(CriteriotextBox.Text));
                                break;

                            case 7:
                                listado = db.GetList(p => p.Telefono.Contains(CriteriotextBox.Text));
                                break;

                            default:
                                break;
                        }
                        listado = listado.Where(c => c.FechaRegistro.Date >= DesdedateTimePicker.Value.Date && c.FechaRegistro.Date <= HastadateTimePicker.Value.Date).ToList();
                    }
                    else
                    {
                        listado = db.GetList(p => true);
                        listado = listado.Where(c => c.FechaRegistro.Date >= DesdedateTimePicker.Value.Date && c.FechaRegistro.Date <= HastadateTimePicker.Value.Date).ToList();
                    }

                    ListaClientes = listado;
                    ConsultadataGridView.DataSource = ListaClientes;
                }
                catch (Exception)
                { }
            }
            else
            {
                try
                {

                    if (CriteriotextBox.Text.Trim().Length > 0)
                    {
                        switch (FiltrocomboBox.SelectedIndex)
                        {
                            case 0:
                                listado = db.GetList(p => true);
                                break;

                            case 1:
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ClienteId == id);
                                break;

                            case 2:
                                listado = db.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                                break;

                            case 3:
                                listado = db.GetList(p => p.Sexo.Contains(CriteriotextBox.Text));
                                break;

                            case 4:
                                listado = db.GetList(p => p.Email.Contains(CriteriotextBox.Text));
                                break;

                            case 5:
                                listado = db.GetList(p => p.Cedula.Contains(CriteriotextBox.Text));
                                break;

                            case 6:
                                listado = db.GetList(p => p.Direccion.Contains(CriteriotextBox.Text));
                                break;

                            case 7:
                                listado = db.GetList(p => p.Telefono.Contains(CriteriotextBox.Text));
                                break;

                            default:
                                break;
                        }
                    }
                    else
                    {
                        if (FiltrocomboBox.Text == string.Empty)
                        {
                            MessageBox.Show("Filtro esta vacio");
                        }
                        else
                            if ((string)FiltrocomboBox.Text != "Todo")
                        {
                            if (CriteriotextBox.Text == string.Empty)
                            {
                                MessageBox.Show("Debe agregar algun criterio");
                            }
                        }
                        else
                        {
                            listado = db.GetList(p => true);
                        }
                    }
                    ListaClientes = listado;
                    ConsultadataGridView.DataSource = ListaClientes;
                }
                catch (Exception)
                { }
            }
        }

        private void ImprimirButton_Click(object sender, EventArgs e)
        {
            if (ConsultadataGridView.RowCount == 0)
            {
                MessageBox.Show("No hay Datos Para Imprimir");
                return;
            }
            else
            {
                ClientesReport reporte = new ClientesReport(ListaClientes);
                reporte.ShowDialog();
            }
        }
    }
}
