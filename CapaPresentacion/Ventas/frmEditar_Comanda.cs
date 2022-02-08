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
    public partial class frmEditar_Comanda : Form
    {
        public frmEditar_Comanda()
        {
            InitializeComponent();
        }
        public int _Idproducto = 0;
        public string _NombreProducto = "";
        public string _CantidadProducto = "";
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 32 && e.KeyChar <= 47 || e.KeyChar >= 58 && e.KeyChar <= 255)
            {
                e.Handled = true;
                return;
            }
        }

        private void frmEditar_Comanda_Load(object sender, EventArgs e)
        {
            txtCantidad.Text = _CantidadProducto;
            txtProducto.Text = _NombreProducto;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "0";
            }
            else
            {
                txtCantidad.Text += "0";
            }
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "1";
            }
            else
            {
                txtCantidad.Text += "1";
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "2";
            }
            else
            {
                txtCantidad.Text += "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "3";
            }
            else
            {
                txtCantidad.Text += "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "4";
            }
            else
            {
                txtCantidad.Text += "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "5";
            }
            else
            {
                txtCantidad.Text += "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "6";
            }
            else
            {
                txtCantidad.Text += "6";
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "7";
            }
            else
            {
                txtCantidad.Text += "7";
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "8";
            }
            else
            {
                txtCantidad.Text += "8";
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "0")
            {
                txtCantidad.Text = "9";
            }
            else
            {
                txtCantidad.Text += "9";
            }
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            string toList = txtCantidad.Text.Trim();
            for (int i = 0; i < toList.Length ; i++)
            {
                if (toList[i].ToString() == ".")
                    return;
            }
            if (txtCantidad.Text == "0" || txtCantidad.Text == string.Empty)
            {
                txtCantidad.Text = "0.";
            }
            else
            {
                txtCantidad.Text += ".";
            }
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            frmComanda form = Owner as frmComanda;
            form.cantidadEditada = Convert.ToInt32(txtCantidad.Text);
            this.Close();
        }

    }
}
