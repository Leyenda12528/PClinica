using ProyectoTr;
using ProyectoTrr.Base;
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
    public partial class ModifyUser : Form
    {
        private Consultas consul = new Consultas();
        public ModifyUser()
        {
            InitializeComponent();
            consul.getUsers(CBIdUser);
        }
        private void mostrar(object frm)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.Clear();
            Form formu = frm as Form;
            formu.TopLevel = false;
            formu.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(formu);
            this.PnlContenedor.Tag = formu;
            formu.Show();
        }

        private void btnAddI_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CBIdUser.Text.Length > 0)
            {
                mostrar(new RegistroUsuario(CBIdUser.SelectedIndex));                
            }
            else MessageBox.Show("Seleccione un ID de Usuario");
        }

        private void CBIdUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
