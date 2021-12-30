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
    public partial class frmAperturaCaja : Form
    {

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


        E_CUADRE_CAJA objE_CuadreCaja = new E_CUADRE_CAJA();
        N_CUADRE_CAJA objN_Cuadrecaja = new N_CUADRE_CAJA();
        N_CAJAS objN_Cajas = new N_CAJAS();
        frmAlerta form;
        int Idcaja = 0;
        double saldo = 0;
        public frmAperturaCaja()
        {
            m_aeroEnabled = false;            
            InitializeComponent();
            
        }

        private void frmAperturaCaja_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
            CargarCajas();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();          
         
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.TryParse(cmbCajas.SelectedValue.ToString(), out Idcaja))                    
                    if (double.TryParse(txtSaldo.Text, out saldo))
                        AbrirCaja(Idcaja, cmbCajas.Text, saldo, lblFecha.Text);
                    else
                    {
                        frmAlerta form = new frmAlerta("Debe insertar datos numericos en el Saldo inicial",frmAlerta.Alerta.Error);
                        form.ShowDialog();
                        txtSaldo.Focus();
                    }  
            }
            catch (Exception ex)
            {

                frmAlerta form = new frmAlerta("No existe esta caja o el saldo es incorrecto", frmAlerta.Alerta.Error);
                form.ShowDialog();

            }

        }

        //metodos
        void AbrirCaja(int idCaja,string nCaja,double saldoCaja,string fecha)
        {
            try
            {
                objE_CuadreCaja.Id_caja = idCaja;
                objE_CuadreCaja.Saldo_apertura = saldoCaja;
                objE_CuadreCaja.Fecha = fecha;
                int resultado = objN_Cuadrecaja.AbrirCajas(objE_CuadreCaja);
                if ( resultado == 0)
                {
                    form = new frmAlerta("Caja #" + nCaja + " ya esta cerrada, debe abrir un dia superior", frmAlerta.Alerta.Exitoso);
                    form.ShowDialog();
                }else if (resultado == 1)
                {
                    form = new frmAlerta("La fecha de Apertura es menor a la ultima apertura de caja", frmAlerta.Alerta.Exitoso);
                    form.ShowDialog();
                }
                else
                {
                    form = new frmAlerta("Caja #" + nCaja + " esta abierta", frmAlerta.Alerta.Exitoso);
                    form.ShowDialog();
                }
                
                this.Close();
            }
            catch (Exception)
            {

                frmAlerta form = new frmAlerta("Error al intentar abrir la caja",frmAlerta.Alerta.Error);
                form.ShowDialog();
            }
        }

        private void CargarCajas()
        {
           
            cmbCajas.DataSource = objN_Cajas.MostrarCajas();

            if (cmbCajas.Items.Count > 0)
            {
                cmbCajas.ValueMember = "IDCAJA";
                cmbCajas.DisplayMember = "NOMBRE";
            }
            else
            {
                cmbCajas.DataSource = null;
                cmbCajas.Items.Add("No se encontraron cajas");
            }
        }

      
    }
}
