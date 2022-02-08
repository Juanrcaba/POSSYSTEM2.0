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
        public int id_turno = 0;
        

        public frmControlMesa(int id,string nombre_mesa,double Saldo,int idturno)
        {
            InitializeComponent();
            this.lblMesa.Text = nombre_mesa;
            this.id_mesa = id;
            this.id_turno = idturno;
            this.lblTotal.Text =  String.Format("{0:C2}",Saldo);
            //Saldo.ToString("#,###.##");
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
            form.idmesa = id_mesa;
            form.Idturno = id_turno;
            form.Show();
            formMesas.Hide();
        }

        private void frmControlMesa_Load(object sender, EventArgs e)
        {

        }
    }
}
