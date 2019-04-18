namespace ProyectoTrr
{
    partial class AddPaciente
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
            this.btnDetalle = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnInmediato = new Bunifu.Framework.UI.BunifuTileButton();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDetalle
            // 
            this.btnDetalle.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDetalle.color = System.Drawing.Color.MediumAquamarine;
            this.btnDetalle.colorActive = System.Drawing.Color.Teal;
            this.btnDetalle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnDetalle.ForeColor = System.Drawing.Color.White;
            this.btnDetalle.Image = global::ProyectoTrr.Properties.Resources.icons8_libro_de_salud_48;
            this.btnDetalle.ImagePosition = 20;
            this.btnDetalle.ImageZoom = 50;
            this.btnDetalle.LabelPosition = 41;
            this.btnDetalle.LabelText = "A Detalle";
            this.btnDetalle.Location = new System.Drawing.Point(300, 138);
            this.btnDetalle.Margin = new System.Windows.Forms.Padding(6);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(128, 129);
            this.btnDetalle.TabIndex = 2;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // btnInmediato
            // 
            this.btnInmediato.BackColor = System.Drawing.Color.LightCoral;
            this.btnInmediato.color = System.Drawing.Color.LightCoral;
            this.btnInmediato.colorActive = System.Drawing.Color.Crimson;
            this.btnInmediato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInmediato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.btnInmediato.ForeColor = System.Drawing.Color.White;
            this.btnInmediato.Image = global::ProyectoTrr.Properties.Resources.icons8_ambulancia_64;
            this.btnInmediato.ImagePosition = 20;
            this.btnInmediato.ImageZoom = 50;
            this.btnInmediato.LabelPosition = 41;
            this.btnInmediato.LabelText = "Inmediata";
            this.btnInmediato.Location = new System.Drawing.Point(87, 138);
            this.btnInmediato.Margin = new System.Windows.Forms.Padding(6);
            this.btnInmediato.Name = "btnInmediato";
            this.btnInmediato.Size = new System.Drawing.Size(128, 129);
            this.btnInmediato.TabIndex = 1;
            this.btnInmediato.Click += new System.EventHandler(this.btnInmediato_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.btnInmediato);
            this.PnlContenedor.Controls.Add(this.btnDetalle);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(471, 445);
            this.PnlContenedor.TabIndex = 3;
            // 
            // AddPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 445);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPaciente";
            this.Text = "AddPaciente";
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuTileButton btnInmediato;
        private Bunifu.Framework.UI.BunifuTileButton btnDetalle;
        private System.Windows.Forms.Panel PnlContenedor;
    }
}