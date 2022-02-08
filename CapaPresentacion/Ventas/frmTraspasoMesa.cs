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
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmTraspasoMesa : Form
    {
        public frmTraspasoMesa()
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

        N_MESAS oNmesas = new N_MESAS();
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTraspasoMesa_Load(object sender, EventArgs e)
        {
            LlenarCombobox(cmbDesde);
            LlenarCombobox(cmbHasta);
        }

        private void LlenarCombobox(ComboBox combo)
        {
            DataTable Dt = oNmesas.MostrarMesas();

            combo.ValueMember = "ID_MESA";
            combo.DisplayMember = "NOMBRE";
            DataRow TopItem = Dt.NewRow();
            TopItem[0] = 0;
            TopItem[1] = "-Select-";
            Dt.Rows.InsertAt(TopItem, 0);
            combo.DataSource = Dt;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int Iddesde = Int32.Parse(cmbDesde.SelectedValue.ToString());
            int Idhasta = Int32.Parse(cmbHasta.SelectedValue.ToString());

            try
            {
                if(Iddesde != 0 && Idhasta != 0)
                GenerarTraspaso(Iddesde,Idhasta);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void GenerarTraspaso(int _IdDesde, int _IdHasta)
        {
            try
            {
                if (_IdDesde != _IdHasta)
                {
                    oNmesas.TraspasoMesa(_IdDesde,_IdHasta);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                frmAlerta alerta = new frmAlerta(ex.Message,frmAlerta.Alerta.Error);
                alerta.ShowDialog();                
            }
        }
    }
}
