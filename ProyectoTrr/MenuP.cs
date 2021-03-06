﻿using ProyectoTrr;
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
    public partial class MenuP : Form
    {
        private int var = 0;
        public MenuP()
        {
            InitializeComponent();
        }

        public MenuP(ProyectoTrr.Datos.Usuario usuario)
        {
            InitializeComponent();
            lblNombre.Text = usuario.Nombre;
            lblEspecialidad.Text = usuario.Especialidad;
            if (usuario.ID_especialidad != 3)
                panel2.Hide();
        }

        private void mostrar(object frm)
        {
            if (this.PnlContenedor.Controls.Count > 0)
                this.PnlContenedor.Controls.RemoveAt(0);
            Form formu = frm as Form;
            formu.TopLevel = false;
            formu.Dock = DockStyle.Fill;
            this.PnlContenedor.Controls.Add(formu);
            this.PnlContenedor.Tag = formu;
            formu.Show();
        }

        private void btnMinizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Menu_FormClosing(null, null);
            //Application.Exit();
        }
        ///*  BOTONES CON IMAGENES
        private void btnAddPacienteI_Click(object sender, EventArgs e)
        {
            btnAddPaciente_Click(null, null);
        }

        private void btnAddUserI_Click(object sender, EventArgs e)
        {
            btnAddUser_Click(null, null);
        }

        private void btnConsultasI_Click(object sender, EventArgs e)
        {
            btnConsultas_Click(null, null);
        }

        private void btnAtenderPacientesI_Click(object sender, EventArgs e)
        {
            btnAtenderPacientes_Click(null, null);
        }

        private void btnListarPacientesI_Click(object sender, EventArgs e)
        {
            btnListarPacientes_Click(null, null);
        }

        private void btnInicioI_Click(object sender, EventArgs e)
        {
            btnInicio_Click(null, null);
        }
        ///*


        private void btnAddPaciente_Click(object sender, EventArgs e)
        {
            mostrar(new AddPaciente());
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            mostrar(new DatosUser());
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            mostrar(new RegistroConsulta());
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            this.PnlContenedor.Controls.Clear();
        }

        private void btnExpandir_Click(object sender, EventArgs e)
        {
            if (var == 0)
            {
                pnlMenu.Size = new Size(45,pnlMenu.Size.Height);
                var = 1;
            }
            else
            {
                pnlMenu.Size = new Size(197, pnlMenu.Size.Height);
                var = 0;
            }
        }

        private void btnAtenderPacientes_Click(object sender, EventArgs e)
        {
            mostrar(new AtenderConsulta());
        }

        private void btnListarPacientes_Click(object sender, EventArgs e)
        {
            mostrar(new ModificarPaciente());
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {            
            Login call = new Login();
            call.Show();
            this.Dispose();
        }
        private int posX = 0, posY = 0;
        private void PnlBarra_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button!=MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }
    }
}
