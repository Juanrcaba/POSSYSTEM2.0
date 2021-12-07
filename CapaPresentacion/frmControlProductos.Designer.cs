
namespace CapaPresentacion
{
    partial class frmControlProductos
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
            this.components = new System.ComponentModel.Container();
            this.lblProducto = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SuspendLayout();
            // 
            // lblProducto
            // 
            this.lblProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold);
            this.lblProducto.ForeColor = System.Drawing.Color.White;
            this.lblProducto.Location = new System.Drawing.Point(29, 36);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(88, 22);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Producto";
            this.lblProducto.Click += new System.EventHandler(this.frmControlProductos_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // frmControlProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(194, 103);
            this.Controls.Add(this.lblProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControlProductos";
            this.Text = "frmControlProductos";
            this.Load += new System.EventHandler(this.frmControlProductos_Load);
            this.Click += new System.EventHandler(this.frmControlProductos_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lblProducto;
    }
}