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
    public partial class frmControlProductos : Form
    {

        private int Id_Producto;
        private double Precio_producto;
        private string Nombre_producto;

        public frmControlProductos(int id,double precio,string nombre)
        {
            this.Id_Producto = id;
            this.Precio_producto = precio;
            this.Nombre_producto = nombre;
            InitializeComponent();
        }

        

        private void frmControlProductos_Load(object sender, EventArgs e)
        {
                       
                string[] partes = Nombre_producto.Split(' ');
                foreach (string item in partes)
                {
                    lblProducto.Text += item + "\n";
                }
         
            
        }

        private void frmControlProductos_Click(object sender, EventArgs e)
        {
            frmComanda formComanda = Owner as frmComanda;

            formComanda.AgregarArticulo(Id_Producto,Precio_producto,Nombre_producto);
            formComanda.CalcularComanda();
        }
    }
}
