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
    public partial class cVehiculos : Form
    {
        public cVehiculos()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            var listado = new List<Vehiculos>();
            RepositorioBase<Vehiculos> db = new RepositorioBase<Vehiculos>();
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
                                listado = db.GetList(p => p.VehiculoId == id);
                                break;

                            case 2:
                                listado = db.GetList(p => p.Placa.Contains(CriteriotextBox.Text));
                                break;

                            case 3:
                                listado = db.GetList(p => p.Color.Contains(CriteriotextBox.Text));
                                break;

                            case 4:
                                listado = db.GetList(p => p.Anio.Contains(CriteriotextBox.Text));
                                break;

                            case 5:
                                decimal id2 = Convert.ToDecimal(CriteriotextBox.Text);
                                listado = db.GetList(p => p.Precio == id2);
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
                                listado = db.GetList(p => p.VehiculoId == id);
                                break;

                            case 2:
                                listado = db.GetList(p => p.Placa.Contains(CriteriotextBox.Text));
                                break;

                            case 3:
                                listado = db.GetList(p => p.Color.Contains(CriteriotextBox.Text));
                                break;

                            case 4:
                                listado = db.GetList(p => p.Anio.Contains(CriteriotextBox.Text));
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

