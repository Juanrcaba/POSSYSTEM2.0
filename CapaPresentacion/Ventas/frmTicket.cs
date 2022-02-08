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
    public partial class frmTicket : Form
    {
        public frmTicket()
        {
            InitializeComponent();
        }

        E_VENTA e_venta = new E_VENTA();
        N_VENTA oNventa = new N_VENTA(); 
        public string _Comentario = "";


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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            MostrarTickets();
        }

        private void MostrarTickets()
        {                      

            tablaTickets.DataSource = oNventa.MostrarTickets();
            tablaTickets.Columns[0].DisplayIndex = 5;
            tablaTickets.Columns[1].DisplayIndex = 5;
            tablaTickets.ClearSelection();

            tablaTickets.Columns[2].Visible = false;

        }

        private void tablaTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tablaTickets.CurrentRow.Cells["Delete"].Selected)
            {
                int id_venta = Convert.ToInt32(tablaTickets.CurrentRow.Cells[2].Value);
                var formAlert = new frmAlerta("Deseas Cancelar este ticket?", frmAlerta.Alerta.Información);
                if (formAlert.ShowDialog() == DialogResult.OK)
                {
                    var formCancelarTicket = new frmCancelarTicket();
                    AddOwnedForm(formCancelarTicket);
                    formCancelarTicket.ShowDialog();

                    e_venta.Comentario = _Comentario;
                    e_venta.Id_venta = id_venta;

                    oNventa.CancelarTicket(e_venta);
                    MostrarTickets();

                    formCancelarTicket.Dispose();
                }
                formAlert.Dispose();
            } else if (tablaTickets.CurrentRow.Cells["print"].Selected) 
            {
                try
                {
                    int idVenta = Convert.ToInt32(tablaTickets.CurrentRow.Cells[2].Value);

                    DataTable Dt = oNventa.GenerarTicket(idVenta);

                    CreaTicket Ticket = new CreaTicket();
                    string mesa, usuario, fecha, hora;
                    double total = 0;

                    usuario = Dt.Rows[0][0].ToString();
                    mesa = Dt.Rows[0][1].ToString();
                    fecha = Dt.Rows[0][2].ToString();
                    hora = Dt.Rows[0][3].ToString();

                    //Ticket.AbreCajon();  //abre el cajon
                    Ticket.TextoIzquierda(usuario);
                    Ticket.TextoDerecha(mesa);
                    Ticket.TextoCentro("Venta mostrador"); // imprime en el centro "Venta mostrador"
                    Ticket.TextoExtremos("Fecha " +fecha, "Hora: " + hora);
                    Ticket.LineasGuion(); // imprime una linea de guiones
                    Ticket.EncabezadoVenta(); // imprime encabezados 
                    Ticket.TextoCentro("");

                    foreach (DataRow item in Dt.Rows)
                    {
                        Ticket.AgregaArticulo(item[4].ToString(),Convert.ToInt32(item[5]),Convert.ToDouble(item[6]), Convert.ToDouble(item[7])); //imprime una linea de descripcion
                        total += Convert.ToDouble(item[7].ToString());                        
                    }

                    Ticket.LineasTotales(); // imprime linea
                    Ticket.AgregaTotales("Total", total); // imprime linea con total
                    Ticket.TextoCentro("");
                    Ticket.TextoCentro("Bar Santa");
                    Ticket.TextoCentro("Gracias por Preferirnos!!");

                    Ticket.Imprimir();

                    Ticket.CortaTicket(); // corta el ticket

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
