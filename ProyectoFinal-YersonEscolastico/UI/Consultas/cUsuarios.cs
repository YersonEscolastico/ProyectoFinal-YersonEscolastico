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
using ProyectoFinal_YersonEscolastico.UI.Reportes;

namespace ProyectoFinal_YersonEscolastico.UI.Consultas
{
    public partial class cUsuarios : Form
    {
        public List<Usuarios> ListaUsuarios;
        public cUsuarios()
        {
            InitializeComponent();
        }


        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            Consultar();
        }

        private void Consultar()
        {
            var listado = new List<Usuarios>();
            RepositorioBase<Usuarios> db = new RepositorioBase<Usuarios>();
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
                                listado = db.GetList(p => p.UsuarioId == id);
                                break;

                            case 2:
                                listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                                break;

                            case 3:
                                listado = db.GetList(p => p.NivelAcceso.Contains(CriteriotextBox.Text));
                                break;

                            case 4:
                                listado = db.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                                break;

                            case 5:
                                listado = db.GetList(p => p.Clave.Contains(CriteriotextBox.Text));
                                break;

                            default:
                                break;
                        }
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    }
                    else
                    {
                        listado = db.GetList(p => true);
                        listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                    }

                    ListaUsuarios = listado;
                    ConsultadataGridView.DataSource = ListaUsuarios;
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
                                listado = db.GetList(p => p.UsuarioId == id);
                                break;

                            case 2:
                                listado = db.GetList(p => p.Nombre.Contains(CriteriotextBox.Text));
                                break;

                            case 3:
                                listado = db.GetList(p => p.NivelAcceso.Contains(CriteriotextBox.Text));
                                break;

                            case 4:
                                listado = db.GetList(p => p.Usuario.Contains(CriteriotextBox.Text));
                                break;

                            case 5:
                                listado = db.GetList(p => p.Clave.Contains(CriteriotextBox.Text));
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
                    ListaUsuarios = listado;
                    ConsultadataGridView.DataSource = ListaUsuarios;
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
                UsuariosReport reporte = new UsuariosReport(ListaUsuarios);
                reporte.ShowDialog();
            }
        }
    }
}
