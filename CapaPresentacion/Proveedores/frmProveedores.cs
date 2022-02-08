using CapaEntidades;
using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class frmProveedores : Form
    {
        public frmProveedores()
        {
            InitializeComponent();
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
        public int IdProveedor = 0;
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarProveedores();
        }

        private void GuardarProveedores()
        {
            E_PROVEEDORES entidadProveedores = new E_PROVEEDORES();
            N_PROVEEDORES objProveedores = new N_PROVEEDORES();
            frmAlerta alerta;

            if (txtRazon.Text != string.Empty)
            {
                if (cmbTipoDoc.Text != "Seleccionar")
                {
                    if (txtNoDoc.Text != string.Empty)
                    {
                        entidadProveedores.Idproveedor = IdProveedor;
                        entidadProveedores.RazonSocial = txtRazon.Text.Trim();
                        entidadProveedores.TipoDocumento = cmbTipoDoc.Text.Trim();
                        entidadProveedores.NoDocumento = txtNoDoc.Text.Trim();
                        entidadProveedores.Direccion = txtDireccion.Text.Trim();
                        entidadProveedores.Telefono = txtTelefono.Text.Trim();
                        entidadProveedores.Email = txtEmail.Text.Trim();

                        if (IsUpdate)
                        {                            
                            objProveedores.EditarProveedor(entidadProveedores);
                            IsUpdate = false;
                            alerta = new frmAlerta("El producto se Actualizo Correctamente", frmAlerta.Alerta.Exitoso);
                            alerta.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            objProveedores.InsertarProveedor(entidadProveedores);
                            Limpiar();
                            this.DialogResult = DialogResult.OK;
                            //alerta = new frmAlerta("El proveedor se guardo Correctamente", frmAlerta.Alerta.Exitoso);
                            //alerta.ShowDialog();
                            
                        }
                    }
                    else
                    {
                        alerta = new frmAlerta("Debe introducir No. documento", frmAlerta.Alerta.Error);
                        alerta.ShowDialog();
                        txtNoDoc.Focus();
                    }


                }
                else
                {
                    alerta = new frmAlerta("Debe seleccionar tipo de documento", frmAlerta.Alerta.Error);
                    alerta.ShowDialog();
                    cmbTipoDoc.Focus();
                }
            }
            else
            {
                alerta = new frmAlerta("El proveedor debe tener un nombre de razon social", frmAlerta.Alerta.Error);
                alerta.ShowDialog();
                txtRazon.Focus();
            }

        }

        void Limpiar()
        {
            IdProveedor = 0;
            txtRazon.Clear();
            cmbTipoDoc.SelectedItem =0;
            txtNoDoc.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            cmbTipoDoc.SelectedIndex = 0;
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            cmbTipoDoc.SelectedIndex = 0;
        }
    }
}
