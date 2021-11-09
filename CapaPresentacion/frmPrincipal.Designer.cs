
namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.SideBar = new System.Windows.Forms.Panel();
            this.btnGanancias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Puntero = new System.Windows.Forms.PictureBox();
            this.btnProveedores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTrabajadores = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnVentas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProductos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDashboard = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.Content = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Puntero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(32)))), ((int)(((byte)(34)))));
            this.SideBar.Controls.Add(this.panel1);
            this.SideBar.Controls.Add(this.btnGanancias);
            this.SideBar.Controls.Add(this.Puntero);
            this.SideBar.Controls.Add(this.btnProveedores);
            this.SideBar.Controls.Add(this.btnClientes);
            this.SideBar.Controls.Add(this.btnTrabajadores);
            this.SideBar.Controls.Add(this.btnCompras);
            this.SideBar.Controls.Add(this.btnVentas);
            this.SideBar.Controls.Add(this.btnProductos);
            this.SideBar.Controls.Add(this.btnDashboard);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(270, 788);
            this.SideBar.TabIndex = 0;
            // 
            // btnGanancias
            // 
            this.btnGanancias.Activecolor = System.Drawing.Color.Transparent;
            this.btnGanancias.BackColor = System.Drawing.Color.Transparent;
            this.btnGanancias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGanancias.BorderRadius = 0;
            this.btnGanancias.ButtonText = "      GANANCIAS";
            this.btnGanancias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGanancias.DisabledColor = System.Drawing.Color.Gray;
            this.btnGanancias.ForeColor = System.Drawing.Color.DimGray;
            this.btnGanancias.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGanancias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnGanancias.Iconimage")));
            this.btnGanancias.Iconimage_right = null;
            this.btnGanancias.Iconimage_right_Selected = null;
            this.btnGanancias.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnGanancias.Iconimage_Selected")));
            this.btnGanancias.IconMarginLeft = 0;
            this.btnGanancias.IconMarginRight = 0;
            this.btnGanancias.IconRightVisible = true;
            this.btnGanancias.IconRightZoom = 0D;
            this.btnGanancias.IconVisible = true;
            this.btnGanancias.IconZoom = 50D;
            this.btnGanancias.IsTab = true;
            this.btnGanancias.Location = new System.Drawing.Point(38, 684);
            this.btnGanancias.Name = "btnGanancias";
            this.btnGanancias.Normalcolor = System.Drawing.Color.Transparent;
            this.btnGanancias.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnGanancias.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnGanancias.selected = false;
            this.btnGanancias.Size = new System.Drawing.Size(191, 48);
            this.btnGanancias.TabIndex = 0;
            this.btnGanancias.Text = "      GANANCIAS";
            this.btnGanancias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGanancias.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGanancias.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanancias.Click += new System.EventHandler(this.btnGanancias_Click);
            // 
            // Puntero
            // 
            this.Puntero.Image = ((System.Drawing.Image)(resources.GetObject("Puntero.Image")));
            this.Puntero.Location = new System.Drawing.Point(245, 236);
            this.Puntero.Name = "Puntero";
            this.Puntero.Size = new System.Drawing.Size(25, 48);
            this.Puntero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Puntero.TabIndex = 9;
            this.Puntero.TabStop = false;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Activecolor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackColor = System.Drawing.Color.Transparent;
            this.btnProveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProveedores.BorderRadius = 0;
            this.btnProveedores.ButtonText = "      PROVEEDORES";
            this.btnProveedores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProveedores.DisabledColor = System.Drawing.Color.Gray;
            this.btnProveedores.ForeColor = System.Drawing.Color.DimGray;
            this.btnProveedores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProveedores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Iconimage")));
            this.btnProveedores.Iconimage_right = null;
            this.btnProveedores.Iconimage_right_Selected = null;
            this.btnProveedores.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Iconimage_Selected")));
            this.btnProveedores.IconMarginLeft = 0;
            this.btnProveedores.IconMarginRight = 0;
            this.btnProveedores.IconRightVisible = true;
            this.btnProveedores.IconRightZoom = 0D;
            this.btnProveedores.IconVisible = true;
            this.btnProveedores.IconZoom = 50D;
            this.btnProveedores.IsTab = true;
            this.btnProveedores.Location = new System.Drawing.Point(38, 620);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProveedores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProveedores.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnProveedores.selected = false;
            this.btnProveedores.Size = new System.Drawing.Size(191, 48);
            this.btnProveedores.TabIndex = 8;
            this.btnProveedores.Text = "      PROVEEDORES";
            this.btnProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProveedores.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProveedores.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Activecolor = System.Drawing.Color.Transparent;
            this.btnClientes.BackColor = System.Drawing.Color.Transparent;
            this.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClientes.BorderRadius = 0;
            this.btnClientes.ButtonText = "      CLIENTES";
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnClientes.Location = new System.Drawing.Point(38, 556);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnClientes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnClientes.selected = false;
            this.btnClientes.Size = new System.Drawing.Size(191, 48);
            this.btnClientes.TabIndex = 7;
            this.btnClientes.Text = "      CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClientes.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClientes.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnTrabajadores
            // 
            this.btnTrabajadores.Activecolor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.BackColor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrabajadores.BorderRadius = 0;
            this.btnTrabajadores.ButtonText = "      TRABAJADORES";
            this.btnTrabajadores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrabajadores.DisabledColor = System.Drawing.Color.Gray;
            this.btnTrabajadores.ForeColor = System.Drawing.Color.DimGray;
            this.btnTrabajadores.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.Iconimage")));
            this.btnTrabajadores.Iconimage_right = null;
            this.btnTrabajadores.Iconimage_right_Selected = null;
            this.btnTrabajadores.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnTrabajadores.Iconimage_Selected")));
            this.btnTrabajadores.IconMarginLeft = 0;
            this.btnTrabajadores.IconMarginRight = 0;
            this.btnTrabajadores.IconRightVisible = true;
            this.btnTrabajadores.IconRightZoom = 0D;
            this.btnTrabajadores.IconVisible = true;
            this.btnTrabajadores.IconZoom = 50D;
            this.btnTrabajadores.IsTab = true;
            this.btnTrabajadores.Location = new System.Drawing.Point(38, 492);
            this.btnTrabajadores.Name = "btnTrabajadores";
            this.btnTrabajadores.Normalcolor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnTrabajadores.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnTrabajadores.selected = false;
            this.btnTrabajadores.Size = new System.Drawing.Size(191, 48);
            this.btnTrabajadores.TabIndex = 6;
            this.btnTrabajadores.Text = "      TRABAJADORES";
            this.btnTrabajadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrabajadores.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTrabajadores.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrabajadores.Click += new System.EventHandler(this.btnTrabajadores_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Activecolor = System.Drawing.Color.Transparent;
            this.btnCompras.BackColor = System.Drawing.Color.Transparent;
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.BorderRadius = 0;
            this.btnCompras.ButtonText = "      COMPRAS";
            this.btnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCompras.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnCompras.Location = new System.Drawing.Point(38, 428);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Normalcolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnCompras.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnCompras.selected = false;
            this.btnCompras.Size = new System.Drawing.Size(191, 48);
            this.btnCompras.TabIndex = 5;
            this.btnCompras.Text = "      COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCompras.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnVentas.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnVentas.Location = new System.Drawing.Point(38, 364);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnVentas.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnVentas.selected = false;
            this.btnVentas.Size = new System.Drawing.Size(191, 48);
            this.btnVentas.TabIndex = 4;
            this.btnVentas.Text = "      VENTAS";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnVentas.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Activecolor = System.Drawing.Color.Transparent;
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.BorderRadius = 0;
            this.btnProductos.ButtonText = "      PRODUCTOS";
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledColor = System.Drawing.Color.Gray;
            this.btnProductos.ForeColor = System.Drawing.Color.DimGray;
            this.btnProductos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProductos.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage")));
            this.btnProductos.Iconimage_right = null;
            this.btnProductos.Iconimage_right_Selected = null;
            this.btnProductos.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("btnProductos.Iconimage_Selected")));
            this.btnProductos.IconMarginLeft = 0;
            this.btnProductos.IconMarginRight = 0;
            this.btnProductos.IconRightVisible = true;
            this.btnProductos.IconRightZoom = 0D;
            this.btnProductos.IconVisible = true;
            this.btnProductos.IconZoom = 50D;
            this.btnProductos.IsTab = true;
            this.btnProductos.Location = new System.Drawing.Point(38, 300);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnProductos.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnProductos.selected = false;
            this.btnProductos.Size = new System.Drawing.Size(191, 48);
            this.btnProductos.TabIndex = 3;
            this.btnProductos.Text = "      PRODUCTOS";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnProductos.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Activecolor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashboard.BorderRadius = 0;
            this.btnDashboard.ButtonText = "      DASHBOARD";
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnDashboard.Location = new System.Drawing.Point(38, 236);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHovercolor = System.Drawing.Color.Transparent;
            this.btnDashboard.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(222)))), ((int)(((byte)(105)))));
            this.btnDashboard.selected = false;
            this.btnDashboard.Size = new System.Drawing.Size(191, 48);
            this.btnDashboard.TabIndex = 2;
            this.btnDashboard.Text = "      DASHBOARD";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDashboard.TextFont = new System.Drawing.Font("Calisto MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(82, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Juan Ramón";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.Header.Controls.Add(this.label1);
            this.Header.Controls.Add(this.btnCerrar);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(270, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1116, 60);
            this.Header.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "DASHBOARD";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1054, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 50);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // Content
            // 
            this.Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(243)))), ((int)(((byte)(240)))));
            this.Content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content.Location = new System.Drawing.Point(270, 60);
            this.Content.Name = "Content";
            this.Content.Size = new System.Drawing.Size(1116, 728);
            this.Content.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 173);
            this.panel1.TabIndex = 1;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Content);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.SideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.SideBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Puntero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel Content;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btnDashboard;
        private Bunifu.Framework.UI.BunifuFlatButton btnProveedores;
        private Bunifu.Framework.UI.BunifuFlatButton btnClientes;
        private Bunifu.Framework.UI.BunifuFlatButton btnTrabajadores;
        private Bunifu.Framework.UI.BunifuFlatButton btnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btnVentas;
        private Bunifu.Framework.UI.BunifuFlatButton btnProductos;
        private System.Windows.Forms.PictureBox Puntero;
        private Bunifu.Framework.UI.BunifuFlatButton btnGanancias;
        private System.Windows.Forms.Panel panel1;
    }
}