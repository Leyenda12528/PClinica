using ProyectoTrr.Base;
using ProyectoTrr.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTrr
{
    public partial class AtenderConsulta : Form
    {
        private Consultas consul = new Consultas();
        private int idConsulta;
        private List<Consulta_Sintomas> Salida = new List<Consulta_Sintomas>();        
        public AtenderConsulta()
        {
            InitializeComponent();
            if (consul.CantConsultas() <= 0) MessageBox.Show("No hay consultas registradas");            
            else
            {
                Inicio();
            }
        }

        private void Inicio()
        {
            CargarDatos();
            Recorre();
            Vencido();
        }

        private void Recorre()
        {            
            if (DGVConsultas.Rows.Count > 0) 
            {
                Salida.Clear();
                for (int i = 0; i < DGVConsultas.RowCount; i++)
                {
                    int idConsulta1 = Convert.ToInt32(DGVConsultas.Rows[i].Cells[0].Value.ToString());

                    String tiempo = DGVConsultas.Rows[i].Cells[6].Value.ToString();
                    int cat = Convert.ToInt32(DGVConsultas.Rows[i].Cells[4].Value.ToString());

                    //MessageBox.Show("id " + idConsulta1 + " salida " + tiempo + " cat " + cat);
                    Consulta_Sintomas dato = new Consulta_Sintomas();
                    dato.ID_Consulta = idConsulta1;
                    dato.Salida = tiempo;
                    dato.Categoria = cat;
                    Salida.Add(dato);
                }
                //foreach (Consulta_Sintomas item in Salida)
                //{
                //    MessageBox.Show("2id " + item.ID_Consulta + " salida " + item.Salida + " cat " + item.Categoria);
                //}
            }
        }

        private void Vencido()
        {
            int cont = 0;
            foreach (Consulta_Sintomas item in Salida)
            {
                if (item.Categoria > 0)
                {
                    DateTime horaout = DateTime.Parse(item.Salida);
                    DateTime horanow = DateTime.Now;
                    if (horanow.TimeOfDay >= horaout.TimeOfDay)
                    {
                        int ctiempo = consul.GetTime(item.Categoria - 1);
                        horanow = horanow.AddMinutes(ctiempo);
                        //MessageBox.Show("ID " + item.ID_Consulta + "\nCat " + (item.Categoria - 1) + "\nTiempo " + horanow.TimeOfDay.ToString());
                        consul.ConsultaPlus(item.ID_Consulta, item.Categoria - 1, horanow.TimeOfDay.ToString());
                        cont++;
                        //MessageBox.Show("Consulta Fuera de limite");
                    }
                }
            }
            if (cont > 0) Inicio();
        }

        private void CargarDatos()
        {
            if (DGVConsultas.Rows.Count > 0)
            {
                DataTable dt = (DataTable)DGVConsultas.DataSource;
                dt.Clear();
            }
            consul.DatosConsultas(DGVConsultas);            
        }

        private void DGVConsultas_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                idConsulta = Convert.ToInt32(DGVConsultas.Rows[DGVConsultas.CurrentRow.Index].Cells[0].Value.ToString());                
            }
            catch (Exception)
            {
            }
        }

        private void BtnAtender_Click(object sender, EventArgs e)
        {
            consul.FinConsulta(idConsulta);
            Inicio();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            consul.Consultas_Sintomas(LBConsultas_Sintomas, idConsulta);
        }
        //consul.Consultas_Sintomas(LBConsultas_Sintomas);
    }
}
