namespace ProyectoTr
{
    partial class MenuP
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlBarra = new System.Windows.Forms.Panel();
            this.btnExpandir = new Bunifu.Framework.UI.BunifuImageButton();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnMinizar = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnInicioI = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnListarPacientes = new System.Windows.Forms.Button();
            this.btnListarPacientesI = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAtenderPacientes = new System.Windows.Forms.Button();
            this.btnAtenderPacientesI = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnConsultasI = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddUserI = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddPaciente = new System.Windows.Forms.Button();
            this.btnAddPacienteI = new Bunifu.Framework.UI.BunifuImageButton();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioI)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnListarPacientesI)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAtenderPacientesI)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultasI)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUserI)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPacienteI)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlBarra
            // 
            this.PnlBarra.BackColor = System.Drawing.Color.LightSeaGreen;
            this.PnlBarra.Controls.Add(this.btnExpandir);
            this.PnlBarra.Controls.Add(this.lblEspecialidad);
            this.PnlBarra.Controls.Add(this.lblNombre);
            this.PnlBarra.Controls.Add(this.btnMinizar);
            this.PnlBarra.Controls.Add(this.btnCerrar);
            this.PnlBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlBarra.Location = new System.Drawing.Point(0, 0);
            this.PnlBarra.Name = "PnlBarra";
            this.PnlBarra.Size = new System.Drawing.Size(703, 36);
            this.PnlBarra.TabIndex = 0;
            this.PnlBarra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PnlBarra_MouseMove);
            // 
            // btnExpandir
            // 
            this.btnExpandir.BackColor = System.Drawing.Color.Transparent;
            this.btnExpandir.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExpandir.Image = global::ProyectoTrr.Properties.Resources.icons8_menú_64;
            this.btnExpandir.ImageActive = null;
            this.btnExpandir.Location = new System.Drawing.Point(0, 0);
            this.btnExpandir.Name = "btnExpandir";
            this.btnExpandir.Size = new System.Drawing.Size(45, 36);
            this.btnExpandir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExpandir.TabIndex = 4;
            this.btnExpandir.TabStop = false;
            this.btnExpandir.Zoom = 10;
            this.btnExpandir.Click += new System.EventHandler(this.btnExpandir_Click);
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEspecialidad.Location = new System.Drawing.Point(298, 9);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(94, 19);
            this.lblEspecialidad.TabIndex = 3;
            this.lblEspecialidad.Text = "Especialidad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(84, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(67, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // btnMinizar
            // 
            this.btnMinizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinizar.Image = global::ProyectoTrr.Properties.Resources.Minimizar;
            this.btnMinizar.ImageActive = null;
            this.btnMinizar.Location = new System.Drawing.Point(613, 0);
            this.btnMinizar.Name = "btnMinizar";
            this.btnMinizar.Size = new System.Drawing.Size(45, 36);
            this.btnMinizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinizar.TabIndex = 1;
            this.btnMinizar.TabStop = false;
            this.btnMinizar.Zoom = 10;
            this.btnMinizar.Click += new System.EventHandler(this.btnMinizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.Image = global::ProyectoTrr.Properties.Resources.icons8_apagar_filled_50__1_;
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(658, 0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(45, 36);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlMenu.Controls.Add(this.panel6);
            this.pnlMenu.Controls.Add(this.panel5);
            this.pnlMenu.Controls.Add(this.panel4);
            this.pnlMenu.Controls.Add(this.panel3);
            this.pnlMenu.Controls.Add(this.panel2);
            this.pnlMenu.Controls.Add(this.panel1);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 36);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(197, 445);
            this.pnlMenu.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnInicio);
            this.panel6.Controls.Add(this.btnInicioI);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 401);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(197, 44);
            this.panel6.TabIndex = 12;
            // 
            // btnInicio
            // 
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnInicio.Location = new System.Drawing.Point(45, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(152, 44);
            this.btnInicio.TabIndex = 7;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = true;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnInicioI
            // 
            this.btnInicioI.BackColor = System.Drawing.Color.Transparent;
            this.btnInicioI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInicioI.Image = global::ProyectoTrr.Properties.Resources.icons8_casa_40;
            this.btnInicioI.ImageActive = null;
            this.btnInicioI.Location = new System.Drawing.Point(0, 0);
            this.btnInicioI.Name = "btnInicioI";
            this.btnInicioI.Size = new System.Drawing.Size(45, 44);
            this.btnInicioI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnInicioI.TabIndex = 5;
            this.btnInicioI.TabStop = false;
            this.btnInicioI.Zoom = 10;
            this.btnInicioI.Click += new System.EventHandler(this.btnInicioI_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnListarPacientes);
            this.panel5.Controls.Add(this.btnListarPacientesI);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 176);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(197, 44);
            this.panel5.TabIndex = 11;
            // 
            // btnListarPacientes
            // 
            this.btnListarPacientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListarPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListarPacientes.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnListarPacientes.Location = new System.Drawing.Point(45, 0);
            this.btnListarPacientes.Name = "btnListarPacientes";
            this.btnListarPacientes.Size = new System.Drawing.Size(152, 44);
            this.btnListarPacientes.TabIndex = 6;
            this.btnListarPacientes.Text = "Pacientes";
            this.btnListarPacientes.UseVisualStyleBackColor = true;
            this.btnListarPacientes.Click += new System.EventHandler(this.btnListarPacientes_Click);
            // 
            // btnListarPacientesI
            // 
            this.btnListarPacientesI.BackColor = System.Drawing.Color.Transparent;
            this.btnListarPacientesI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnListarPacientesI.Image = global::ProyectoTrr.Properties.Resources.icons8_revisión_de_salud_50;
            this.btnListarPacientesI.ImageActive = null;
            this.btnListarPacientesI.Location = new System.Drawing.Point(0, 0);
            this.btnListarPacientesI.Name = "btnListarPacientesI";
            this.btnListarPacientesI.Size = new System.Drawing.Size(45, 44);
            this.btnListarPacientesI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnListarPacientesI.TabIndex = 5;
            this.btnListarPacientesI.TabStop = false;
            this.btnListarPacientesI.Zoom = 10;
            this.btnListarPacientesI.Click += new System.EventHandler(this.btnListarPacientesI_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAtenderPacientes);
            this.panel4.Controls.Add(this.btnAtenderPacientesI);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 132);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(197, 44);
            this.panel4.TabIndex = 10;
            // 
            // btnAtenderPacientes
            // 
            this.btnAtenderPacientes.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtenderPacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtenderPacientes.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnAtenderPacientes.Location = new System.Drawing.Point(45, 0);
            this.btnAtenderPacientes.Name = "btnAtenderPacientes";
            this.btnAtenderPacientes.Size = new System.Drawing.Size(152, 44);
            this.btnAtenderPacientes.TabIndex = 6;
            this.btnAtenderPacientes.Text = "Atender Consultas";
            this.btnAtenderPacientes.UseVisualStyleBackColor = true;
            this.btnAtenderPacientes.Click += new System.EventHandler(this.btnAtenderPacientes_Click);
            // 
            // btnAtenderPacientesI
            // 
            this.btnAtenderPacientesI.BackColor = System.Drawing.Color.Transparent;
            this.btnAtenderPacientesI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtenderPacientesI.Image = global::ProyectoTrr.Properties.Resources.icons8_charla_varonil_40;
            this.btnAtenderPacientesI.ImageActive = null;
            this.btnAtenderPacientesI.Location = new System.Drawing.Point(0, 0);
            this.btnAtenderPacientesI.Name = "btnAtenderPacientesI";
            this.btnAtenderPacientesI.Size = new System.Drawing.Size(45, 44);
            this.btnAtenderPacientesI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAtenderPacientesI.TabIndex = 5;
            this.btnAtenderPacientesI.TabStop = false;
            this.btnAtenderPacientesI.Zoom = 10;
            this.btnAtenderPacientesI.Click += new System.EventHandler(this.btnAtenderPacientesI_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConsultas);
            this.panel3.Controls.Add(this.btnConsultasI);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 44);
            this.panel3.TabIndex = 9;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnConsultas.Location = new System.Drawing.Point(45, 0);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(152, 44);
            this.btnConsultas.TabIndex = 6;
            this.btnConsultas.Text = "Registrar Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnConsultasI
            // 
            this.btnConsultasI.BackColor = System.Drawing.Color.Transparent;
            this.btnConsultasI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnConsultasI.Image = global::ProyectoTrr.Properties.Resources.icons8_hospital_48;
            this.btnConsultasI.ImageActive = null;
            this.btnConsultasI.Location = new System.Drawing.Point(0, 0);
            this.btnConsultasI.Name = "btnConsultasI";
            this.btnConsultasI.Size = new System.Drawing.Size(45, 44);
            this.btnConsultasI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConsultasI.TabIndex = 5;
            this.btnConsultasI.TabStop = false;
            this.btnConsultasI.Zoom = 10;
            this.btnConsultasI.Click += new System.EventHandler(this.btnConsultasI_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddUser);
            this.panel2.Controls.Add(this.btnAddUserI);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 44);
            this.panel2.TabIndex = 8;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft YaHei", 10F);
            this.btnAddUser.Location = new System.Drawing.Point(45, 0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(152, 44);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Mant. Usuarios";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddUserI
            // 
            this.btnAddUserI.BackColor = System.Drawing.Color.Transparent;
            this.btnAddUserI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddUserI.Image = global::ProyectoTrr.Properties.Resources.icons8_gerente_64__1_;
            this.btnAddUserI.ImageActive = null;
            this.btnAddUserI.Location = new System.Drawing.Point(0, 0);
            this.btnAddUserI.Name = "btnAddUserI";
            this.btnAddUserI.Size = new System.Drawing.Size(45, 44);
            this.btnAddUserI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddUserI.TabIndex = 5;
            this.btnAddUserI.TabStop = false;
            this.btnAddUserI.Zoom = 10;
            this.btnAddUserI.Click += new System.EventHandler(this.btnAddUserI_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddPaciente);
            this.panel1.Controls.Add(this.btnAddPacienteI);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(197, 44);
            this.panel1.TabIndex = 7;
            // 
            // btnAddPaciente
            // 
            this.btnAddPaciente.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPaciente.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPaciente.Location = new System.Drawing.Point(45, 0);
            this.btnAddPaciente.Name = "btnAddPaciente";
            this.btnAddPaciente.Size = new System.Drawing.Size(152, 44);
            this.btnAddPaciente.TabIndex = 6;
            this.btnAddPaciente.Text = "Agregar Paciente";
            this.btnAddPaciente.UseVisualStyleBackColor = true;
            this.btnAddPaciente.Click += new System.EventHandler(this.btnAddPaciente_Click);
            // 
            // btnAddPacienteI
            // 
            this.btnAddPacienteI.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPacienteI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddPacienteI.Image = global::ProyectoTrr.Properties.Resources.icons8_reparto_40;
            this.btnAddPacienteI.ImageActive = null;
            this.btnAddPacienteI.Location = new System.Drawing.Point(0, 0);
            this.btnAddPacienteI.Name = "btnAddPacienteI";
            this.btnAddPacienteI.Size = new System.Drawing.Size(45, 44);
            this.btnAddPacienteI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddPacienteI.TabIndex = 5;
            this.btnAddPacienteI.TabStop = false;
            this.btnAddPacienteI.Zoom = 10;
            this.btnAddPacienteI.Click += new System.EventHandler(this.btnAddPacienteI_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.BackgroundImage = global::ProyectoTrr.Properties.Resources.Logo;
            this.PnlContenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(197, 36);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(506, 445);
            this.PnlContenedor.TabIndex = 2;
            // 
            // MenuP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 481);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.PnlBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.PnlBarra.ResumeLayout(false);
            this.PnlBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExpandir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnInicioI)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnListarPacientesI)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAtenderPacientesI)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnConsultasI)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddUserI)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddPacienteI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBarra;
        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuImageButton btnMinizar;
        private Bunifu.Framework.UI.BunifuImageButton btnExpandir;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton btnAddPacienteI;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnInicio;
        private Bunifu.Framework.UI.BunifuImageButton btnInicioI;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnListarPacientes;
        private Bunifu.Framework.UI.BunifuImageButton btnListarPacientesI;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAtenderPacientes;
        private Bunifu.Framework.UI.BunifuImageButton btnAtenderPacientesI;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConsultas;
        private Bunifu.Framework.UI.BunifuImageButton btnConsultasI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAddUser;
        private Bunifu.Framework.UI.BunifuImageButton btnAddUserI;
        private System.Windows.Forms.Button btnAddPaciente;
        public System.Windows.Forms.Panel PnlContenedor;
    }
}

