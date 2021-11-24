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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }

        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            pantallaOK();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMesas form = new frmMesas();
            form.Show();
            this.Hide();
        }
    }
}
