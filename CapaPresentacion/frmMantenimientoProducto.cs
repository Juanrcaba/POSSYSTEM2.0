using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMantenimientoProducto : Form
    {
        public frmMantenimientoProducto()
        {
            InitializeComponent();
            CargarCategoria();
            CargarMarca();
        }

        #region Shadow
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
    (
        int nLeftRect, // x-coordinate of upper-left corner
        int nTopRect, // y-coordinate of upper-left corner
        int nRightRect, // x-coordinate of lower-right corner
        int nBottomRect, // y-coordinate of lower-right corner
        int nWidthEllipse, // height of ellipse
        int nHeightEllipse // width of ellipse
     );

        [DllImport("dwmapi.dll")]
        public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

        [DllImport("dwmapi.dll")]
        public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

        [DllImport("dwmapi.dll")]
        public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

        private bool m_aeroEnabled;                     // variables for box shadow
        private const int CS_DROPSHADOW = 0x00020000;
        private const int WM_NCPAINT = 0x0085;
        private const int WM_ACTIVATEAPP = 0x001C;

        public struct MARGINS                           // struct for box shadow
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }

        private const int WM_NCHITTEST = 0x84;          // variables for dragging the form
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        protected override CreateParams CreateParams
        {
            get
            {
                m_aeroEnabled = CheckAeroEnabled();

                CreateParams cp = base.CreateParams;
                if (!m_aeroEnabled)
                    cp.ClassStyle |= CS_DROPSHADOW;

                return cp;
            }
        }

        private bool CheckAeroEnabled()
        {
            if (Environment.OSVersion.Version.Major >= 6)
            {
                int enabled = 0;
                DwmIsCompositionEnabled(ref enabled);
                return (enabled == 1) ? true : false;
            }
            return false;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCPAINT:                        // box shadow
                    if (m_aeroEnabled)
                    {
                        var v = 2;
                        DwmSetWindowAttribute(this.Handle, 2, ref v, 4);
                        MARGINS margins = new MARGINS()
                        {
                            bottomHeight = 1,
                            leftWidth = 0,
                            rightWidth = 0,
                            topHeight = 0
                        };
                        DwmExtendFrameIntoClientArea(this.Handle, ref margins);
                        //controla la sombra
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && (int)m.Result == HTCLIENT)     // drag the form
                m.Result = (IntPtr)HTCAPTION;

        }

        #endregion

        public bool IsUpdate = false;
        public int Idproducto = 0;
        private void CargarCategoria()
        {
            N_CATEGORIA objCategoria = new N_CATEGORIA();
            cmbCategoria.DataSource = objCategoria.MostrarCategoria("");
            cmbCategoria.ValueMember = "IDCATEGORIA";
            cmbCategoria.DisplayMember = "NOMBRE";
        }

        private void CargarMarca()
        {
            N_MARCA objCategoria = new N_MARCA();
            cmbMarca.DataSource = objCategoria.MostrarMarca("");
            cmbMarca.ValueMember = "IDMARCA";
            cmbMarca.DisplayMember = "NOMBRE";
        }

        private void Limpiar()
        {
            txtCodigo.Clear();
            txtPcompra.Clear();
            txtProducto.Clear();
            txtPventa.Clear();
            txtStock.Clear();
            cmbCategoria.SelectedValue = 1;
            cmbMarca.SelectedValue = 1;
            txtProducto.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProducto();
        }

        private void GuardarProducto()
        {
            E_PRODUCTO entidadProducto = new E_PRODUCTO();
            N_PRODUCTO objProducto = new N_PRODUCTO();
            frmAlerta alerta;

            if (txtProducto.Text != string.Empty)
            {
                string nombreProducto = txtProducto.Text;
                double precioCompra = 0.0d;
                double precioVenta = 0.0d;
                double stock = 0.0d;
                int idcategoria = Int32.Parse(cmbCategoria.SelectedValue.ToString());
                int idmarca = Int32.Parse(cmbMarca.SelectedValue.ToString());

                Double.TryParse(txtPcompra.Text, out precioCompra);
                Double.TryParse(txtPventa.Text, out precioVenta);
                Double.TryParse(txtStock.Text, out stock);

                entidadProducto.Idproducto = Idproducto;
                entidadProducto.Producto = nombreProducto.ToUpper();
                entidadProducto.Precio_compra = precioCompra;
                entidadProducto.Precio_venta = precioVenta;
                entidadProducto.Stock = stock;
                entidadProducto.Idcategoria = idcategoria;
                entidadProducto.Idmarca = idmarca;


                if (IsUpdate)
                {
                    objProducto.EditarProducto(entidadProducto);
                    IsUpdate = false;
                    alerta = new frmAlerta("El producto se Actualizo Correctamente", frmAlerta.Alerta.Exitoso);
                    alerta.ShowDialog();
                    this.Close();
                    
                }
                else
                {
                    objProducto.InsertarProducto(entidadProducto);
                    alerta = new frmAlerta("El producto se guardo Correctamente", frmAlerta.Alerta.Exitoso);
                    alerta.ShowDialog();
                    Limpiar();
                }                   

               
                
            }
            else
            {
                alerta = new frmAlerta("El producto debe tener un Nombre",frmAlerta.Alerta.Error);
                alerta.ShowDialog();
                txtProducto.Focus();
            }
                
        }
    }
}
