namespace ProyectoTrr
{
    partial class DatosUser
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
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.BtnEdit = new Bunifu.Framework.UI.BunifuTileButton();
            this.BtnAdd = new Bunifu.Framework.UI.BunifuTileButton();
            this.PnlContenedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Controls.Add(this.BtnEdit);
            this.PnlContenedor.Controls.Add(this.BtnAdd);
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 0);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(471, 445);
            this.PnlContenedor.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEdit.color = System.Drawing.Color.SteelBlue;
            this.BtnEdit.colorActive = System.Drawing.Color.Navy;
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = global::ProyectoTrr.Properties.Resources.icons8_editar_propiedad_64;
            this.BtnEdit.ImagePosition = 20;
            this.BtnEdit.ImageZoom = 50;
            this.BtnEdit.LabelPosition = 41;
            this.BtnEdit.LabelText = "Editar";
            this.BtnEdit.Location = new System.Drawing.Point(65, 158);
            this.BtnEdit.Margin = new System.Windows.Forms.Padding(6);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(128, 129);
            this.BtnEdit.TabIndex = 3;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Teal;
            this.BtnAdd.color = System.Drawing.Color.Teal;
            this.BtnAdd.colorActive = System.Drawing.Color.DarkSlateGray;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.BtnAdd.ForeColor = System.Drawing.Color.White;
            this.BtnAdd.Image = global::ProyectoTrr.Properties.Resources.icons8_agregar_usuario_grupo_mujer_hombre_64;
            this.BtnAdd.ImagePosition = 20;
            this.BtnAdd.ImageZoom = 50;
            this.BtnAdd.LabelPosition = 41;
            this.BtnAdd.LabelText = "Ingresar";
            this.BtnAdd.Location = new System.Drawing.Point(278, 158);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(6);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(128, 129);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DatosUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 445);
            this.Controls.Add(this.PnlContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DatosUser";
            this.Text = "DatosUser";
            this.PnlContenedor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlContenedor;
        private Bunifu.Framework.UI.BunifuTileButton BtnEdit;
        private Bunifu.Framework.UI.BunifuTileButton BtnAdd;
    }
}