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

namespace ProyectoTr
{
    public partial class RegistroConsulta : Form
    {
        private Consultas consul = new Consultas();
        private Consulta consulC = new Consulta();
        private List<Sintomas> listaSin = new List<Sintomas>();
        private List<int> listaID = new List<int>();
        private int cat = 0, punt = 0;
        
        public RegistroConsulta()
        {
            InitializeComponent();
            Load(0);            
        }        

        private void Load(int i)
        {
            int d = consul.GetIdNewConsult();
            txtIDConsul.Text = d + "";
            consul.GetPac(CBIdPac);
            consul.GetDocs(CBIdDoc);            
            txtPuntaje.Text = "0";
            if (i == 0)
            {
                consul.GetSintomas(ListSintomas, listaSin);
                ListSintomas.CheckOnClick = true;
            }
        }

        //* BOTONES CON IMAGENES
        private void btnAddI_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }
        //*

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CBIdPac.Text.Length > 0 && CBIdDoc.Text.Length > 0 && ListSintomas.CheckedItems.Count > 0)
            {
                pasarDatos();
                consul.AddConsulta(consulC);                
                Limpiar();
            }
            else MessageBox.Show("No ha ingresado los datos correctamente");            
        }

        private void Limpiar()
        {
            CBIdPac.Items.Clear();
            CBIdDoc.Items.Clear();

            txtCategoria.Clear();
            txtPuntaje.Text = "0";
            Load(1);
        }

        private void pasarDatos()
        {
            consulC.Id_consulta = Convert.ToInt32(txtIDConsul.Text);
            consulC.Id_pac = Convert.ToInt32(CBIdPac.SelectedIndex);
            consulC.Id_doc = Convert.ToInt32(CBIdDoc.SelectedIndex);
            consulC.Puntaje = punt;
            consulC.Categoria = cat;

            int mins = consul.GetTime(cat);
            DateTime horasal = DateTime.Now;
            horasal = horasal.AddMinutes(mins);

            consulC.Salida = horasal.TimeOfDay.ToString();
            consulC.ListaSintomas = listaID;
            consulC.Id_estado = 0;
        }

        private void ListSintomas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCategoria.Clear();
            txtPuntaje.Text = "0";
            listaID.Clear();          
            int puntaje = 0;
            int d = ListSintomas.CheckedItems.Count;
            for (int i = 0; i < d; i++)
            {
                foreach (Sintomas item in listaSin)
                {
                    if (item.Sintoma == ListSintomas.CheckedItems[i].ToString())
                    {
                        listaID.Add(item.Id_Sintoma);                        
                        if (item.Id_Sintoma != 7 && item.Id_Sintoma != 18 && item.Id_Sintoma != 19)
                        {
                            puntaje = puntaje + item.Puntaje;
                            punt = puntaje;
                            updatePuntaje(puntaje);
                        }
                        else {
                            txtCategoria.Text = "Critico";
                            txtPuntaje.Text = "200";
                            cat = 0;
                        }
                    }
                }                
            }
            
        }  

        private void updatePuntaje(int puntaje)
        {
            if (puntaje > 0 && puntaje < 35)
            {
                txtCategoria.Text = "No Urgente";
                txtPuntaje.Text = puntaje.ToString();
                cat = 4;
            }
            else if (puntaje > 34 && puntaje < 100)
            {
                txtCategoria.Text = "Estandar";
                txtPuntaje.Text = puntaje.ToString();
                cat = 3;
            }
            else if (puntaje > 99 && puntaje < 151)
            {
                txtCategoria.Text = "Urgencia";
                txtPuntaje.Text = puntaje.ToString();
                cat = 2;
            }
            else if (puntaje > 150 && puntaje < 199)
            {
                txtCategoria.Text = "Emergencia";
                txtPuntaje.Text = puntaje.ToString();
                cat = 1;
            }
            else {
                txtCategoria.Text = "Critico";
                txtPuntaje.Text = puntaje.ToString();
                cat = 0;
            }
        }
    }
}
