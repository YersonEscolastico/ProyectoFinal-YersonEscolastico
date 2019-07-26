using BLL;
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

namespace ProyectoFinal_YersonEscolastico.UI.Consultas
{
    public partial class cVentas : Form
    {
        public cVentas()
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
            var listado = new List<Ventas>();
            RepositorioBase<Ventas> db = new RepositorioBase<Ventas>();
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
                                listado = db.GetList(p => p.VentaId == id);
                                break;

                            case 2:
                                int id3 = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ClienteId == id3);
                                break;


                            case 3:
                                int id4 = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == id4);
                                break;


                            case 4:
                                decimal id5 = Convert.ToDecimal(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Total == id5);
                                break;

                            default:
                                break;
                        }
                        listado = listado.Where(c => c.FechaVenta.Date >= DesdedateTimePicker.Value.Date && c.FechaVenta.Date <= HastadateTimePicker.Value.Date).ToList();
                    }
                    else
                    {
                        listado = db.GetList(p => true);
                        listado = listado.Where(c => c.FechaVenta.Date >= DesdedateTimePicker.Value.Date && c.FechaVenta.Date <= HastadateTimePicker.Value.Date).ToList();
                    }

                    ConsultadataGridView.DataSource = null;
                    ConsultadataGridView.DataSource = listado;
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
                                listado = db.GetList(p => p.VentaId == id);
                                break;

                            case 2:
                                int id3 = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.ClienteId == id3);
                                break;


                            case 3:
                                int id4 = Convert.ToInt32(CriteriotextBox.Text);
                                listado = db.GetList(p => p.UsuarioId == id4);
                                break;


                            case 4:
                                decimal id5 = Convert.ToDecimal(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Total == id5);
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
                    ConsultadataGridView.DataSource = null;
                    ConsultadataGridView.DataSource = listado;
                }
                catch (Exception)
                { }
            }
        }
    }
}
