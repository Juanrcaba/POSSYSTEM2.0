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

namespace CapaPresentacion
{
    public partial class frmControlCategorias : Form
    {

       
        string Nombre_Categoria;
        int Id_Categoria;
       

        public frmControlCategorias(string nombre, int Id)
        {
            InitializeComponent();
            this.Nombre_Categoria = nombre;
            this.Id_Categoria = Id;
        }

        N_PRODUCTO objProducto = new N_PRODUCTO();
        frmAlerta formAlerta;

        private void frmControlCategorias_Load(object sender, EventArgs e)
        {
            lblCategoria.Text = Nombre_Categoria;
        }

        private void frmControlCategorias_Click(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            DataTable Dt = objProducto.BuscarProdutoCategoria(Id_Categoria);
            frmComanda formComanda = Owner as frmComanda;

            if (Dt != null)
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow item in Dt.Rows)
                    {
                        
                        frmControlProductos btn = new frmControlProductos(Convert.ToInt32(item["IDPRODUCTO"]),Convert.ToDouble(item["PRECIO_VENTA"]),item["PRODUCTO"].ToString());
                        //AddOwnedForm(btn);
                        formComanda.AddOwnedForm(btn);
                        btn.TopLevel = false;
                        formComanda.btnGrupos.Enabled = true;
                        formComanda.flowContainer.Controls.Clear();
                        formComanda.flowContainer.Controls.Add(btn);
                        btn.Show();
                    }
                }
                else
                {
                    formAlerta = new frmAlerta("No existen Productos", frmAlerta.Alerta.Información);
                    formAlerta.ShowDialog();
                    formAlerta.Dispose();
                }


        }
    }
}
