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
    public partial class frmAperturaTurno : Form
    {
        public frmAperturaTurno()
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

        E_CUADRE_TURNO objE_CuadreTurno = new E_CUADRE_TURNO();
        N_CUADRE_TURNO objN_CuadreTurno = new N_CUADRE_TURNO();
        N_CUADRE_CAJA objNcuadre_caja = new N_CUADRE_CAJA();
        N_TURNO objTurnos = new N_TURNO();
        int idTurno = 0;
        int id_cuadrecaja = 0;
        double saldo = 0;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAperturaTurno_Load(object sender, EventArgs e)
        {
            MostrarTurno();
        }

        //Metodos
        void MostrarTurno()
        {
            DataTable Datos = objTurnos.MostrarTurnos();
            if (Datos.Rows.Count > 0)
            {
                foreach (DataRow item in Datos.Rows)
                {
                    idTurno = Convert.ToInt32(item[0]);
                    lblTurno.Text = item[2].ToString();
                    lblFecha.Text = DateTime.Now.ToString();
                }
            }
            else
            {
                frmAlerta form = new frmAlerta("No hay turnos para abrir este dia, favor ponerse en contacto con administrador",frmAlerta.Alerta.Error);
                form.ShowDialog();
                this.Close();
            }
           
        }

        void AbrirTurno(int idturno, double saldo, int id_usuario,int id_cuadre_caja)
        {
            try
            {
                objE_CuadreTurno.Id_Turno = idturno;
                objE_CuadreTurno.Saldo_Inicial = saldo;
                objE_CuadreTurno.Id_Usuario = id_usuario;
                objE_CuadreTurno.Id_cuadre_caja = id_cuadre_caja;

                objN_CuadreTurno.AbrirTurno(objE_CuadreTurno);
                this.Close();

            }
            catch (Exception ex)
            {

                frmAlerta form = new frmAlerta(ex.Message, frmAlerta.Alerta.Error);
                form.ShowDialog();
            }
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtSaldo.Text == string.Empty)                
                    saldo = 0;
                
                else
                {
                    saldo = Convert.ToDouble(txtSaldo.Text);
                    id_cuadrecaja = objNcuadre_caja.Id_CajaAbierta();
                    if (id_cuadrecaja != 0)
                        AbrirTurno(idTurno, saldo, DatosUsuario.Id_usuario, id_cuadrecaja);
                    else
                    {
                        frmAlerta form = new frmAlerta("Se debe abrir la caja antes que el turno", frmAlerta.Alerta.Error);
                        form.ShowDialog();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                frmAlerta form = new frmAlerta("El saldo es incorrecto", frmAlerta.Alerta.Error);
                form.ShowDialog();

            }
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return;
            }
        }
    }
}
