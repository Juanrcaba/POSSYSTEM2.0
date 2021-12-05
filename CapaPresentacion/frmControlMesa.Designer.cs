
namespace CapaPresentacion
{
    partial class frmControlMesa
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
            this.lblMesa = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.lblMesa.ForeColor = System.Drawing.Color.White;
            this.lblMesa.Location = new System.Drawing.Point(55, 26);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(113, 25);
            this.lblMesa.TabIndex = 0;
            this.lblMesa.Text = "Mesa # 10";
            this.lblMesa.Click += new System.EventHandler(this.frmControlMesa_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.Yellow;
            this.lblTotal.Location = new System.Drawing.Point(70, 63);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(82, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Mesa # 10";
            this.lblTotal.Click += new System.EventHandler(this.frmControlMesa_Click);
            // 
            // frmControlMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(180)))));
            this.ClientSize = new System.Drawing.Size(221, 111);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblMesa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmControlMesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmControlMesa";
            this.Load += new System.EventHandler(this.frmControlMesa_Load);
            this.Click += new System.EventHandler(this.frmControlMesa_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        public System.Windows.Forms.Label lblMesa;
        public System.Windows.Forms.Label lblTotal;
    }
}