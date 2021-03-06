using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;
using CapaPresentacion.Clientes;

namespace CapaPresentacion
{
    public partial class PagePrincipal : Form
    {

        public int _Image = DatosUsuario.sexo - 1;
        public string _Usuario;
        E_USUARIO objUsuario = new E_USUARIO();
        public PagePrincipal()
        {
            InitializeComponent();
        }
       
        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void PagePrincipal_Load(object sender, EventArgs e)
        {
            pantallaOK();
            if(_Image == 1)
                LogoPic.Image = Properties.Resources.user_female;
            else
                LogoPic.Image = Properties.Resources.user_male;
            LogoPic.SizeMode = PictureBoxSizeMode.Zoom;
            lblUsuario.Text = DatosUsuario.Nombre;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmAcceso form = new frmAcceso();
            form.Show();
            this.Hide();
        }

        void SeleccionarBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnDashboard.Textcolor = Color.White;
            btnProducto.Textcolor = Color.White;
            btnVentas.Textcolor = Color.White;
            btnProveedor.Textcolor = Color.White;
            btnCompras.Textcolor = Color.White;
            btnGanancia.Textcolor = Color.White;
            btnTrabajador.Textcolor = Color.White;
            btnClientes.Textcolor = Color.White;

            sender.selected = true;

            if (sender.selected)
                sender.Textcolor = Color.FromArgb(21, 222, 105);

            lblTitulo.Text = sender.Text;
        }

        private void PnlReport(bool valor)
        {
          
            if (valor)
            {
                if(pnlReportes.Height == 96)
                    pnlReportes.Height = 0;
                else
                    pnlReportes.Height = 96;
            }               
            else
                pnlReportes.Height = 0;

            pnlReportes.Visible = valor;
            AnimationPnlRpt.ShowSync(pnlReportes);
            

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            PnlReport(false);

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            PnlReport(false);
            OpenForm(new frmProductos());
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);           
            frmMesas form = new frmMesas();
            form.Show();
            this.Hide();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            PnlReport(false);
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            PnlReport(false);
            frmUsuarios form = new frmUsuarios();
            form.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            OpenForm(new frmViewClientes());
            PnlReport(false);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            OpenForm(new frmViewProveedores());
            PnlReport(false);
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            //SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            PnlReport(true);
        }

        private Form ActiveForm = null;

        private void OpenForm(Form form)
        {

            if (ActiveForm != null)
            {
                if (ActiveForm.Name != form.Name)
                {
                    ActiveForm.Close();
                    ActiveForm = form;
                    form.TopLevel = false;
                    form.Dock = DockStyle.Fill;
                    container.Controls.Add(form);
                    container.Tag = form;
                    form.BringToFront();
                    form.Show();
                }
            }
            else
            {
                ActiveForm = form;
                form.TopLevel = false;
                form.Dock = DockStyle.Fill;
                container.Controls.Add(form);
                container.Tag = form;
                form.BringToFront();
                form.Show();
            }
        }

        private void picMenu_Click(object sender, EventArgs e)
        {
            if (sidebar.Visible)
            {              
                sidebar.Visible = false;
            }
            else
            {
                sidebar.Visible = true;             
            }
               
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnVentasActivas_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            OpenForm(new frmReportes());
        }
    }
}
