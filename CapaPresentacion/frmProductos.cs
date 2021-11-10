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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
            
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            RedimencionCeldas();
            Alineamiento();
            ContarMarca();
            
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria form = new frmCategoria();
            form.ShowDialog();
            MostrarProductos();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarca form = new frmMarca();
            form.ShowDialog();
            MostrarProductos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMantenimientoProducto form = new frmMantenimientoProducto();
            form.ShowDialog();
            MostrarProductos();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        #region Metodos

        private void MostrarProductos()
        {
            N_PRODUCTO objDatos = new N_PRODUCTO();
            tablaProductos.DataSource = objDatos.MostrarProduto();
            tablaProductos.Columns[2].Visible = false;
            tablaProductos.Columns[5].Visible = false;
            tablaProductos.Columns[7].Visible = false;

            tablaProductos.Columns[0].DisplayIndex = 11;
            tablaProductos.Columns[1].DisplayIndex = 11;

            tablaProductos.ClearSelection();
        }

        private void RedimencionCeldas()
        {
            tablaProductos.Columns[3].Width = 50;
            tablaProductos.Columns[4].Width = 200;
            tablaProductos.Columns[0].Width = 50;
            tablaProductos.Columns[1].Width = 50;
        }

        private void Alineamiento()
        {
            tablaProductos.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProductos.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProductos.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProductos.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProductos.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProductos.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaProductos.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tablaProductos.ClearSelection();
        }

        private void ContarMarca()
        {
            N_PRODUCTO objDatos = new N_PRODUCTO();
            lblmarca.Text = objDatos.ContarMarca().ToString();
        }
        #endregion

        private void tablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
            if (tablaProductos.CurrentRow.Cells["Edit"].Selected)
            {
                frmMantenimientoProducto form = new frmMantenimientoProducto();                
                form.IsUpdate = true;
                form.Idproducto = Convert.ToInt32(tablaProductos.CurrentRow.Cells[2].Value);
                form.txtCodigo.Text = tablaProductos.CurrentRow.Cells[3].Value.ToString();
                form.txtProducto.Text = tablaProductos.CurrentRow.Cells[4].Value.ToString();
                form.cmbCategoria.SelectedValue = Convert.ToInt32(tablaProductos.CurrentRow.Cells[5].Value);
                form.cmbCategoria.SelectedValue = Convert.ToInt32(tablaProductos.CurrentRow.Cells[7].Value);
                form.txtPcompra.Text = tablaProductos.CurrentRow.Cells[9].Value.ToString();
                form.txtPventa.Text = tablaProductos.CurrentRow.Cells[10].Value.ToString();
                form.txtStock.Text = tablaProductos.CurrentRow.Cells[11].Value.ToString();

                form.ShowDialog();
                MostrarProductos();
                

            }
            else if (tablaProductos.CurrentRow.Cells["Delete"].Selected)
            {
                N_PRODUCTO objDatos = new N_PRODUCTO();
                E_PRODUCTO entidadProductos = new E_PRODUCTO();
                frmAlerta alerta;
                entidadProductos.Idproducto = Convert.ToInt32(tablaProductos.CurrentRow.Cells[2].Value);
                objDatos.EliminarProducto(entidadProductos);
                alerta = new frmAlerta("Producto Eliminado",frmAlerta.Alerta.Exitoso);
                alerta.ShowDialog();
                MostrarProductos();
            }
                
            
            
        }
    }
}
