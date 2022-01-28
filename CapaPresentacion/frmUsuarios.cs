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

using Microsoft.Office.Interop;
using Excel = Microsoft.Office.Interop.Excel;

namespace CapaPresentacion
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            m_aeroEnabled = false;
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

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        E_USUARIO EntidadUsuario = new E_USUARIO();
        N_USUARIO NegocioUsuario = new N_USUARIO();
        frmAlerta alerta;

        private int _idUsuario = 0;
        public void MostrarBuscarDatos(string buscar)
        {
            EntidadUsuario.BUSCAR = buscar;
            tablaUsuarios.DataSource = NegocioUsuario.MostrarUsuario(EntidadUsuario);
            AccionTabla();
        }

        void AccionTabla()
        {
            tablaUsuarios.Columns[0].Visible = false;          
            tablaUsuarios.Columns[1].Width = 40;
            tablaUsuarios.Columns[2].Width = 70;
            tablaUsuarios.Columns[3].Width = 50;
           
            tablaUsuarios.Columns[4].Visible = false;
            tablaUsuarios.Columns[5].Visible = false;        
            tablaUsuarios.Columns[7].Visible = false;
       
            tablaUsuarios.ClearSelection();
        }

        public void InsertarDatos()
        {
            EntidadUsuario.NOMBRE = txtNombre.Text;
            EntidadUsuario.USUARIO = txtUsuario.Text;
            EntidadUsuario.CONTRASEÑA = txtCon.Text;
            EntidadUsuario.PERFIL = Convert.ToInt32(cmbPerfil.SelectedValue);
            if (rbHombre.Checked)
                EntidadUsuario.SEXO = 1;
            else
                EntidadUsuario.SEXO = 2;

            NegocioUsuario.InsertarDatos(EntidadUsuario);

        }

        public void ActualizarDatos()
        {
            EntidadUsuario.ID_USUARIO = _idUsuario;
            EntidadUsuario.NOMBRE = txtNombre.Text;
            EntidadUsuario.USUARIO = txtUsuario.Text;
            EntidadUsuario.CONTRASEÑA = txtCon.Text;
            EntidadUsuario.PERFIL = Convert.ToInt32(cmbPerfil.SelectedValue);
            if (rbHombre.Checked)
                EntidadUsuario.SEXO = 1;
            else
                EntidadUsuario.SEXO = 2;

            NegocioUsuario.EditarDatos(EntidadUsuario);
            
        }

        public void Componentes(bool estado)
        {
            txtUsuario.Enabled = estado;
            txtNombre.Enabled = estado;
            txtCon.Enabled = estado;
            cmbPerfil.Enabled = estado;
            rbHombre.Enabled = estado;
            rbMujer.Enabled = estado;
            btnGuardar.Enabled = estado;
        }

        public void LimpiarComponentes()
        {
            txtUsuario.Clear();
            txtNombre.Clear();
            txtCon.Clear();
            cmbPerfil.SelectedIndex = 0;
            rbHombre.Checked = true;
            _idUsuario = 0;

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Componentes(true);
            LimpiarComponentes();
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tablaUsuarios.SelectedRows.Count > 0)
            {
                _idUsuario = Convert.ToInt32(tablaUsuarios.CurrentRow.Cells[0].Value);
                txtNombre.Text = tablaUsuarios.CurrentRow.Cells[2].Value.ToString();
                txtUsuario.Text = tablaUsuarios.CurrentRow.Cells[3].Value.ToString();
                txtCon.Text = tablaUsuarios.CurrentRow.Cells[4].Value.ToString();
                cmbPerfil.SelectedValue = Convert.ToInt32(tablaUsuarios.CurrentRow.Cells[5].Value);
                int sexo = Convert.ToInt32(tablaUsuarios.CurrentRow.Cells[7].Value);
                if (sexo == 1)
                    rbHombre.Checked = true;
                else
                    rbMujer.Checked = true;
               
                Componentes(true);
                txtNombre.Focus();
            }
            else
            {
                frmAlerta alerta = new frmAlerta("Debes seleccionar una Marca.", frmAlerta.Alerta.Información);
                alerta.ShowDialog();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNombre.Text != string.Empty)
                {
                    if(Convert.ToInt32(cmbPerfil.SelectedValue) > 0)
                    {
                        if (_idUsuario > 0)
                            ActualizarDatos();
                        else
                            InsertarDatos();
                    }
                    else
                    {
                        alerta = new frmAlerta("Debe seleccionar un perfil!", frmAlerta.Alerta.Información);
                        alerta.ShowDialog();
                        return;
                    }
                   

                    LimpiarComponentes();
                    Componentes(false);
                    MostrarBuscarDatos(txtBuscar.Text);
                    alerta = new frmAlerta("Datos insertados satisfactoriamente!", frmAlerta.Alerta.Exitoso);
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarDatos(txtBuscar.Text.Trim());
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            MostrarBuscarDatos("");
            LlenarCombobox();
            Componentes(false);
        }

        private void LlenarCombobox()
        {
            DataTable Dt = NegocioUsuario.MostrarPerfiles();

            cmbPerfil.ValueMember = "IDPERFIL";
            cmbPerfil.DisplayMember = "NPERFIL";
            DataRow TopItem = Dt.NewRow();
            TopItem[0] = 0;
            TopItem[1] = "-Select-";
            Dt.Rows.InsertAt(TopItem,0);
            cmbPerfil.DataSource = Dt;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if(tablaUsuarios.Rows.Count > 0)
            ExportarDatosExcel(tablaUsuarios);
        }

        private void ExportarDatosExcel(DataGridView datalistado)
        {

            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Open(Application.StartupPath + "\\Reports\\Plantilla_reporte_usuario.xlsx");
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets[1];
            worksheet.Name = "Usuario";

            worksheet.Cells[3, 5] = DateTime.Today.ToString("dd-MM-yyyy");


            int countCol = 1;
            int positionCol = 2;
            int positionRow = 7;
            foreach (DataGridViewRow row in datalistado.Rows)
            {

                foreach (DataGridViewColumn column in datalistado.Columns)
                {
                    if (countCol > 1 &&  countCol != 5 && countCol != 6 && countCol != 8)
                    {
                        worksheet.Cells[positionRow, positionCol] = row.Cells[column.Name].Value;
                        worksheet.Cells[positionRow, positionCol].Borders[Excel.XlBordersIndex.xlEdgeLeft].Weight = 2d;
                        worksheet.Cells[positionRow, positionCol].Borders[Excel.XlBordersIndex.xlEdgeTop].Weight = 2d;
                        worksheet.Cells[positionRow, positionCol].Borders[Excel.XlBordersIndex.xlEdgeRight].Weight = 2d;
                        worksheet.Cells[positionRow, positionCol].Borders[Excel.XlBordersIndex.xlEdgeBottom].Weight = 2d;
                        positionCol++;
                    }
                    countCol++;
                }
                positionRow++;
                positionCol = 2;
                countCol = 1;
            }

            //Columns("H:H").EntireColumn.AutoFit


            worksheet.Columns.AutoFit();
            saveFileDialog.Filter = "Libro de Excel|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.FileName = "Listado Usuario";



            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs("Listado Usuario");
                app.Visible = true;
            }


        }
    }
}
