using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoTrr.Base;
using ProyectoTrr.Datos;

namespace ProyectoTr
{
    public partial class Login : Form
    {
        private Help1 h = new Help1();
        private Consultas consulta = new Consultas();
        private Usuario usuario = new Usuario();
        public Login()
        {
            InitializeComponent();
            /*DateTime horact = DateTime.Now;
            DateTime horatot = horact.AddMinutes(40);
            String txthora = horatot.TimeOfDay.ToString();
            MessageBox.Show("0- "+txthora);
            DateTime horaing = DateTime.Parse(txthora);
            MessageBox.Show("1- "+horaing.TimeOfDay.ToString());
            horatot = DateTime.Now;
            horatot = horatot.AddMinutes(40);
            if (horatot.TimeOfDay >= horaing.TimeOfDay)
            {
                MessageBox.Show("menor "+horaing.TimeOfDay.ToString()+"\n mayo "+horatot.TimeOfDay.ToString());
            }
            else if (horatot.TimeOfDay == horaing.TimeOfDay)
            {
                MessageBox.Show("iguales");
            }
            else MessageBox.Show("no son iguales");*/
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {            
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtPass.Text.Length > 0 && txtUser.Text.Length > 0)
            {
                if (consulta.exist(txtUser.Text, txtPass.Text, usuario))
                {
                    consulta.getDatos(usuario);
                    this.Hide();
                    MenuP menu = new MenuP(usuario);
                    menu.Show();
                }
                else { MessageBox.Show("Usuario/Contraseña incorrectos"); txtPass.Clear(); }
            }
            else MessageBox.Show("Campos Vacios");
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (txtUser.Text.Length > 0) lblUser.Hide();
            else lblUser.Show();
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text.Length > 0) lblPass.Hide();
            else lblPass.Show();
        }

        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (h.valorRestringuido(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Space))
                e.Handled = true;
            else
            {
                e.Handled = false;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    btnLogin_Click(null, null);
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (h.valorRestringuido(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Space))
                e.Handled = true;
            else
            {
                e.Handled = false;
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                    btnLogin_Click(null, null);
            }
        }
    }
}
