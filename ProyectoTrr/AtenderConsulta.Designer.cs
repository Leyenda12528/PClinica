namespace ProyectoTrr
{
    partial class AtenderConsulta
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
            this.DGVConsultas = new System.Windows.Forms.DataGridView();
            this.LBConsultas_Sintomas = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAtender = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVConsultas
            // 
            this.DGVConsultas.AllowUserToAddRows = false;
            this.DGVConsultas.AllowUserToDeleteRows = false;
            this.DGVConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsultas.Location = new System.Drawing.Point(12, 29);
            this.DGVConsultas.Name = "DGVConsultas";
            this.DGVConsultas.ReadOnly = true;
            this.DGVConsultas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConsultas.Size = new System.Drawing.Size(457, 151);
            this.DGVConsultas.TabIndex = 0;
            this.DGVConsultas.SelectionChanged += new System.EventHandler(this.DGVConsultas_SelectionChanged);
            // 
            // LBConsultas_Sintomas
            // 
            this.LBConsultas_Sintomas.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.LBConsultas_Sintomas.FormattingEnabled = true;
            this.LBConsultas_Sintomas.ItemHeight = 16;
            this.LBConsultas_Sintomas.Location = new System.Drawing.Point(12, 213);
            this.LBConsultas_Sintomas.Name = "LBConsultas_Sintomas";
            this.LBConsultas_Sintomas.Size = new System.Drawing.Size(319, 132);
            this.LBConsultas_Sintomas.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Consultas";
            // 
            // BtnAtender
            // 
            this.BtnAtender.BackColor = System.Drawing.Color.IndianRed;
            this.BtnAtender.color = System.Drawing.Color.IndianRed;
            this.BtnAtender.colorActive = System.Drawing.Color.OrangeRed;
            this.BtnAtender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAtender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BtnAtender.ForeColor = System.Drawing.Color.White;
            this.BtnAtender.Image = global::ProyectoTrr.Properties.Resources.icons8_sala_de_espera_48;
            this.BtnAtender.ImagePosition = 20;
            this.BtnAtender.ImageZoom = 50;
            this.BtnAtender.LabelPosition = 41;
            this.BtnAtender.LabelText = "Atender ";
            this.BtnAtender.Location = new System.Drawing.Point(341, 216);
            this.BtnAtender.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAtender.Name = "BtnAtender";
            this.BtnAtender.Size = new System.Drawing.Size(128, 129);
            this.BtnAtender.TabIndex = 49;
            this.BtnAtender.Click += new System.EventHandler(this.BtnAtender_Click);
            // 
            // BtnShow
            // 
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnShow.Location = new System.Drawing.Point(15, 186);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(144, 23);
            this.BtnShow.TabIndex = 50;
            this.BtnShow.Text = "Mostrar Sintomas";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // AtenderConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 415);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnAtender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBConsultas_Sintomas);
            this.Controls.Add(this.DGVConsultas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AtenderConsulta";
            this.Text = "AtenderConsulta";
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVConsultas;
        private System.Windows.Forms.ListBox LBConsultas_Sintomas;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuTileButton BtnAtender;
        private System.Windows.Forms.Button BtnShow;
    }
}