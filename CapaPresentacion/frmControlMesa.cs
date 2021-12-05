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
    public partial class frmControlMesa : Form
    {
        public int id_mesa = 0;       
        public string Nombre_Mesa = "";
        

        public frmControlMesa(int id,string nombre_mesa,string Saldo)
        {
            InitializeComponent();
            this.lblMesa.Text = nombre_mesa;
            this.id_mesa = id;
            this.lblTotal.Text = Saldo; //ToString("#,###.###")
        }
        public frmControlMesa()
        {
            InitializeComponent();
          
        }


        private void frmControlMesa_Click(object sender, EventArgs e)
        {
            frmMesas formMesas = Owner as frmMesas;
            frmComanda form = new frmComanda();
            form.lblMesa.Text = this.lblMesa.Text;

            form.Show();
            formMesas.Hide();
        }

        private void frmControlMesa_Load(object sender, EventArgs e)
        {

        }
    }
}
