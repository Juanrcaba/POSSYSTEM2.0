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
    public partial class frmComanda : Form
    {
        public frmComanda()
        {
            InitializeComponent();
        }

        frmAlerta formAlerta;
        N_VENTA objVenta = new N_VENTA();
        N_CATEGORIA objCategoria = new N_CATEGORIA();
        E_DETALLE_MESA objE_detalle_mesa = new E_DETALLE_MESA();
        E_VENTA objE_venta = new E_VENTA();
        N_DETALLE_MESA objDetalle_mesa = new N_DETALLE_MESA();


        double calculo = 0;
        public int idmesa = 0;
        public int Idturno = 0;
        private void btnMesas_Click(object sender, EventArgs e)
        {
            VolverAMesa();
        }
        void VolverAMesa()
        {
            frmMesas form = new frmMesas();
            form.Show();
            this.Hide();
        }
        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmComanda_Load(object sender, EventArgs e)
        {
            pantallaOK();
            CargarGrupos();
            CargarComanda();
            tablaProductos.ClearSelection();
        }

        private void CargarGrupos()
        {
            DataTable Dt = objCategoria.MostrarCategoria("");

            flowContainer.Controls.Clear();
            if (Dt != null)
                if (Dt.Rows.Count > 0)
                {
                    foreach (DataRow item in Dt.Rows)
                    {

                        frmControlCategorias btn = new frmControlCategorias(item["NOMBRE"].ToString(),Convert.ToInt32(item["IDCATEGORIA"]));
                        AddOwnedForm(btn);
                        btn.TopLevel = false;
                        flowContainer.Controls.Add(btn);
                        btn.Show();
                    }
                }
                else
                {
                    formAlerta = new frmAlerta("No existen cateforias", frmAlerta.Alerta.Información);
                    formAlerta.ShowDialog();
                    formAlerta.Dispose();
                }


        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {
            CargarGrupos();
          
            btnGrupos.Enabled = false;
        }

        public void AgregarArticulo(int id_producto,double precio,string nombre)
        {
            if (tablaProductos.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in tablaProductos.Rows)
                {
                    if (Convert.ToInt32(item.Cells["idProducto"].Value) == id_producto)
                    {
                        item.Cells["Cantidad"].Value = Convert.ToInt32(item.Cells["Cantidad"].Value) + 1;
                        item.Cells["Total"].Value = Convert.ToInt32(item.Cells["Cantidad"].Value) * precio;
                        //update tabla en la base de datos
                        objE_detalle_mesa.Id_mesa = idmesa;
                        objE_detalle_mesa.Id_producto = id_producto;
                        objE_detalle_mesa.Cantidad = Convert.ToInt32(item.Cells["Cantidad"].Value);
                        objE_detalle_mesa.Total = Convert.ToDouble(item.Cells["Total"].Value);
                        objDetalle_mesa.EditarDetalleMesa(objE_detalle_mesa);
                        return;
                    }
                    
                }
                tablaProductos.Rows.Add(id_producto, nombre, 1, precio, (1 * precio));
                //insert en la base de datos
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = id_producto;              
                objE_detalle_mesa.Precio = precio;
                
                objDetalle_mesa.InsertarDetalleMesa(objE_detalle_mesa);
            }
            else
            {
                tablaProductos.Rows.Add(id_producto, nombre, 1, precio, (1 * precio));
                //insert en la base de datos
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = id_producto;
                objE_detalle_mesa.Precio = precio;

                objDetalle_mesa.InsertarDetalleMesa(objE_detalle_mesa);

            }        

           
        }
        private void CargarComanda()
        {
            objE_detalle_mesa.Id_mesa = idmesa;
            DataTable Dt = objDetalle_mesa.MostrarDetalleMesa(objE_detalle_mesa);
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow item in Dt.Rows)
                {
                    tablaProductos.Rows.Add(item["ID_PRODUCTO"], item["NOMBRE"], item["CANTIDAD"],item["PRECIO"], item["TOTAL"]);
                }

                CalcularComanda();
            }
            
        }

        public void CalcularComanda()
        {
            calculo = 0.00d;
            foreach (DataGridViewRow item in tablaProductos.Rows)
            {
                calculo += Convert.ToDouble(item.Cells["Total"].Value);
            }

            lblTotal.Text = calculo.ToString("#,###.###");
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.Rows.Count > 0)
            {
                DataTable dt = new DataTable();


                dt.Columns.Add("Idproducto", typeof(int));
                dt.Columns.Add("Cantidad", typeof(double));
                dt.Columns.Add("Precio", typeof(double));


                foreach (DataGridViewRow item in tablaProductos.Rows)
                {
                    DataRow dr = dt.NewRow();
                    dr["Idproducto"] = Convert.ToInt32(item.Cells[0].Value);
                    dr["Cantidad"] = Convert.ToDouble(item.Cells[2].Value);
                    dr["Precio"] = Convert.ToInt32(item.Cells[3].Value);
                    dt.Rows.Add(dr);
                }
                objE_venta.Id_mesa = idmesa;
                objE_venta.Id_Turno = Idturno;
                objE_venta.Venta_total = Convert.ToDouble(lblTotal.Text);
                objVenta.InsertarVenta(objE_venta, dt);

                formAlerta = new frmAlerta("Venta Registrada Satisfactoriamente!!", frmAlerta.Alerta.Exitoso);
                formAlerta.ShowDialog();

                VolverAMesa();
                //tablaProductos.Rows.Clear();
                //lblTotal.Text = "0.00";
            }
            else
            {
                formAlerta = new frmAlerta("No Exciste productos para Facturar", frmAlerta.Alerta.Información);
                formAlerta.ShowDialog();
            }
        }

        
    }
}
