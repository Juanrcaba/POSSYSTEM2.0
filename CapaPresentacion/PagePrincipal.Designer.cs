﻿
namespace CapaPresentacion
{
    partial class PagePrincipal
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagePrincipal));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.sidebar = new System.Windows.Forms.Panel();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnGanancia = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProveedor = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrabajador = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.logo = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.header = new System.Windows.Forms.Panel();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.container = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.bunifuColorTransition1 = new Bunifu.Framework.UI.BunifuColorTransition(this.components);
            this.AnimationSidebar = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.lstImage = new System.Windows.Forms.ImageList(this.components);
            this.pnlReportes = new System.Windows.Forms.Panel();
            this.btnVentasActivas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentasCanceladas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.AnimationPnlRpt = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.sidebar.SuspendLayout();
            this.logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            this.container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlReportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.sidebar.Controls.Add(this.pnlReportes);
            this.sidebar.Controls.Add(this.btnSalir);
            this.sidebar.Controls.Add(this.btnGanancia);
            this.sidebar.Controls.Add(this.btnProveedor);
            this.sidebar.Controls.Add(this.btnClientes);
            this.sidebar.Controls.Add(this.btnTrabajador);
            this.sidebar.Controls.Add(this.btnCompras);
            this.sidebar.Controls.Add(this.btnVentas);
            this.sidebar.Controls.Add(this.btnProducto);
            this.sidebar.Controls.Add(this.btnDashboard);
            this.sidebar.Controls.Add(this.logo);
            this.AnimationPnlRpt.SetDecoration(this.sidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.sidebar, BunifuAnimatorNS.DecorationType.None);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 0);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(185, 817);
            this.sidebar.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.Transparent;
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 0;
            this.btnSalir.ButtonText = "      SALIR";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnSalir, BunifuAnimatorNS.DecorationType.None);
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.ForeColor = System.Drawing.Color.DimGray;
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSalir.Iconimage")));
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 50D;
            this.btnSalir.IsTab = true;
            this.btnSalir.Location = new System.Drawing.Point(0, 769);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSalir.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(185, 48);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "      SALIR";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSalir.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGanancia
            // 
            this.btnGanancia.Activecolor = System.Drawing.Color.Transparent;
            this.btnGanancia.BackColor = System.Drawing.Color.Transparent;
            this.btnGanancia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGanancia.BorderRadius = 0;
            this.btnGanancia.ButtonText = "      REPORTES";
            this.btnGanancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnGanancia, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnGanancia, BunifuAnimatorNS.DecorationType.None);
            this.btnGanancia.DisabledColor = System.Drawing.Color.Gray;
            this.btnGanancia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGanancia.ForeColor = System.Drawing.Color.DimGray;
            this.btnGanancia.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGanancia.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGanancia.Iconimage")));
            this.btnGanancia.Iconimage_right = null;
            this.btnGanancia.Iconimage_right_Selected = null;
            this.btnGanancia.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnGanancia.Iconimage_Selected")));
            this.btnGanancia.IconMarginLeft = 0;
            this.btnGanancia.IconMarginRight = 0;
            this.btnGanancia.IconRightVisible = true;
            this.btnGanancia.IconRightZoom = 0D;
            this.btnGanancia.IconVisible = true;
            this.btnGanancia.IconZoom = 50D;
            this.btnGanancia.IsTab = true;
            this.btnGanancia.Location = new System.Drawing.Point(0, 509);
            this.btnGanancia.Name = "btnGanancia";
            this.btnGanancia.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGanancia.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGanancia.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnGanancia.selected = false;
            this.btnGanancia.Size = new System.Drawing.Size(185, 48);
            this.btnGanancia.TabIndex = 10;
            this.btnGanancia.Text = "      REPORTES";
            this.btnGanancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGanancia.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGanancia.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancia.Click += new System.EventHandler(this.btnGanancia_Click);
            // 
            // btnProveedor
            // 
            this.btnProveedor.Activecolor = System.Drawing.Color.Transparent;
            this.btnProveedor.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedor.BorderRadius = 0;
            this.btnProveedor.ButtonText = "      PROVEEDORES";
            this.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnProveedor, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnProveedor, BunifuAnimatorNS.DecorationType.None);
            this.btnProveedor.DisabledColor = System.Drawing.Color.Gray;
            this.btnProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedor.ForeColor = System.Drawing.Color.DimGray;
            this.btnProveedor.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProveedor.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Iconimage")));
            this.btnProveedor.Iconimage_right = null;
            this.btnProveedor.Iconimage_right_Selected = null;
            this.btnProveedor.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnProveedor.Iconimage_Selected")));
            this.btnProveedor.IconMarginLeft = 0;
            this.btnProveedor.IconMarginRight = 0;
            this.btnProveedor.IconRightVisible = true;
            this.btnProveedor.IconRightZoom = 0D;
            this.btnProveedor.IconVisible = true;
            this.btnProveedor.IconZoom = 50D;
            this.btnProveedor.IsTab = true;
            this.btnProveedor.Location = new System.Drawing.Point(0, 461);
            this.btnProveedor.Name = "btnProveedor";
            this.btnProveedor.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProveedor.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProveedor.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnProveedor.selected = false;
            this.btnProveedor.Size = new System.Drawing.Size(185, 48);
            this.btnProveedor.TabIndex = 9;
            this.btnProveedor.Text = "      PROVEEDORES";
            this.btnProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedor.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProveedor.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedor.Click += new System.EventHandler(this.btnProveedor_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "      CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnClientes, BunifuAnimatorNS.DecorationType.None);
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.ForeColor = System.Drawing.Color.DimGray;
            this.btnClientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnClientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage")));
            this.btnClientes.Iconimage_right = null;
            this.btnClientes.Iconimage_right_Selected = null;
            this.btnClientes.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnClientes.Iconimage_Selected")));
            this.btnClientes.IconMarginLeft = 0;
            this.btnClientes.IconMarginRight = 0;
            this.btnClientes.IconRightVisible = true;
            this.btnClientes.IconRightZoom = 0D;
            this.btnClientes.IconVisible = true;
            this.btnClientes.IconZoom = 50D;
            this.btnClientes.IsTab = true;
            this.btnClientes.Location = new System.Drawing.Point(0, 413);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(185, 48);
            this.btnClientes.TabIndex = 8;
            this.btnClientes.Text = "      CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientes.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.Activecolor = System.Drawing.Color.Transparent;
            this.btnTrabajador.BackColor = System.Drawing.Color.Transparent;
            this.btnTrabajador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrabajador.BorderRadius = 0;
            this.btnTrabajador.ButtonText = "      TRABAJADORES";
            this.btnTrabajador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnTrabajador, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnTrabajador, BunifuAnimatorNS.DecorationType.None);
            this.btnTrabajador.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrabajador.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTrabajador.ForeColor = System.Drawing.Color.DimGray;
            this.btnTrabajador.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrabajador.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrabajador.Iconimage")));
            this.btnTrabajador.Iconimage_right = null;
            this.btnTrabajador.Iconimage_right_Selected = null;
            this.btnTrabajador.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnTrabajador.Iconimage_Selected")));
            this.btnTrabajador.IconMarginLeft = 0;
            this.btnTrabajador.IconMarginRight = 0;
            this.btnTrabajador.IconRightVisible = true;
            this.btnTrabajador.IconRightZoom = 0D;
            this.btnTrabajador.IconVisible = true;
            this.btnTrabajador.IconZoom = 50D;
            this.btnTrabajador.IsTab = true;
            this.btnTrabajador.Location = new System.Drawing.Point(0, 365);
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTrabajador.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTrabajador.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnTrabajador.selected = false;
            this.btnTrabajador.Size = new System.Drawing.Size(185, 48);
            this.btnTrabajador.TabIndex = 7;
            this.btnTrabajador.Text = "      TRABAJADORES";
            this.btnTrabajador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajador.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrabajador.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.Transparent;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 0;
            this.btnCompras.ButtonText = "      COMPRAS";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnCompras, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnCompras, BunifuAnimatorNS.DecorationType.None);
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.ForeColor = System.Drawing.Color.DimGray;
            this.btnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage")));
            this.btnCompras.Iconimage_right = null;
            this.btnCompras.Iconimage_right_Selected = null;
            this.btnCompras.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnCompras.Iconimage_Selected")));
            this.btnCompras.IconMarginLeft = 0;
            this.btnCompras.IconMarginRight = 0;
            this.btnCompras.IconRightVisible = true;
            this.btnCompras.IconRightZoom = 0D;
            this.btnCompras.IconVisible = true;
            this.btnCompras.IconZoom = 50D;
            this.btnCompras.IsTab = true;
            this.btnCompras.Location = new System.Drawing.Point(0, 317);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(185, 48);
            this.btnCompras.TabIndex = 6;
            this.btnCompras.Text = "      COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCompras.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.Visible = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.BorderRadius = 0;
            this.btnVentas.ButtonText = "      VENTAS";
            this.btnVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnVentas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.ForeColor = System.Drawing.Color.DimGray;
            this.btnVentas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentas.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage")));
            this.btnVentas.Iconimage_right = null;
            this.btnVentas.Iconimage_right_Selected = null;
            this.btnVentas.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnVentas.Iconimage_Selected")));
            this.btnVentas.IconMarginLeft = 0;
            this.btnVentas.IconMarginRight = 0;
            this.btnVentas.IconRightVisible = true;
            this.btnVentas.IconRightZoom = 0D;
            this.btnVentas.IconVisible = true;
            this.btnVentas.IconZoom = 50D;
            this.btnVentas.IsTab = true;
            this.btnVentas.Location = new System.Drawing.Point(0, 269);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(185, 48);
            this.btnVentas.TabIndex = 5;
            this.btnVentas.Text = "      VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVentas.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Activecolor = System.Drawing.Color.Transparent;
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.BorderRadius = 0;
            this.btnProducto.ButtonText = "      PRODUCTO";
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnProducto, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnProducto, BunifuAnimatorNS.DecorationType.None);
            this.btnProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.ForeColor = System.Drawing.Color.DimGray;
            this.btnProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProducto.Iconimage")));
            this.btnProducto.Iconimage_right = null;
            this.btnProducto.Iconimage_right_Selected = null;
            this.btnProducto.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnProducto.Iconimage_Selected")));
            this.btnProducto.IconMarginLeft = 0;
            this.btnProducto.IconMarginRight = 0;
            this.btnProducto.IconRightVisible = true;
            this.btnProducto.IconRightZoom = 0D;
            this.btnProducto.IconVisible = true;
            this.btnProducto.IconZoom = 50D;
            this.btnProducto.IsTab = true;
            this.btnProducto.Location = new System.Drawing.Point(0, 221);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProducto.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProducto.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnProducto.selected = false;
            this.btnProducto.Size = new System.Drawing.Size(185, 48);
            this.btnProducto.TabIndex = 4;
            this.btnProducto.Text = "      PRODUCTO";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProducto.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "      DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnDashboard, BunifuAnimatorNS.DecorationType.None);
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.DimGray;
            this.btnDashboard.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage")));
            this.btnDashboard.Iconimage_right = null;
            this.btnDashboard.Iconimage_right_Selected = null;
            this.btnDashboard.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Iconimage_Selected")));
            this.btnDashboard.IconMarginLeft = 0;
            this.btnDashboard.IconMarginRight = 0;
            this.btnDashboard.IconRightVisible = true;
            this.btnDashboard.IconRightZoom = 0D;
            this.btnDashboard.IconVisible = true;
            this.btnDashboard.IconZoom = 50D;
            this.btnDashboard.IsTab = true;
            this.btnDashboard.Location = new System.Drawing.Point(0, 173);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(185, 48);
            this.btnDashboard.TabIndex = 3;
            this.btnDashboard.Text = "      DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Visible = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // logo
            // 
            this.logo.Controls.Add(this.lblUsuario);
            this.logo.Controls.Add(this.LogoPic);
            this.AnimationPnlRpt.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.logo, BunifuAnimatorNS.DecorationType.None);
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(185, 173);
            this.logo.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.lblUsuario, BunifuAnimatorNS.DecorationType.None);
            this.lblUsuario.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(42, 116);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(100, 20);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Juan Ramón";
            // 
            // LogoPic
            // 
            this.AnimationSidebar.SetDecoration(this.LogoPic, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.LogoPic, BunifuAnimatorNS.DecorationType.None);
            this.LogoPic.Location = new System.Drawing.Point(19, 15);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(146, 98);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoPic.TabIndex = 2;
            this.LogoPic.TabStop = false;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.header.Controls.Add(this.picMenu);
            this.header.Controls.Add(this.lblTitulo);
            this.AnimationPnlRpt.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.header, BunifuAnimatorNS.DecorationType.None);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(185, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(996, 39);
            this.header.TabIndex = 1;
            // 
            // picMenu
            // 
            this.AnimationSidebar.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.picMenu, BunifuAnimatorNS.DecorationType.None);
            this.picMenu.Image = ((System.Drawing.Image)(resources.GetObject("picMenu.Image")));
            this.picMenu.Location = new System.Drawing.Point(6, 6);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(30, 30);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 0;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.AnimationSidebar.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.lblTitulo, BunifuAnimatorNS.DecorationType.None);
            this.lblTitulo.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.lblTitulo.Location = new System.Drawing.Point(58, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(0, 19);
            this.lblTitulo.TabIndex = 0;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.container.Controls.Add(this.picLogo);
            this.AnimationPnlRpt.SetDecoration(this.container, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.container, BunifuAnimatorNS.DecorationType.None);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(185, 39);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(996, 778);
            this.container.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AnimationSidebar.SetDecoration(this.picLogo, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.picLogo, BunifuAnimatorNS.DecorationType.None);
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(229, 202);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(543, 268);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // bunifuColorTransition1
            // 
            this.bunifuColorTransition1.Color1 = System.Drawing.Color.White;
            this.bunifuColorTransition1.Color2 = System.Drawing.Color.White;
            this.bunifuColorTransition1.ProgessValue = 0;
            // 
            // AnimationSidebar
            // 
            this.AnimationSidebar.AnimationType = BunifuAnimatorNS.AnimationType.Particles;
            this.AnimationSidebar.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 1;
            animation1.Padding = new System.Windows.Forms.Padding(100, 50, 100, 150);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 2F;
            animation1.TransparencyCoeff = 0F;
            this.AnimationSidebar.DefaultAnimation = animation1;
            this.AnimationSidebar.MaxAnimationTime = 500;
            // 
            // lstImage
            // 
            this.lstImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lstImage.ImageStream")));
            this.lstImage.TransparentColor = System.Drawing.Color.Transparent;
            this.lstImage.Images.SetKeyName(0, "user-male.png");
            this.lstImage.Images.SetKeyName(1, "user-female.png");
            // 
            // pnlReportes
            // 
            this.pnlReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(100)))), ((int)(((byte)(150)))));
            this.pnlReportes.Controls.Add(this.btnVentasCanceladas);
            this.pnlReportes.Controls.Add(this.btnVentasActivas);
            this.AnimationPnlRpt.SetDecoration(this.pnlReportes, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this.pnlReportes, BunifuAnimatorNS.DecorationType.None);
            this.pnlReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportes.Location = new System.Drawing.Point(0, 557);
            this.pnlReportes.Name = "pnlReportes";
            this.pnlReportes.Size = new System.Drawing.Size(185, 0);
            this.pnlReportes.TabIndex = 12;
            // 
            // btnVentasActivas
            // 
            this.btnVentasActivas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentasActivas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentasActivas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentasActivas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentasActivas.BorderRadius = 0;
            this.btnVentasActivas.ButtonText = "Ventas Realizadas";
            this.btnVentasActivas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnVentasActivas, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnVentasActivas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentasActivas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentasActivas.ForeColor = System.Drawing.Color.DimGray;
            this.btnVentasActivas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentasActivas.Iconimage = null;
            this.btnVentasActivas.Iconimage_right = null;
            this.btnVentasActivas.Iconimage_right_Selected = null;
            this.btnVentasActivas.Iconimage_Selected = null;
            this.btnVentasActivas.IconMarginLeft = 0;
            this.btnVentasActivas.IconMarginRight = 0;
            this.btnVentasActivas.IconRightVisible = true;
            this.btnVentasActivas.IconRightZoom = 0D;
            this.btnVentasActivas.IconVisible = true;
            this.btnVentasActivas.IconZoom = 50D;
            this.btnVentasActivas.IsTab = true;
            this.btnVentasActivas.Location = new System.Drawing.Point(19, 3);
            this.btnVentasActivas.Name = "btnVentasActivas";
            this.btnVentasActivas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentasActivas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVentasActivas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnVentasActivas.selected = false;
            this.btnVentasActivas.Size = new System.Drawing.Size(166, 48);
            this.btnVentasActivas.TabIndex = 11;
            this.btnVentasActivas.Text = "Ventas Realizadas";
            this.btnVentasActivas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasActivas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVentasActivas.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentasActivas.Click += new System.EventHandler(this.btnVentasActivas_Click);
            // 
            // btnVentasCanceladas
            // 
            this.btnVentasCanceladas.Activecolor = System.Drawing.Color.Transparent;
            this.btnVentasCanceladas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVentasCanceladas.BackColor = System.Drawing.Color.Transparent;
            this.btnVentasCanceladas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentasCanceladas.BorderRadius = 0;
            this.btnVentasCanceladas.ButtonText = "   Ventas Canceladas";
            this.btnVentasCanceladas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimationSidebar.SetDecoration(this.btnVentasCanceladas, BunifuAnimatorNS.DecorationType.None);
            this.AnimationPnlRpt.SetDecoration(this.btnVentasCanceladas, BunifuAnimatorNS.DecorationType.None);
            this.btnVentasCanceladas.DisabledColor = System.Drawing.Color.Gray;
            this.btnVentasCanceladas.ForeColor = System.Drawing.Color.DimGray;
            this.btnVentasCanceladas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVentasCanceladas.Iconimage = null;
            this.btnVentasCanceladas.Iconimage_right = null;
            this.btnVentasCanceladas.Iconimage_right_Selected = null;
            this.btnVentasCanceladas.Iconimage_Selected = null;
            this.btnVentasCanceladas.IconMarginLeft = 0;
            this.btnVentasCanceladas.IconMarginRight = 0;
            this.btnVentasCanceladas.IconRightVisible = true;
            this.btnVentasCanceladas.IconRightZoom = 0D;
            this.btnVentasCanceladas.IconVisible = true;
            this.btnVentasCanceladas.IconZoom = 50D;
            this.btnVentasCanceladas.IsTab = true;
            this.btnVentasCanceladas.Location = new System.Drawing.Point(19, 45);
            this.btnVentasCanceladas.Name = "btnVentasCanceladas";
            this.btnVentasCanceladas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentasCanceladas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVentasCanceladas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnVentasCanceladas.selected = false;
            this.btnVentasCanceladas.Size = new System.Drawing.Size(166, 48);
            this.btnVentasCanceladas.TabIndex = 12;
            this.btnVentasCanceladas.Text = "   Ventas Canceladas";
            this.btnVentasCanceladas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVentasCanceladas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVentasCanceladas.TextFont = new System.Drawing.Font("Calisto MT", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // AnimationPnlRpt
            // 
            this.AnimationPnlRpt.AnimationType = BunifuAnimatorNS.AnimationType.Leaf;
            this.AnimationPnlRpt.Cursor = System.Windows.Forms.Cursors.Hand;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 1F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.AnimationPnlRpt.DefaultAnimation = animation2;
            this.AnimationPnlRpt.Interval = 5;
            this.AnimationPnlRpt.MaxAnimationTime = 500;
            this.AnimationPnlRpt.TimeStep = 1F;
            // 
            // PagePrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 817);
            this.Controls.Add(this.container);
            this.Controls.Add(this.header);
            this.Controls.Add(this.sidebar);
            this.AnimationPnlRpt.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimationSidebar.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagePrincipal";
            this.Text = "PagePrincipal";
            this.Load += new System.EventHandler(this.PagePrincipal_Load);
            this.sidebar.ResumeLayout(false);
            this.logo.ResumeLayout(false);
            this.logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.header.ResumeLayout(false);
            this.header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            this.container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlReportes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox LogoPic;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrabajador;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnProducto;
        private Bunifu.Framework.UI.BunifuFlatButton btnGanancia;
        private Bunifu.Framework.UI.BunifuFlatButton btnProveedor;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox picMenu;
        private BunifuAnimatorNS.BunifuTransition AnimationSidebar;
        private Bunifu.Framework.UI.BunifuColorTransition bunifuColorTransition1;
        public System.Windows.Forms.Panel sidebar;
        public System.Windows.Forms.Panel header;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.ImageList lstImage;
        private System.Windows.Forms.Panel pnlReportes;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentasCanceladas;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentasActivas;
        private BunifuAnimatorNS.BunifuTransition AnimationPnlRpt;
    }
}