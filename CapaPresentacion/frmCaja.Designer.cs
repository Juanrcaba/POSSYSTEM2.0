
namespace CapaPresentacion
{
    partial class frmCaja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbtTodas = new System.Windows.Forms.RadioButton();
            this.rbtCerrado = new System.Windows.Forms.RadioButton();
            this.rbtAbierto = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnAbrirCaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCerrarCaja = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTurnos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnImprimir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tablaCajas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSalir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCajas)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtTodas
            // 
            this.rbtTodas.AutoSize = true;
            this.rbtTodas.Location = new System.Drawing.Point(30, 58);
            this.rbtTodas.Name = "rbtTodas";
            this.rbtTodas.Size = new System.Drawing.Size(55, 17);
            this.rbtTodas.TabIndex = 0;
            this.rbtTodas.TabStop = true;
            this.rbtTodas.Text = "Todas";
            this.rbtTodas.UseVisualStyleBackColor = true;
            // 
            // rbtCerrado
            // 
            this.rbtCerrado.AutoSize = true;
            this.rbtCerrado.Location = new System.Drawing.Point(30, 35);
            this.rbtCerrado.Name = "rbtCerrado";
            this.rbtCerrado.Size = new System.Drawing.Size(67, 17);
            this.rbtCerrado.TabIndex = 0;
            this.rbtCerrado.TabStop = true;
            this.rbtCerrado.Text = "Cerradas";
            this.rbtCerrado.UseVisualStyleBackColor = true;
            // 
            // rbtAbierto
            // 
            this.rbtAbierto.AutoSize = true;
            this.rbtAbierto.Location = new System.Drawing.Point(30, 12);
            this.rbtAbierto.Name = "rbtAbierto";
            this.rbtAbierto.Size = new System.Drawing.Size(63, 17);
            this.rbtAbierto.TabIndex = 0;
            this.rbtAbierto.TabStop = true;
            this.rbtAbierto.Text = "Abiertas";
            this.rbtAbierto.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rbtAbierto.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderRadius = 7;
            this.btnBuscar.ButtonText = "Buscar";
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.DisabledColor = System.Drawing.Color.Gray;
            this.btnBuscar.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnBuscar.Iconimage = null;
            this.btnBuscar.Iconimage_right = null;
            this.btnBuscar.Iconimage_right_Selected = null;
            this.btnBuscar.Iconimage_Selected = null;
            this.btnBuscar.IconMarginLeft = 0;
            this.btnBuscar.IconMarginRight = 0;
            this.btnBuscar.IconRightVisible = true;
            this.btnBuscar.IconRightZoom = 0D;
            this.btnBuscar.IconVisible = true;
            this.btnBuscar.IconZoom = 30D;
            this.btnBuscar.IsTab = false;
            this.btnBuscar.Location = new System.Drawing.Point(905, 35);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnBuscar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBuscar.selected = false;
            this.btnBuscar.Size = new System.Drawing.Size(99, 40);
            this.btnBuscar.TabIndex = 42;
            this.btnBuscar.TabStop = false;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Textcolor = System.Drawing.Color.White;
            this.btnBuscar.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtFecha);
            this.panel1.Controls.Add(this.rbtAbierto);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.rbtTodas);
            this.panel1.Controls.Add(this.rbtCerrado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1020, 87);
            this.panel1.TabIndex = 43;
            // 
            // dtFecha
            // 
            this.dtFecha.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.dtFecha.Location = new System.Drawing.Point(158, 46);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(354, 33);
            this.dtFecha.TabIndex = 43;
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAbrirCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbrirCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAbrirCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAbrirCaja.BorderRadius = 7;
            this.btnAbrirCaja.ButtonText = "Abrir Caja";
            this.btnAbrirCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbrirCaja.DisabledColor = System.Drawing.Color.Gray;
            this.btnAbrirCaja.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold);
            this.btnAbrirCaja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAbrirCaja.Iconimage = null;
            this.btnAbrirCaja.Iconimage_right = null;
            this.btnAbrirCaja.Iconimage_right_Selected = null;
            this.btnAbrirCaja.Iconimage_Selected = null;
            this.btnAbrirCaja.IconMarginLeft = 0;
            this.btnAbrirCaja.IconMarginRight = 0;
            this.btnAbrirCaja.IconRightVisible = true;
            this.btnAbrirCaja.IconRightZoom = 0D;
            this.btnAbrirCaja.IconVisible = true;
            this.btnAbrirCaja.IconZoom = 30D;
            this.btnAbrirCaja.IsTab = false;
            this.btnAbrirCaja.Location = new System.Drawing.Point(12, 543);
            this.btnAbrirCaja.Margin = new System.Windows.Forms.Padding(6);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnAbrirCaja.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnAbrirCaja.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAbrirCaja.selected = false;
            this.btnAbrirCaja.Size = new System.Drawing.Size(116, 45);
            this.btnAbrirCaja.TabIndex = 44;
            this.btnAbrirCaja.TabStop = false;
            this.btnAbrirCaja.Text = "Abrir Caja";
            this.btnAbrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAbrirCaja.Textcolor = System.Drawing.Color.White;
            this.btnAbrirCaja.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCerrarCaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCerrarCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCerrarCaja.BorderRadius = 7;
            this.btnCerrarCaja.ButtonText = "Cerrar Caja";
            this.btnCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaja.DisabledColor = System.Drawing.Color.Gray;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold);
            this.btnCerrarCaja.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCerrarCaja.Iconimage = null;
            this.btnCerrarCaja.Iconimage_right = null;
            this.btnCerrarCaja.Iconimage_right_Selected = null;
            this.btnCerrarCaja.Iconimage_Selected = null;
            this.btnCerrarCaja.IconMarginLeft = 0;
            this.btnCerrarCaja.IconMarginRight = 0;
            this.btnCerrarCaja.IconRightVisible = true;
            this.btnCerrarCaja.IconRightZoom = 0D;
            this.btnCerrarCaja.IconVisible = true;
            this.btnCerrarCaja.IconZoom = 30D;
            this.btnCerrarCaja.IsTab = false;
            this.btnCerrarCaja.Location = new System.Drawing.Point(140, 543);
            this.btnCerrarCaja.Margin = new System.Windows.Forms.Padding(6);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnCerrarCaja.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnCerrarCaja.OnHoverTextColor = System.Drawing.Color.White;
            this.btnCerrarCaja.selected = false;
            this.btnCerrarCaja.Size = new System.Drawing.Size(116, 45);
            this.btnCerrarCaja.TabIndex = 45;
            this.btnCerrarCaja.TabStop = false;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCerrarCaja.Textcolor = System.Drawing.Color.White;
            this.btnCerrarCaja.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // btnTurnos
            // 
            this.btnTurnos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTurnos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTurnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTurnos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTurnos.BorderRadius = 7;
            this.btnTurnos.ButtonText = "Turnos";
            this.btnTurnos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTurnos.DisabledColor = System.Drawing.Color.Gray;
            this.btnTurnos.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold);
            this.btnTurnos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTurnos.Iconimage = null;
            this.btnTurnos.Iconimage_right = null;
            this.btnTurnos.Iconimage_right_Selected = null;
            this.btnTurnos.Iconimage_Selected = null;
            this.btnTurnos.IconMarginLeft = 0;
            this.btnTurnos.IconMarginRight = 0;
            this.btnTurnos.IconRightVisible = true;
            this.btnTurnos.IconRightZoom = 0D;
            this.btnTurnos.IconVisible = true;
            this.btnTurnos.IconZoom = 30D;
            this.btnTurnos.IsTab = false;
            this.btnTurnos.Location = new System.Drawing.Point(268, 543);
            this.btnTurnos.Margin = new System.Windows.Forms.Padding(6);
            this.btnTurnos.Name = "btnTurnos";
            this.btnTurnos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnTurnos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnTurnos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTurnos.selected = false;
            this.btnTurnos.Size = new System.Drawing.Size(116, 45);
            this.btnTurnos.TabIndex = 46;
            this.btnTurnos.TabStop = false;
            this.btnTurnos.Text = "Turnos";
            this.btnTurnos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTurnos.Textcolor = System.Drawing.Color.White;
            this.btnTurnos.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnTurnos.Click += new System.EventHandler(this.btnTurnos_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnImprimir.BorderRadius = 7;
            this.btnImprimir.ButtonText = "Imprimir";
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.DisabledColor = System.Drawing.Color.Gray;
            this.btnImprimir.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold);
            this.btnImprimir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnImprimir.Iconimage = null;
            this.btnImprimir.Iconimage_right = null;
            this.btnImprimir.Iconimage_right_Selected = null;
            this.btnImprimir.Iconimage_Selected = null;
            this.btnImprimir.IconMarginLeft = 0;
            this.btnImprimir.IconMarginRight = 0;
            this.btnImprimir.IconRightVisible = true;
            this.btnImprimir.IconRightZoom = 0D;
            this.btnImprimir.IconVisible = true;
            this.btnImprimir.IconZoom = 30D;
            this.btnImprimir.IsTab = false;
            this.btnImprimir.Location = new System.Drawing.Point(396, 543);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnImprimir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnImprimir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnImprimir.selected = false;
            this.btnImprimir.Size = new System.Drawing.Size(116, 45);
            this.btnImprimir.TabIndex = 47;
            this.btnImprimir.TabStop = false;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnImprimir.Textcolor = System.Drawing.Color.White;
            this.btnImprimir.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            // 
            // tablaCajas
            // 
            this.tablaCajas.AllowUserToAddRows = false;
            this.tablaCajas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaCajas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaCajas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaCajas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCajas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaCajas.BackgroundColor = System.Drawing.Color.White;
            this.tablaCajas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCajas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCajas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.tablaCajas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaCajas.DefaultCellStyle = dataGridViewCellStyle7;
            this.tablaCajas.DoubleBuffered = true;
            this.tablaCajas.EnableHeadersVisualStyles = false;
            this.tablaCajas.GridColor = System.Drawing.Color.White;
            this.tablaCajas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.tablaCajas.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaCajas.Location = new System.Drawing.Point(3, 3);
            this.tablaCajas.MultiSelect = false;
            this.tablaCajas.Name = "tablaCajas";
            this.tablaCajas.ReadOnly = true;
            this.tablaCajas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tablaCajas.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.tablaCajas.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.tablaCajas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCajas.Size = new System.Drawing.Size(586, 366);
            this.tablaCajas.TabIndex = 48;
            // 
            // btnSalir
            // 
            this.btnSalir.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.BorderRadius = 7;
            this.btnSalir.ButtonText = "Salir";
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSalir.Font = new System.Drawing.Font("Calisto MT", 14F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSalir.Iconimage = null;
            this.btnSalir.Iconimage_right = null;
            this.btnSalir.Iconimage_right_Selected = null;
            this.btnSalir.Iconimage_Selected = null;
            this.btnSalir.IconMarginLeft = 0;
            this.btnSalir.IconMarginRight = 0;
            this.btnSalir.IconRightVisible = true;
            this.btnSalir.IconRightZoom = 0D;
            this.btnSalir.IconVisible = true;
            this.btnSalir.IconZoom = 30D;
            this.btnSalir.IsTab = false;
            this.btnSalir.Location = new System.Drawing.Point(888, 543);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnSalir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnSalir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSalir.selected = false;
            this.btnSalir.Size = new System.Drawing.Size(116, 45);
            this.btnSalir.TabIndex = 49;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSalir.Textcolor = System.Drawing.Color.White;
            this.btnSalir.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.tablaCajas);
            this.panel2.Location = new System.Drawing.Point(410, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 385);
            this.panel2.TabIndex = 50;
            // 
            // flowContainer
            // 
            this.flowContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.flowContainer.AutoScroll = true;
            this.flowContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowContainer.Location = new System.Drawing.Point(30, 136);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Padding = new System.Windows.Forms.Padding(10);
            this.flowContainer.Size = new System.Drawing.Size(354, 385);
            this.flowContainer.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(27, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "Turnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(405, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "Cajas";
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 601);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnTurnos);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.btnAbrirCaja);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCaja";
            this.Text = "frmCaja";
            this.Load += new System.EventHandler(this.frmCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCajas)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtTodas;
        private System.Windows.Forms.RadioButton rbtCerrado;
        private System.Windows.Forms.RadioButton rbtAbierto;
        private Bunifu.Framework.UI.BunifuFlatButton btnBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private Bunifu.Framework.UI.BunifuFlatButton btnAbrirCaja;
        private Bunifu.Framework.UI.BunifuFlatButton btnCerrarCaja;
        private Bunifu.Framework.UI.BunifuFlatButton btnTurnos;
        private Bunifu.Framework.UI.BunifuFlatButton btnImprimir;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tablaCajas;
        private Bunifu.Framework.UI.BunifuFlatButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.FlowLayoutPanel flowContainer;
    }
}