
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlFranja = new System.Windows.Forms.Panel();
            this.btnCerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.lstImage = new System.Windows.Forms.ImageList(this.components);
            this.DragForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnAceptar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlFranja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlFranja
            // 
            this.pnlFranja.BackColor = System.Drawing.Color.SeaGreen;
            this.pnlFranja.Controls.Add(this.btnCerrar);
            this.pnlFranja.Controls.Add(this.lbltitulo);
            this.pnlFranja.Controls.Add(this.icon);
            this.pnlFranja.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFranja.Location = new System.Drawing.Point(0, 0);
            this.pnlFranja.Name = "pnlFranja";
            this.pnlFranja.Size = new System.Drawing.Size(264, 104);
            this.pnlFranja.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.ImageActive = null;
            this.btnCerrar.Location = new System.Drawing.Point(233, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(19, 18);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Zoom = 10;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // lbltitulo
            // 
            this.lbltitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.White;
            this.lbltitulo.Location = new System.Drawing.Point(99, 48);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(83, 25);
            this.lbltitulo.TabIndex = 6;
            this.lbltitulo.Text = "Exitoso";
            // 
            // icon
            // 
            this.icon.Image = ((System.Drawing.Image)(resources.GetObject("icon.Image")));
            this.icon.Location = new System.Drawing.Point(12, 37);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(46, 44);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.icon.TabIndex = 5;
            this.icon.TabStop = false;
            // 
            // lstImage
            // 
            this.lstImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImage.ImageStream")));
            this.lstImage.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImage.Images.SetKeyName(0, "successful.png");
            this.lstImage.Images.SetKeyName(1, "Error.png");
            this.lstImage.Images.SetKeyName(2, "Information.png");
            // 
            // DragForm
            // 
            this.DragForm.Fixed = true;
            this.DragForm.Horizontal = true;
            this.DragForm.TargetControl = this.pnlFranja;
            this.DragForm.Vertical = true;
            // 
            // txtMensaje
            // 
            this.txtMensaje.BackColor = System.Drawing.Color.White;
            this.txtMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMensaje.Enabled = false;
            this.txtMensaje.Font = new System.Drawing.Font("Calisto MT", 9.75F);
            this.txtMensaje.ForeColor = System.Drawing.Color.Black;
            this.txtMensaje.Location = new System.Drawing.Point(36, 123);
            this.txtMensaje.Multiline = true;
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(194, 88);
            this.txtMensaje.TabIndex = 8;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAceptar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAceptar.BorderRadius = 7;
            this.btnAceptar.ButtonText = "Aceptar";
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAceptar.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAceptar.Iconimage = null;
            this.btnAceptar.Iconimage_right = null;
            this.btnAceptar.Iconimage_right_Selected = null;
            this.btnAceptar.Iconimage_Selected = null;
            this.btnAceptar.IconMarginLeft = 0;
            this.btnAceptar.IconMarginRight = 0;
            this.btnAceptar.IconRightVisible = true;
            this.btnAceptar.IconRightZoom = 0D;
            this.btnAceptar.IconVisible = true;
            this.btnAceptar.IconZoom = 30D;
            this.btnAceptar.IsTab = false;
            this.btnAceptar.Location = new System.Drawing.Point(45, 260);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnAceptar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(170)))), ((int)(((byte)(132)))));
            this.btnAceptar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAceptar.selected = false;
            this.btnAceptar.Size = new System.Drawing.Size(185, 35);
            this.btnAceptar.TabIndex = 58;
            this.btnAceptar.TabStop = false;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAceptar.Textcolor = System.Drawing.Color.White;
            this.btnAceptar.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAlerta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(264, 310);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.pnlFranja);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAlerta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAlerta";
            this.Load += new System.EventHandler(this.frmAlerta_Load);
            this.pnlFranja.ResumeLayout(false);
            this.pnlFranja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlFranja;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.ImageList lstImage;
        private Bunifu.Framework.UI.BunifuImageButton btnCerrar;
        private Bunifu.Framework.UI.BunifuDragControl DragForm;
        private System.Windows.Forms.TextBox txtMensaje;
        private Bunifu.Framework.UI.BunifuFlatButton btnAceptar;
    }
}