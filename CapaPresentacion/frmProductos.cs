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
        frmAlerta alerta;
        private void frmProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            RedimencionCeldas();
            Alineamiento();    
            
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
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            worksheet = workbook.Sheets[1];
            worksheet.Name = "Productos";
            int contador = 0;

            for (int i = 0; i < tablaProductos.Columns.Count -2 ; i++)
            {
                worksheet.Cells[1, i + 1] = tablaProductos.Columns[i + 2].HeaderText;
            }

            for (int i = 0; i < tablaProductos.Rows.Count; i++)
            {
                for (int j = 2; j < tablaProductos.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, contador + 1] = tablaProductos.Rows[i].Cells[j].Value.ToString();
                    contador++;
                }
                contador = 0;
            }                   
           
            app.Visible = true;
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

            ContarMarca();
            ContarCategoria();
            ContarProducto();
            ContarTotalProducto();
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
        private void ContarCategoria()
        {
            N_PRODUCTO objDatos = new N_PRODUCTO();
            lblcategoria.Text = objDatos.ContarCategoria().ToString();
        }
        private void ContarProducto()
        {
            N_PRODUCTO objDatos = new N_PRODUCTO();
            lblProducto.Text = objDatos.ContarProducto().ToString();
        }
        private void ContarTotalProducto()
        {
            N_PRODUCTO objDatos = new N_PRODUCTO();
            lblstock.Text = objDatos.ContarTotalProducto().ToString();
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
                form.cmbMarca.SelectedValue = Convert.ToInt32(tablaProductos.CurrentRow.Cells[7].Value);
                form.txtPcompra.Text = tablaProductos.CurrentRow.Cells[9].Value.ToString();
                form.txtPventa.Text = tablaProductos.CurrentRow.Cells[10].Value.ToString();
                form.txtStock.Text = tablaProductos.CurrentRow.Cells[11].Value.ToString();

                form.ShowDialog();
                MostrarProductos();
                

            }
            else if (tablaProductos.CurrentRow.Cells["Delete"].Selected)
            {

                alerta = new frmAlerta("Desea Eliminar el producto?", frmAlerta.Alerta.Información);
                if (alerta.ShowDialog() == DialogResult.OK)
                {
                    N_PRODUCTO objDatos = new N_PRODUCTO();
                    E_PRODUCTO entidadProductos = new E_PRODUCTO();

                    entidadProductos.Idproducto = Convert.ToInt32(tablaProductos.CurrentRow.Cells[2].Value);
                    objDatos.EliminarProducto(entidadProductos);
                    alerta = new frmAlerta("Producto Eliminado.", frmAlerta.Alerta.Exitoso);
                    alerta.ShowDialog();
                    MostrarProductos();

                }

               
            }                         
        }

        
    }
}
