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
    public partial class frmCaja : Form
    {
        public frmCaja()
        {
            InitializeComponent();
        }

        E_CUADRE_CAJA objE_CuadreCaja = new E_CUADRE_CAJA();
        N_CUADRE_CAJA objN_Cuadrecaja = new N_CUADRE_CAJA();

        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            pantallaOK();         
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMesas form = new frmMesas();
            form.Show();
            this.Hide();
        }

        //metodos
        private void MostrarCajas(int estado,string fecha)
        {
            try
            {
                objE_CuadreCaja.Estado = estado;
                objE_CuadreCaja.Fecha = fecha;
                tablaCajas.DataSource = objN_Cuadrecaja.MostrarCuadreCajas(objE_CuadreCaja);
                tablaCajas.ClearSelection();
                btnBuscar.Focus();
            }
            catch (Exception)
            {

                frmAlerta form = new frmAlerta("Error Al intentar cargar los datos.",frmAlerta.Alerta.Error);
                form.ShowDialog();
                form.Dispose();
            }
        }

        private void CerrarCaja( int IdCuadreCaja,int IdCaja)
        {
            objE_CuadreCaja.Id_cuadre_caja = IdCuadreCaja;
            objE_CuadreCaja.Id_caja = IdCaja;
            objN_Cuadrecaja.CerrarCajas(objE_CuadreCaja);
            frmAlerta form = new frmAlerta("La Caja fue Cerrada con exito!!",frmAlerta.Alerta.Exitoso);
            form.ShowDialog();
            form.Dispose();

        }
        //fin metodos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int estado = 0;
            string fecha = dtFecha.Value.ToString();
            if (rbtAbierto.Checked)
                estado = 1;

            if (rbtCerrado.Checked)
                estado = 0;
            if (rbtTodas.Checked)
                estado = 2;

            MostrarCajas(estado,fecha);
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            frmAperturaCaja form = new frmAperturaCaja();
            form.ShowDialog();
            form.Dispose();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (tablaCajas.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(tablaCajas.CurrentRow.Cells[7].Value.ToString()) != 0)
                {
                    string nCaja = tablaCajas.CurrentRow.Cells[1].Value.ToString();

                    frmAlerta form = new frmAlerta("Esta apunto de cerrar la caja #" + nCaja + ", esta seguro?", frmAlerta.Alerta.Información);
                    if (form.ShowDialog() == DialogResult.OK)
                        CerrarCaja(Convert.ToInt32(tablaCajas.CurrentRow.Cells[0].Value.ToString()),
                                   Convert.ToInt32(tablaCajas.CurrentRow.Cells[1].Value.ToString()));
                }
                else
                {
                    frmAlerta form = new frmAlerta("Ya esta caja esta cerrada.", frmAlerta.Alerta.Información);
                    form.ShowDialog();
                    form.Dispose();
                }
            }
            else
            {
                frmAlerta form = new frmAlerta("Debes Seleccionar una caja a cerrar.", frmAlerta.Alerta.Información);
                form.ShowDialog();
                form.Dispose();
            }


        }
    }
}
