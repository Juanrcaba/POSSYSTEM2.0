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
    public partial class frmMarca : Form
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
        public frmMarca()
        {
            m_aeroEnabled = false;
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            MostrarBuscarDatos(txtBuscar.Text);
            Componentes(false);
        }

        #region Metodos
        E_MARCA EntidadMarca = new E_MARCA();
        N_MARCA NegocioMarca = new N_MARCA();
        public void MostrarBuscarDatos(string buscar)
        {
            N_MARCA marca = new N_MARCA();
            tablaCategoria.DataSource = marca.MostrarMarca(buscar);
            AccionTabla();

        }

        void AccionTabla()
        {
            tablaCategoria.Columns[0].Visible = false;
            tablaCategoria.ClearSelection();
            tablaCategoria.Columns[1].Width = 60;
            tablaCategoria.Columns[2].Width = 170;
        }

        public void InsertarDatos()
        {
            //E_MARCA EntidadMarca = new E_MARCA();
            //N_MARCA NegocioMarca = new N_MARCA();


            EntidadMarca.Nombre = txtNombre.Text;
            EntidadMarca.Descripcion = txtDescripcion.Text;

            NegocioMarca.InsertarMarca(EntidadMarca);

        }

        public void ActualizarDatos()
        {
            //E_CATEGORIA EntidadMarca = new E_CATEGORIA();
            //N_CATEGORIA NegocioCategoria = new N_CATEGORIA();

            EntidadMarca.Idmarca = Convert.ToInt32(txtCodigo.Text.Substring(2).Trim());
            EntidadMarca.Nombre = txtNombre.Text;
            EntidadMarca.Descripcion = txtDescripcion.Text;

            NegocioMarca.EditarMarca(EntidadMarca);
        }

        public void Componentes(bool estado)
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = estado;
            txtDescripcion.Enabled = estado;
            btnGuardar.Enabled = estado;
        }

        public void LimpiarComponentes()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }

        #endregion

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarDatos(txtBuscar.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Componentes(true);
            LimpiarComponentes();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaCategoria.SelectedRows.Count > 0)
            {
                txtCodigo.Text = tablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = tablaCategoria.CurrentRow.Cells[2].Value.ToString();
                txtDescripcion.Text = tablaCategoria.CurrentRow.Cells[3].Value.ToString();

                Componentes(true);
                txtNombre.Focus();
            }
            else
            {
                frmAlerta alerta = new frmAlerta("Debes seleccionar una Marca.", frmAlerta.Alerta.Información);
                alerta.ShowDialog();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != string.Empty)
                {
                    if (txtCodigo.Text != string.Empty)
                        ActualizarDatos();
                    else
                        InsertarDatos();

                    LimpiarComponentes();
                    Componentes(false);
                    MostrarBuscarDatos(txtBuscar.Text);
                    frmAlerta alerta = new frmAlerta("Datos insertados satisfactoriamente!", frmAlerta.Alerta.Exitoso);
                    alerta.ShowDialog();
                }
                else
                {
                    frmAlerta alerta = new frmAlerta("Nombre debe ser insertado", frmAlerta.Alerta.Información);
                    alerta.ShowDialog();
                }
            }
            catch (Exception)
            {

                frmAlerta alerta = new frmAlerta("Error al tratar de insertar los datos", frmAlerta.Alerta.Error);
                alerta.ShowDialog();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
