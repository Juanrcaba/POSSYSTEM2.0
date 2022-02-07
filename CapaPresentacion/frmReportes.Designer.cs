
namespace CapaPresentacion
{
    partial class frmReportes
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
            this.SideBarPanel = new System.Windows.Forms.Panel();
            this.Report = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnHoy = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn7Dias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnL30dias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAnio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCustom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DtDesde = new System.Windows.Forms.DateTimePicker();
            this.DtHasta = new System.Windows.Forms.DateTimePicker();
            this.btnAplicar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ReporteVentas = new System.Windows.Forms.BindingSource(this.components);
            this.ListadoVentas = new System.Windows.Forms.BindingSource(this.components);
            this.VentasTotalesPorPeriodo = new System.Windows.Forms.BindingSource(this.components);
            this.SideBarPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasTotalesPorPeriodo)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.White;
            this.SideBarPanel.Controls.Add(this.label2);
            this.SideBarPanel.Controls.Add(this.label1);
            this.SideBarPanel.Controls.Add(this.btnAplicar);
            this.SideBarPanel.Controls.Add(this.DtHasta);
            this.SideBarPanel.Controls.Add(this.DtDesde);
            this.SideBarPanel.Controls.Add(this.btnCustom);
            this.SideBarPanel.Controls.Add(this.btnAnio);
            this.SideBarPanel.Controls.Add(this.btnL30dias);
            this.SideBarPanel.Controls.Add(this.btnMes);
            this.SideBarPanel.Controls.Add(this.btn7Dias);
            this.SideBarPanel.Controls.Add(this.btnHoy);
            this.SideBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBarPanel.Location = new System.Drawing.Point(0, 0);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(284, 778);
            this.SideBarPanel.TabIndex = 0;
            // 
            // Report
            // 
            this.Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Report.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Report.SalesReport.rdlc";
            this.Report.Location = new System.Drawing.Point(284, 0);
            this.Report.Name = "Report";
            this.Report.ServerReport.BearerToken = null;
            this.Report.Size = new System.Drawing.Size(712, 778);
            this.Report.TabIndex = 1;
            // 
            // btnHoy
            // 
            this.btnHoy.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHoy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoy.BorderRadius = 7;
            this.btnHoy.ButtonText = "Hoy";
            this.btnHoy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoy.DisabledColor = System.Drawing.Color.Gray;
            this.btnHoy.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnHoy.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHoy.Iconimage = null;
            this.btnHoy.Iconimage_right = null;
            this.btnHoy.Iconimage_right_Selected = null;
            this.btnHoy.Iconimage_Selected = null;
            this.btnHoy.IconMarginLeft = 0;
            this.btnHoy.IconMarginRight = 0;
            this.btnHoy.IconRightVisible = true;
            this.btnHoy.IconRightZoom = 0D;
            this.btnHoy.IconVisible = true;
            this.btnHoy.IconZoom = 30D;
            this.btnHoy.IsTab = false;
            this.btnHoy.Location = new System.Drawing.Point(16, 41);
            this.btnHoy.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnHoy.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnHoy.OnHoverTextColor = System.Drawing.Color.White;
            this.btnHoy.selected = false;
            this.btnHoy.Size = new System.Drawing.Size(237, 48);
            this.btnHoy.TabIndex = 38;
            this.btnHoy.TabStop = false;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHoy.Textcolor = System.Drawing.Color.White;
            this.btnHoy.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnHoy.Click += new System.EventHandler(this.btnHoy_Click);
            // 
            // btn7Dias
            // 
            this.btn7Dias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn7Dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn7Dias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn7Dias.BorderRadius = 7;
            this.btn7Dias.ButtonText = "Ultimos 7 dias";
            this.btn7Dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7Dias.DisabledColor = System.Drawing.Color.Gray;
            this.btn7Dias.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btn7Dias.Iconcolor = System.Drawing.Color.Transparent;
            this.btn7Dias.Iconimage = null;
            this.btn7Dias.Iconimage_right = null;
            this.btn7Dias.Iconimage_right_Selected = null;
            this.btn7Dias.Iconimage_Selected = null;
            this.btn7Dias.IconMarginLeft = 0;
            this.btn7Dias.IconMarginRight = 0;
            this.btn7Dias.IconRightVisible = true;
            this.btn7Dias.IconRightZoom = 0D;
            this.btn7Dias.IconVisible = true;
            this.btn7Dias.IconZoom = 30D;
            this.btn7Dias.IsTab = false;
            this.btn7Dias.Location = new System.Drawing.Point(16, 101);
            this.btn7Dias.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btn7Dias.Name = "btn7Dias";
            this.btn7Dias.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn7Dias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btn7Dias.OnHoverTextColor = System.Drawing.Color.White;
            this.btn7Dias.selected = false;
            this.btn7Dias.Size = new System.Drawing.Size(237, 48);
            this.btn7Dias.TabIndex = 39;
            this.btn7Dias.TabStop = false;
            this.btn7Dias.Text = "Ultimos 7 dias";
            this.btn7Dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn7Dias.Textcolor = System.Drawing.Color.White;
            this.btn7Dias.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btn7Dias.Click += new System.EventHandler(this.btn7Dias_Click);
            // 
            // btnMes
            // 
            this.btnMes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMes.BorderRadius = 7;
            this.btnMes.ButtonText = "Este Mes";
            this.btnMes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMes.DisabledColor = System.Drawing.Color.Gray;
            this.btnMes.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnMes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMes.Iconimage = null;
            this.btnMes.Iconimage_right = null;
            this.btnMes.Iconimage_right_Selected = null;
            this.btnMes.Iconimage_Selected = null;
            this.btnMes.IconMarginLeft = 0;
            this.btnMes.IconMarginRight = 0;
            this.btnMes.IconRightVisible = true;
            this.btnMes.IconRightZoom = 0D;
            this.btnMes.IconVisible = true;
            this.btnMes.IconZoom = 30D;
            this.btnMes.IsTab = false;
            this.btnMes.Location = new System.Drawing.Point(16, 161);
            this.btnMes.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMes.Name = "btnMes";
            this.btnMes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnMes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMes.selected = false;
            this.btnMes.Size = new System.Drawing.Size(237, 48);
            this.btnMes.TabIndex = 40;
            this.btnMes.TabStop = false;
            this.btnMes.Text = "Este Mes";
            this.btnMes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMes.Textcolor = System.Drawing.Color.White;
            this.btnMes.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnMes.Click += new System.EventHandler(this.btnMes_Click);
            // 
            // btnL30dias
            // 
            this.btnL30dias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnL30dias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnL30dias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnL30dias.BorderRadius = 7;
            this.btnL30dias.ButtonText = "Ultimos 30 Dias";
            this.btnL30dias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnL30dias.DisabledColor = System.Drawing.Color.Gray;
            this.btnL30dias.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnL30dias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnL30dias.Iconimage = null;
            this.btnL30dias.Iconimage_right = null;
            this.btnL30dias.Iconimage_right_Selected = null;
            this.btnL30dias.Iconimage_Selected = null;
            this.btnL30dias.IconMarginLeft = 0;
            this.btnL30dias.IconMarginRight = 0;
            this.btnL30dias.IconRightVisible = true;
            this.btnL30dias.IconRightZoom = 0D;
            this.btnL30dias.IconVisible = true;
            this.btnL30dias.IconZoom = 30D;
            this.btnL30dias.IsTab = false;
            this.btnL30dias.Location = new System.Drawing.Point(16, 221);
            this.btnL30dias.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnL30dias.Name = "btnL30dias";
            this.btnL30dias.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnL30dias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnL30dias.OnHoverTextColor = System.Drawing.Color.White;
            this.btnL30dias.selected = false;
            this.btnL30dias.Size = new System.Drawing.Size(237, 48);
            this.btnL30dias.TabIndex = 41;
            this.btnL30dias.TabStop = false;
            this.btnL30dias.Text = "Ultimos 30 Dias";
            this.btnL30dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnL30dias.Textcolor = System.Drawing.Color.White;
            this.btnL30dias.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnL30dias.Click += new System.EventHandler(this.btnL30dias_Click);
            // 
            // btnAnio
            // 
            this.btnAnio.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnio.BorderRadius = 7;
            this.btnAnio.ButtonText = "Este Año";
            this.btnAnio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnio.DisabledColor = System.Drawing.Color.Gray;
            this.btnAnio.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnAnio.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAnio.Iconimage = null;
            this.btnAnio.Iconimage_right = null;
            this.btnAnio.Iconimage_right_Selected = null;
            this.btnAnio.Iconimage_Selected = null;
            this.btnAnio.IconMarginLeft = 0;
            this.btnAnio.IconMarginRight = 0;
            this.btnAnio.IconRightVisible = true;
            this.btnAnio.IconRightZoom = 0D;
            this.btnAnio.IconVisible = true;
            this.btnAnio.IconZoom = 30D;
            this.btnAnio.IsTab = false;
            this.btnAnio.Location = new System.Drawing.Point(16, 281);
            this.btnAnio.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAnio.Name = "btnAnio";
            this.btnAnio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAnio.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnAnio.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAnio.selected = false;
            this.btnAnio.Size = new System.Drawing.Size(237, 48);
            this.btnAnio.TabIndex = 42;
            this.btnAnio.TabStop = false;
            this.btnAnio.Text = "Este Año";
            this.btnAnio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAnio.Textcolor = System.Drawing.Color.White;
            this.btnAnio.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnAnio.Click += new System.EventHandler(this.btnAnio_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCustom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCustom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustom.BorderRadius = 7;
            this.btnCustom.ButtonText = "Personalizado";
            this.btnCustom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustom.DisabledColor = System.Drawing.Color.Gray;
            this.btnCustom.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnCustom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCustom.Iconimage = null;
            this.btnCustom.Iconimage_right = null;
            this.btnCustom.Iconimage_right_Selected = null;
            this.btnCustom.Iconimage_Selected = null;
            this.btnCustom.IconMarginLeft = 0;
            this.btnCustom.IconMarginRight = 0;
            this.btnCustom.IconRightVisible = true;
            this.btnCustom.IconRightZoom = 0D;
            this.btnCustom.IconVisible = true;
            this.btnCustom.IconZoom = 30D;
            this.btnCustom.IsTab = false;
            this.btnCustom.Location = new System.Drawing.Point(16, 341);
            this.btnCustom.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCustom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnCustom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCustom.selected = false;
            this.btnCustom.Size = new System.Drawing.Size(237, 48);
            this.btnCustom.TabIndex = 43;
            this.btnCustom.TabStop = false;
            this.btnCustom.Text = "Personalizado";
            this.btnCustom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCustom.Textcolor = System.Drawing.Color.White;
            this.btnCustom.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            // 
            // DtDesde
            // 
            this.DtDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtDesde.Location = new System.Drawing.Point(123, 398);
            this.DtDesde.Name = "DtDesde";
            this.DtDesde.Size = new System.Drawing.Size(130, 29);
            this.DtDesde.TabIndex = 44;
            // 
            // DtHasta
            // 
            this.DtHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtHasta.Location = new System.Drawing.Point(123, 433);
            this.DtHasta.Name = "DtHasta";
            this.DtHasta.Size = new System.Drawing.Size(130, 29);
            this.DtHasta.TabIndex = 45;
            // 
            // btnAplicar
            // 
            this.btnAplicar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAplicar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAplicar.BorderRadius = 7;
            this.btnAplicar.ButtonText = "Aplicar";
            this.btnAplicar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAplicar.DisabledColor = System.Drawing.Color.Gray;
            this.btnAplicar.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAplicar.Iconimage = null;
            this.btnAplicar.Iconimage_right = null;
            this.btnAplicar.Iconimage_right_Selected = null;
            this.btnAplicar.Iconimage_Selected = null;
            this.btnAplicar.IconMarginLeft = 0;
            this.btnAplicar.IconMarginRight = 0;
            this.btnAplicar.IconRightVisible = true;
            this.btnAplicar.IconRightZoom = 0D;
            this.btnAplicar.IconVisible = true;
            this.btnAplicar.IconZoom = 30D;
            this.btnAplicar.IsTab = false;
            this.btnAplicar.Location = new System.Drawing.Point(16, 471);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAplicar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnAplicar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAplicar.selected = false;
            this.btnAplicar.Size = new System.Drawing.Size(237, 48);
            this.btnAplicar.TabIndex = 46;
            this.btnAplicar.TabStop = false;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAplicar.Textcolor = System.Drawing.Color.White;
            this.btnAplicar.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Hasta";
            // 
            // ReporteVentas
            // 
            this.ReporteVentas.DataSource = typeof(CapaNegocio.N_REPORTE_VENTAS);
            // 
            // ListadoVentas
            // 
            this.ListadoVentas.DataSource = typeof(CapaNegocio.N_ListadoVentas);
            // 
            // VentasTotalesPorPeriodo
            // 
            this.VentasTotalesPorPeriodo.DataSource = typeof(CapaNegocio.N_VentasNetasPorPeriodo);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 778);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.SideBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.SideBarPanel.ResumeLayout(false);
            this.SideBarPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListadoVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VentasTotalesPorPeriodo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBarPanel;
        private Microsoft.Reporting.WinForms.ReportViewer Report;
        private System.Windows.Forms.BindingSource ReporteVentas;
        private System.Windows.Forms.BindingSource ListadoVentas;
        private System.Windows.Forms.BindingSource VentasTotalesPorPeriodo;
        private Bunifu.Framework.UI.BunifuFlatButton btnHoy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAplicar;
        private System.Windows.Forms.DateTimePicker DtHasta;
        private System.Windows.Forms.DateTimePicker DtDesde;
        private Bunifu.Framework.UI.BunifuFlatButton btnCustom;
        private Bunifu.Framework.UI.BunifuFlatButton btnAnio;
        private Bunifu.Framework.UI.BunifuFlatButton btnL30dias;
        private Bunifu.Framework.UI.BunifuFlatButton btnMes;
        private Bunifu.Framework.UI.BunifuFlatButton btn7Dias;
    }
}