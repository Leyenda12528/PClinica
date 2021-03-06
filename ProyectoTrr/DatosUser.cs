﻿using ProyectoTr;
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
    public partial class DatosUser : Form
    {
        public DatosUser()
        {
            InitializeComponent();
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

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            mostrar(new RegistroUsuario(-1));
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            mostrar(new ModifyUser());
        }
    }
}
