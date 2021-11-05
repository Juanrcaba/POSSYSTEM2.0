
namespace CapaPresentacion
{
    partial class frmAlerta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAlerta));
            this.lblmensaje = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFranja = new System.Windows.Forms.Panel();
            this.lstImage = new System.Windows.Forms.ImageList(this.components);
            this.lbltitulo = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblmensaje
            // 
            this.lblmensaje.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(84, 36);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(142, 15);
            this.lblmensaje.TabIndex = 7;
            this.lblmensaje.Text = "Datos fueron guardados.";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlFranja
            // 
            this.pnlFranja.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlFranja.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlFranja.Location = new System.Drawing.Point(0, 0);
            this.pnlFranja.Name = "pnlFranja";
            this.pnlFranja.Size = new System.Drawing.Size(15, 77);
            this.pnlFranja.TabIndex = 4;
            // 
            // lstImage
            // 
            this.lstImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImage.ImageStream")));
            this.lstImage.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImage.Images.SetKeyName(0, "successful.png");
            this.lstImage.Images.SetKeyName(1, "Error.png");
            this.lstImage.Images.SetKeyName(2, "Information.png");
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(147, 11);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(62, 19);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Exitoso";
            // 
            // icon
            // 
            this.icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(27, 18);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(46, 44);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 5;
            this.icon.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(285, 5);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(19, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this;
            this.DragForm.Vertical = true;
            // 
            // frmAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 77);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.pnlFranja);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.icon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlerta";
            this.Load += new System.EventHandler(this.frmAlerta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmensaje;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlFranja;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList lstImage;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
    }
}