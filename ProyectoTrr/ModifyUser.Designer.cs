namespace ProyectoTrr
{
    partial class ModifyUser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CBIdUser = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddI = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PnlContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddI)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CBIdUser);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 51);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Usuario";
            // 
            // CBIdUser
            // 
            this.CBIdUser.FormattingEnabled = true;
            this.CBIdUser.Location = new System.Drawing.Point(132, 14);
            this.CBIdUser.Name = "CBIdUser";
            this.CBIdUser.Size = new System.Drawing.Size(139, 21);
            this.CBIdUser.TabIndex = 5;
            this.CBIdUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CBIdUser_KeyPress);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAddI);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(307, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 51);
            this.panel3.TabIndex = 4;
            // 
            // btnAddI
            // 
            this.btnAddI.BackColor = System.Drawing.Color.Transparent;
            this.btnAddI.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddI.Image = global::ProyectoTrr.Properties.Resources.icons8_información_50;
            this.btnAddI.ImageActive = null;
            this.btnAddI.Location = new System.Drawing.Point(0, 0);
            this.btnAddI.Name = "btnAddI";
            this.btnAddI.Size = new System.Drawing.Size(45, 51);
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
            this.btnAdd.Size = new System.Drawing.Size(106, 51);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Mostrar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PnlContenedor
            // 
            this.PnlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlContenedor.Location = new System.Drawing.Point(0, 51);
            this.PnlContenedor.Name = "PnlContenedor";
            this.PnlContenedor.Size = new System.Drawing.Size(457, 300);
            this.PnlContenedor.TabIndex = 1;
            // 
            // ModifyUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(457, 351);
            this.Controls.Add(this.PnlContenedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ModifyUser";
            this.Text = "ModifyUser";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PnlContenedor;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuImageButton btnAddI;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBIdUser;
    }
}