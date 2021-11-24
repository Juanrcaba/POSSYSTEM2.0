using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class PagePrincipal : Form
    {
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
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
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
        }

        private void btnGanancia_Click(object sender, EventArgs e)
        {
            SeleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
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
    }
}
