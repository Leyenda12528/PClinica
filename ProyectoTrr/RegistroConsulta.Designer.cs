namespace ProyectoTr
{
    partial class RegistroConsulta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAddI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIDConsul = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPuntaje = new System.Windows.Forms.TextBox();
            this.CBIdPac = new System.Windows.Forms.ComboBox();
            this.CBIdDoc = new System.Windows.Forms.ComboBox();
            this.ListSintomas = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddI)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(118, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 54;
            this.label9.Text = "Registro Consultas";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSalmon;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 39);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAddI);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(263, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 39);
            this.panel2.TabIndex = 3;
            // 
            // btnAddI
            // 
            this.btnAddI.BackColor = System.Drawing.Color.Transparent;
            this.btnAddI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddI.Image = global::ProyectoTrr.Properties.Resources.icons8_más_40;
            this.btnAddI.ImageActive = null;
            this.btnAddI.Location = new System.Drawing.Point(0, 0);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(45, 39);
            this.btnAddI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAddI.TabIndex = 6;
            this.btnAddI.TabStop = false;
            this.btnAddI.Zoom = 10;
            this.btnAddI.Click += new System.EventHandler(this.btnAddI_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(44, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label7.Location = new System.Drawing.Point(285, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Puntaje";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label8.Location = new System.Drawing.Point(285, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 46;
            this.label8.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label4.Location = new System.Drawing.Point(228, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Doctor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label2.Location = new System.Drawing.Point(24, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "Paciente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "ID Consulta";
            // 
            // txtIDConsul
            // 
            this.txtIDConsul.Enabled = false;
            this.txtIDConsul.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.txtIDConsul.Location = new System.Drawing.Point(138, 37);
            this.txtIDConsul.Name = "txtIDConsul";
            this.txtIDConsul.Size = new System.Drawing.Size(77, 25);
            this.txtIDConsul.TabIndex = 37;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Enabled = false;
            this.txtCategoria.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.txtCategoria.Location = new System.Drawing.Point(288, 241);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(113, 25);
            this.txtCategoria.TabIndex = 55;
            // 
            // txtPuntaje
            // 
            this.txtPuntaje.Enabled = false;
            this.txtPuntaje.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold);
            this.txtPuntaje.Location = new System.Drawing.Point(288, 306);
            this.txtPuntaje.Name = "txtPuntaje";
            this.txtPuntaje.Size = new System.Drawing.Size(71, 25);
            this.txtPuntaje.TabIndex = 56;
            // 
            // CBIdPac
            // 
            this.CBIdPac.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.CBIdPac.FormattingEnabled = true;
            this.CBIdPac.Location = new System.Drawing.Point(27, 88);
            this.CBIdPac.Name = "CBIdPac";
            this.CBIdPac.Size = new System.Drawing.Size(88, 24);
            this.CBIdPac.TabIndex = 57;
            // 
            // CBIdDoc
            // 
            this.CBIdDoc.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.CBIdDoc.FormattingEnabled = true;
            this.CBIdDoc.Location = new System.Drawing.Point(231, 88);
            this.CBIdDoc.Name = "CBIdDoc";
            this.CBIdDoc.Size = new System.Drawing.Size(88, 24);
            this.CBIdDoc.TabIndex = 58;
            // 
            // ListSintomas
            // 
            this.ListSintomas.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.ListSintomas.FormattingEnabled = true;
            this.ListSintomas.Location = new System.Drawing.Point(27, 173);
            this.ListSintomas.Name = "ListSintomas";
            this.ListSintomas.Size = new System.Drawing.Size(240, 184);
            this.ListSintomas.TabIndex = 59;
            this.ListSintomas.SelectedIndexChanged += new System.EventHandler(this.ListSintomas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label5.Location = new System.Drawing.Point(24, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 60;
            this.label5.Text = "Sintomas";
            // 
            // RegistroConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 422);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ListSintomas);
            this.Controls.Add(this.CBIdDoc);
            this.Controls.Add(this.CBIdPac);
            this.Controls.Add(this.txtPuntaje);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIDConsul);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroConsulta";
            this.Text = "RegistroPaciente";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIDConsul;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPuntaje;
        private System.Windows.Forms.ComboBox CBIdPac;
        private System.Windows.Forms.ComboBox CBIdDoc;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuImageButton btnAddI;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox ListSintomas;
        private System.Windows.Forms.Label label5;
    }
}