using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Clientes
{
    public partial class frmViewClientes : Form
    {
        public frmViewClientes()
        {
            InitializeComponent();
        }

        private void frmViewClientes_Load(object sender, EventArgs e)
        {
            MostrarClientes("");
        }

        private void MostrarClientes(string buscar)
        {
            N_CLIENTES objDatos = new N_CLIENTES();
            E_CLIENTES eCliente = new E_CLIENTES();

            eCliente.Buscar = buscar;
            tablaClientes.DataSource = objDatos.MostrarClientes(eCliente);

            tablaClientes.Columns[0].DisplayIndex = 8;
            tablaClientes.Columns[1].Visible = false;
            Alineamiento();


            //ContarTotalProducto();
        }

        private void Alineamiento()
        {
            tablaClientes.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tablaClientes.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tablaClientes.ClearSelection();
        }

        private void tablaClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tablaClientes.CurrentRow.Cells["Edit"].Selected)
                {
                    frmClientes form = new frmClientes();
                    form.IsUpdate = true;
                    form.IdCliente = Convert.ToInt32(tablaClientes.CurrentRow.Cells[1].Value);
                    form.txtNombre.Text = tablaClientes.CurrentRow.Cells[2].Value.ToString();
                    form.cmbTipoDoc.Text = tablaClientes.CurrentRow.Cells[3].Value.ToString();
                    form.txtNoDoc.Text = tablaClientes.CurrentRow.Cells[4].Value.ToString();
                    form.txtDireccion.Text = tablaClientes.CurrentRow.Cells[5].Value.ToString();
                    form.txtTelefono.Text = tablaClientes.CurrentRow.Cells[6].Value.ToString();
                    form.txtEmail.Text = tablaClientes.CurrentRow.Cells[7].Value.ToString();


                    form.ShowDialog();
                    MostrarClientes("");
                }
            }
            catch (Exception)
            {

               
            }
           
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmClientes formClientes = new frmClientes();
            formClientes.ShowDialog();
            MostrarClientes("");
        }
    }
}
