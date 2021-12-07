
namespace CapaPresentacion
{
    partial class frmComanda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnMesas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnGrupos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnFacturar = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblMesa = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablaProductos = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.lblMesa);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1254, 87);
            this.panel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel11, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel12, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(563, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(691, 87);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnMesas);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(8, 8);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(221, 71);
            this.panel10.TabIndex = 0;
            // 
            // btnMesas
            // 
            this.btnMesas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMesas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMesas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMesas.BorderRadius = 7;
            this.btnMesas.ButtonText = "Mesas";
            this.btnMesas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMesas.DisabledColor = System.Drawing.Color.Gray;
            this.btnMesas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMesas.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnMesas.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMesas.Iconimage = null;
            this.btnMesas.Iconimage_right = null;
            this.btnMesas.Iconimage_right_Selected = null;
            this.btnMesas.Iconimage_Selected = null;
            this.btnMesas.IconMarginLeft = 0;
            this.btnMesas.IconMarginRight = 0;
            this.btnMesas.IconRightVisible = true;
            this.btnMesas.IconRightZoom = 0D;
            this.btnMesas.IconVisible = true;
            this.btnMesas.IconZoom = 30D;
            this.btnMesas.IsTab = false;
            this.btnMesas.Location = new System.Drawing.Point(0, 0);
            this.btnMesas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnMesas.Name = "btnMesas";
            this.btnMesas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnMesas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnMesas.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMesas.selected = false;
            this.btnMesas.Size = new System.Drawing.Size(221, 71);
            this.btnMesas.TabIndex = 37;
            this.btnMesas.TabStop = false;
            this.btnMesas.Text = "Mesas";
            this.btnMesas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMesas.Textcolor = System.Drawing.Color.White;
            this.btnMesas.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnMesas.Click += new System.EventHandler(this.btnMesas_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.btnGrupos);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(235, 8);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(221, 71);
            this.panel11.TabIndex = 1;
            // 
            // btnGrupos
            // 
            this.btnGrupos.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGrupos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGrupos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGrupos.BorderRadius = 7;
            this.btnGrupos.ButtonText = "Grupos";
            this.btnGrupos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrupos.DisabledColor = System.Drawing.Color.Gray;
            this.btnGrupos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrupos.Enabled = false;
            this.btnGrupos.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnGrupos.Iconcolor = System.Drawing.Color.Transparent;
            this.btnGrupos.Iconimage = null;
            this.btnGrupos.Iconimage_right = null;
            this.btnGrupos.Iconimage_right_Selected = null;
            this.btnGrupos.Iconimage_Selected = null;
            this.btnGrupos.IconMarginLeft = 0;
            this.btnGrupos.IconMarginRight = 0;
            this.btnGrupos.IconRightVisible = true;
            this.btnGrupos.IconRightZoom = 0D;
            this.btnGrupos.IconVisible = true;
            this.btnGrupos.IconZoom = 30D;
            this.btnGrupos.IsTab = false;
            this.btnGrupos.Location = new System.Drawing.Point(0, 0);
            this.btnGrupos.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnGrupos.Name = "btnGrupos";
            this.btnGrupos.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnGrupos.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnGrupos.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGrupos.selected = false;
            this.btnGrupos.Size = new System.Drawing.Size(221, 71);
            this.btnGrupos.TabIndex = 40;
            this.btnGrupos.TabStop = false;
            this.btnGrupos.Text = "Grupos";
            this.btnGrupos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGrupos.Textcolor = System.Drawing.Color.White;
            this.btnGrupos.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            this.btnGrupos.Click += new System.EventHandler(this.btnGrupos_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnFacturar);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(462, 8);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(221, 71);
            this.panel12.TabIndex = 2;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFacturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFacturar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFacturar.BorderRadius = 7;
            this.btnFacturar.ButtonText = "Facturar";
            this.btnFacturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFacturar.DisabledColor = System.Drawing.Color.Gray;
            this.btnFacturar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFacturar.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.btnFacturar.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFacturar.Iconimage = null;
            this.btnFacturar.Iconimage_right = null;
            this.btnFacturar.Iconimage_right_Selected = null;
            this.btnFacturar.Iconimage_Selected = null;
            this.btnFacturar.IconMarginLeft = 0;
            this.btnFacturar.IconMarginRight = 0;
            this.btnFacturar.IconRightVisible = true;
            this.btnFacturar.IconRightZoom = 0D;
            this.btnFacturar.IconVisible = true;
            this.btnFacturar.IconZoom = 30D;
            this.btnFacturar.IsTab = false;
            this.btnFacturar.Location = new System.Drawing.Point(0, 0);
            this.btnFacturar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btnFacturar.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.btnFacturar.OnHoverTextColor = System.Drawing.Color.White;
            this.btnFacturar.selected = false;
            this.btnFacturar.Size = new System.Drawing.Size(221, 71);
            this.btnFacturar.TabIndex = 39;
            this.btnFacturar.TabStop = false;
            this.btnFacturar.Text = "Facturar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFacturar.Textcolor = System.Drawing.Color.White;
            this.btnFacturar.TextFont = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Bold);
            // 
            // lblMesa
            // 
            this.lblMesa.AutoSize = true;
            this.lblMesa.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.lblMesa.Location = new System.Drawing.Point(125, 53);
            this.lblMesa.Name = "lblMesa";
            this.lblMesa.Size = new System.Drawing.Size(111, 25);
            this.lblMesa.TabIndex = 42;
            this.lblMesa.Text = "Mesas # 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logoBar;
            this.pictureBox1.Location = new System.Drawing.Point(40, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tablaProductos
            // 
            this.tablaProductos.AllowUserToAddRows = false;
            this.tablaProductos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tablaProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaProductos.BackgroundColor = System.Drawing.Color.White;
            this.tablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.Producto,
            this.Cantidad,
            this.Precio,
            this.Total});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablaProductos.DefaultCellStyle = dataGridViewCellStyle3;
            this.tablaProductos.DoubleBuffered = true;
            this.tablaProductos.EnableHeadersVisualStyles = false;
            this.tablaProductos.GridColor = System.Drawing.Color.White;
            this.tablaProductos.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(166)))), ((int)(((byte)(221)))));
            this.tablaProductos.HeaderForeColor = System.Drawing.Color.Black;
            this.tablaProductos.Location = new System.Drawing.Point(40, 105);
            this.tablaProductos.MultiSelect = false;
            this.tablaProductos.Name = "tablaProductos";
            this.tablaProductos.ReadOnly = true;
            this.tablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaProductos.RowHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tablaProductos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tablaProductos.Size = new System.Drawing.Size(424, 263);
            this.tablaProductos.TabIndex = 38;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // Producto
            // 
            this.Producto.FillWeight = 163.0707F;
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            this.Producto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 58.51381F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.FillWeight = 76.89267F;
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.FillWeight = 101.5228F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(40, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 354);
            this.panel2.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(35, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Total: ";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowContainer);
            this.panel3.Location = new System.Drawing.Point(565, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(677, 658);
            this.panel3.TabIndex = 40;
            // 
            // flowContainer
            // 
            this.flowContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowContainer.Location = new System.Drawing.Point(0, 0);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Padding = new System.Windows.Forms.Padding(30, 20, 30, 10);
            this.flowContainer.Size = new System.Drawing.Size(675, 656);
            this.flowContainer.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calisto MT", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(120, 381);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(94, 25);
            this.lblTotal.TabIndex = 42;
            this.lblTotal.Text = "1,000.00";
            // 
            // frmComanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1254, 775);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tablaProductos);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmComanda";
            this.Text = "frmComanda";
            this.Load += new System.EventHandler(this.frmComanda_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuFlatButton btnMesas;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private Bunifu.Framework.UI.BunifuFlatButton btnFacturar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Label lblMesa;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.FlowLayoutPanel flowContainer;
        public Bunifu.Framework.UI.BunifuFlatButton btnGrupos;
        public Bunifu.Framework.UI.BunifuCustomDataGrid tablaProductos;
    }
}