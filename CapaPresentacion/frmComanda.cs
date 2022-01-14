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
        public int cantidadEditada = 0;


        double calculo = 0;
        public int idmesa = 0;
        public int Idturno = 0;
        int carga = 0;
        int indexFila = -1;
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
            btnMesas.Focus();
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

                        indexFila = item.Index;
                        item.Cells["Cantidad"].Value = Convert.ToInt32(item.Cells["Cantidad"].Value) + 1;
                        carga = 2;
                        item.Cells[3].Value = precio;
                        item.Cells["Total"].Value = Convert.ToInt32(item.Cells["Cantidad"].Value) * precio;

                        //update tabla en la base de datos
                        objE_detalle_mesa.Id_mesa = idmesa;
                        objE_detalle_mesa.Id_producto = id_producto;
                        objE_detalle_mesa.Cantidad = Convert.ToInt32(item.Cells["Cantidad"].Value);
                        objE_detalle_mesa.Precio = precio;
                        objE_detalle_mesa.Total = Convert.ToDouble(item.Cells["Total"].Value);
                        objDetalle_mesa.EditarDetalleMesa(objE_detalle_mesa);
                        return;
                    }
                    
                }
                carga = 1;
                tablaProductos.Rows.Add(id_producto, nombre, 1, precio, (1 * precio));
                //insert en la base de datos
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = id_producto;              
                objE_detalle_mesa.Precio = precio;
                tablaProductos.ClearSelection();
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
            this.Focus();

        }
        private void CargarComanda()
        {
           
            objE_detalle_mesa.Id_mesa = idmesa;
            DataTable Dt = objDetalle_mesa.MostrarDetalleMesa(objE_detalle_mesa);
            tablaProductos.Rows.Clear();
            if (Dt.Rows.Count > 0)
            {
                foreach (DataRow item in Dt.Rows)
                {
                    tablaProductos.Rows.Add(item["ID_PRODUCTO"], item["NOMBRE"], item["CANTIDAD"],item["PRECIO"], item["TOTAL"]);
                }
                tablaProductos.ClearSelection();
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
                formAlerta = new frmAlerta("Desea Proceder con la Facturacion?",frmAlerta.Alerta.Información);
                if ( formAlerta.ShowDialog() == DialogResult.OK)
                {
                    DataTable dt = new DataTable();
                    CreaTicket Ticket1 = new CreaTicket();


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
                    objE_venta.Id_usuario = DatosUsuario.Id_usuario;
                    objE_venta.Venta_total = Convert.ToDouble(lblTotal.Text);
                    objVenta.InsertarVenta(objE_venta, dt);

                    formAlerta = new frmAlerta("Venta Registrada Satisfactoriamente!!", frmAlerta.Alerta.Exitoso);
                    formAlerta.ShowDialog();

                    VolverAMesa();
                }
                
            }
            else
            {
                formAlerta = new frmAlerta("No Exciste productos para Facturar", frmAlerta.Alerta.Información);
                formAlerta.ShowDialog();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                frmEditar_Comanda form = new frmEditar_Comanda();
                AddOwnedForm(form);
                form._Idproducto = Convert.ToInt32(tablaProductos.CurrentRow.Cells[0].Value);
                form._NombreProducto = tablaProductos.CurrentRow.Cells[1].Value.ToString();
                form._CantidadProducto = tablaProductos.CurrentRow.Cells[2].Value.ToString();                
                form.ShowDialog();

                tablaProductos.CurrentRow.Cells[2].Value = cantidadEditada;
                tablaProductos.CurrentRow.Cells[4].Value = cantidadEditada * Convert.ToDouble(tablaProductos.CurrentRow.Cells[3].Value);

                //-----------------
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = Convert.ToInt32(tablaProductos.CurrentRow.Cells[0].Value);
                objE_detalle_mesa.Cantidad = cantidadEditada;
                objE_detalle_mesa.Precio = Convert.ToDouble(tablaProductos.CurrentRow.Cells[3].Value);
                objE_detalle_mesa.Total = Convert.ToDouble(tablaProductos.CurrentRow.Cells[4].Value);
                objDetalle_mesa.EditarDetalleMesa(objE_detalle_mesa);
                //-----------------

                CargarComanda();

            }
            else
            {
                MessageBox.Show("Selecciona un producto");
            }
        }

        private void btnCuenta_Click(object sender, EventArgs e)
        {
            if (tablaProductos.Rows.Count > 0)
            {
                CreaTicket Ticket = new CreaTicket();


                Ticket.AbreCajon();  //abre el cajon
                Ticket.TextoIzquierda(DatosUsuario.Nombre);
                Ticket.TextoDerecha(lblMesa.Text);
                Ticket.TextoCentro("Venta mostrador"); // imprime en el centro "Venta mostrador"
                Ticket.TextoExtremos("Fecha " + DateTime.Now.ToShortDateString(), "Hora: " + DateTime.Now.ToString("hh:mm:ss tt"));
                Ticket.LineasGuion(); // imprime una linea de guiones
                Ticket.EncabezadoVenta(); // imprime encabezados 
                Ticket.TextoCentro("");

                foreach (DataGridViewRow item in tablaProductos.Rows)
                {
                    Ticket.AgregaArticulo(Convert.ToString(item.Cells[1].Value), Convert.ToInt32(item.Cells[2].Value), Convert.ToDouble(item.Cells[3].Value), Convert.ToDouble(item.Cells[4].Value)); //imprime una linea de descripcion
                }
                Ticket.LineasTotales(); // imprime linea
                Ticket.AgregaTotales("Total", Convert.ToDouble(lblTotal.Text)); // imprime linea con total
                Ticket.TextoCentro("");
                Ticket.TextoCentro("Bar Santa");
                Ticket.TextoCentro("Gracias por Preferirnos!!");

                Ticket.CortaTicket(); // corta el ticket


                VolverAMesa();
            }
            else
            {
                formAlerta = new frmAlerta("Esta mesa esta vacia.",frmAlerta.Alerta.Error);
                formAlerta.ShowDialog();
            }
           
        }

        private void tablaProductos_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void frmComanda_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tablaProductos_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void btnMesas_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void tablaProductos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (tablaProductos.CurrentCell.ColumnIndex == 2)
            {
                e.Control.KeyPress -= PermitirSoloNumeros;
                e.Control.KeyPress += PermitirSoloNumeros;
            }
                
        }

        private void PermitirSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void tablaProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (carga == 2)
            {
                carga = 0;
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = Convert.ToInt32(tablaProductos.Rows[indexFila].Cells["idProducto"].Value);
                objE_detalle_mesa.Cantidad = Convert.ToInt32(tablaProductos.Rows[indexFila].Cells["Cantidad"].Value);
                objE_detalle_mesa.Precio = Convert.ToDouble(tablaProductos.Rows[indexFila].Cells["Precio"].Value);
                tablaProductos.Rows[indexFila].Cells["Total"].Value = Convert.ToDouble(tablaProductos.Rows[indexFila].Cells["Precio"].Value) * Convert.ToInt32(tablaProductos.Rows[indexFila].Cells["Cantidad"].Value);
                objE_detalle_mesa.Total = Convert.ToDouble(tablaProductos.Rows[indexFila].Cells["Total"].Value);
                objDetalle_mesa.EditarDetalleMesa(objE_detalle_mesa);
                CargarComanda();

            }
            if (tablaProductos.SelectedRows.Count > 0)
            {
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = Convert.ToInt32(tablaProductos.CurrentRow.Cells["idProducto"].Value);
                objE_detalle_mesa.Cantidad = Convert.ToInt32(tablaProductos.CurrentRow.Cells["Cantidad"].Value);
                objE_detalle_mesa.Precio = Convert.ToDouble(tablaProductos.CurrentRow.Cells["Precio"].Value);
                objE_detalle_mesa.Total = Convert.ToDouble(Convert.ToDouble(tablaProductos.CurrentRow.Cells["Precio"].Value) * Convert.ToInt32(tablaProductos.CurrentRow.Cells["Cantidad"].Value));
                objDetalle_mesa.EditarDetalleMesa(objE_detalle_mesa);
                CargarComanda();
            }       
           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tablaProductos.SelectedRows.Count > 0)
            {
                objE_detalle_mesa.Id_mesa = idmesa;
                objE_detalle_mesa.Id_producto = Convert.ToInt32(tablaProductos.CurrentRow.Cells[0].Value);
                objDetalle_mesa.EliminarProductoDetalleMesa(objE_detalle_mesa);
                CargarComanda();
            }
            else
            {
                formAlerta = new frmAlerta("Debes Seleccionar un elemento de la comanda",frmAlerta.Alerta.Error);
                formAlerta.ShowDialog();
            }
        }
    }
}
