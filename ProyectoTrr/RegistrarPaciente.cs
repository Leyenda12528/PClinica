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
    public partial class RegistrarPaciente : Form
    {
        private Help1 h = new Help1();
        private Consultas consul1 = new Consultas();
        private Paciente pacu = new Paciente();
        private int Variable;
        public RegistrarPaciente()
        {
            InitializeComponent();
        }
        public RegistrarPaciente(int v)
        {
            InitializeComponent();
            this.Variable = v;
            if (v == -1) pnlID.Hide();
            else
            {
                pnlID.Show();
                btnAdd.Text = "Actualizar";
                txtID.Text = v + "";
                pacu.ID_pac = v;
                consul1.getDatosPac(pacu);
                MostrandoDatos();
            }
        }

        private void MostrandoDatos()
        {
            txtName.Text = pacu.Nombre;
            txtApel.Text = pacu.Apellido;
            txtEdad.Text = pacu.Edad.ToString();
            txtTel.Text = pacu.Tel;
            txtSangre.Text = pacu.Sangre;
            txtDir.Text = pacu.Direccion;
            txtNameContac.Text = pacu.NombreC;
            txtTelContac.Text = pacu.TelC;
            CBEstado.SelectedIndex = pacu.ID_estado;
        }

        //* BOTONES CON IMAGENES
        private void btnAddI_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }
        //*

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Novacio() && h.TelFormat(txtTel.Text) && h.TelFormat(txtTelContac.Text))
            {
                if (Variable == -1) //Ingresar
                {
                    Consultas consul = new Consultas();
                    Paciente pac = new Paciente();
                    pac.ID_pac = consul.LastIDPac();
                    pac.Nombre = txtName.Text;
                    pac.Apellido = txtApel.Text;
                    pac.Edad = Convert.ToInt32(txtEdad.Text);
                    pac.Tel = txtTel.Text;
                    pac.Direccion = txtDir.Text;
                    pac.Sangre = txtSangre.Text;
                    pac.NombreC = txtNameContac.Text;
                    pac.TelC = txtTelContac.Text;
                    consul.AddPcDetalle(pac);
                    Limpiar();
                }
                else ///Actualizando
                {
                    if (CBEstado.SelectedIndex == 0 || CBEstado.SelectedIndex == 1)
                    {
                        pacu.Nombre = txtName.Text;
                        pacu.Apellido = txtApel.Text;
                        pacu.Edad = Convert.ToInt32(txtEdad.Text);
                        pacu.Tel = txtTel.Text;
                        pacu.Direccion= txtDir.Text;
                        pacu.Sangre = txtSangre.Text;
                        pacu.NombreC = txtNameContac.Text;
                        pacu.TelC = txtTelContac.Text;
                        consul1.ModifyPaciente(pacu);
                    }
                    else MessageBox.Show("ERROR\n\n Escoga el estado del Paciente");
                }
            }
            else MessageBox.Show("ERROR\n\nLlene todos los campos requeridos correctamente");
        }

        private void Limpiar()
        {
            txtName.Clear();
            txtApel.Clear();
            txtEdad.Clear();
            txtTel.Clear();
            txtDir.Clear();
            txtSangre.Clear();
            txtNameContac.Clear();
            txtTelContac.Clear();
        }

        private bool Novacio()
        {
            if (txtName.Text.Length > 0 && txtApel.Text.Length > 0 && txtEdad.Text.Length > 0 
                && txtTel.Text.Length == 9 && txtDir.Text.Length > 0 && txtSangre.Text.Length > 0 
                && txtNameContac.Text.Length > 0 && txtTelContac.Text.Length == 9)
                return true;
            else return false;
            throw new NotImplementedException();
        }


        ///* VALIDACIONES DE TEXTO /  NUMEROS
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))            
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtApel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void txtNameContac_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsSeparator(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CBEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            pacu.ID_estado = CBEstado.SelectedIndex;
        }
    }
}
