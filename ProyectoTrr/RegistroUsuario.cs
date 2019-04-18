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
    public partial class RegistroUsuario : Form
    {
        private Consultas consul = new Consultas();
        private Usuario user = new Usuario();
        private Help1 h = new Help1();

        public RegistroUsuario()
        {
            InitializeComponent();
            Load();
        }

        private void Load()
        {
            CBEspel.Items.Clear();
            consul.getEspecialidad(CBEspel);
            consul.getNewIdUser(user);
        }

        //*
        private void btnAddI_Click(object sender, EventArgs e)
        {
            btnAdd_Click(null, null);
        }
        //*
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Length > 0 && txtApel.Text.Length > 0 && txtEdad.Text.Length > 0
                && txtTel.Text.Length > 0  && CBEspel.Text.Length > 0
                && txtUser.Text.Length > 0 && txtPass.Text.Length > 0
                && h.TelFormat(txtTel.Text))
            {
                if (consul.UserExits(txtUser.Text.Trim()) == false)
                {
                    pasarDatos();
                    consul.AddUser(user);
                    Limpiar();
                }
                else MessageBox.Show("ERROR\n\nYa existe ese Usuario en la Base de datos");
            }
            else MessageBox.Show("ERROR\n\nLlene todos los campos requeridos correctamente");
        }

        private void Limpiar()
        {
            txtName.Clear();
            txtApel.Clear();
            txtEdad.Clear();
            txtTel.Clear();
            txtUser.Clear();
            txtPass.Clear();
            Load();
            CBEspel.Text = "";
        }

        private void pasarDatos()
        {
            user.Nombre = txtName.Text.Trim();
            user.Apellido = txtApel.Text.Trim();
            user.Edad = Convert.ToInt32(txtEdad.Text.Trim());
            user.Telefono = txtTel.Text.Trim();
            user.ID_especialidad = CBEspel.SelectedIndex;
            user.User = txtUser.Text.Trim();
            user.Pass = txtPass.Text.Trim();
            user.ID_estdo = 0;
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsControl(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

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
    }
}
