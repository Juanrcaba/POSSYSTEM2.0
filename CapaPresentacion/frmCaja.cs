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
        E_CUADRE_TURNO objE_CuadreTurno = new E_CUADRE_TURNO();
        N_CUADRE_CAJA objN_Cuadrecaja = new N_CUADRE_CAJA();
        N_TURNO objN_Turnos = new N_TURNO();
        N_CUADRE_TURNO objN_cuadreTurno = new N_CUADRE_TURNO();
        frmAlerta form;

       // int IdTurno = 0;
        int estado = 0;

        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            pantallaOK();
            CargarTurnos();
            if (EstadoCaja())
                btnAbrirCaja.Enabled = false;
            else
                btnAbrirCaja.Enabled = true;

        }

        private bool EstadoCaja()
        {
            return objN_Cuadrecaja.MostrarCuadreCajas();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmMesas form = new frmMesas();
            form.Show();
            this.Hide();
        }

        //metodos
        private void MostrarCajas()
        {
            try
            {
                
                string fecha = dtFecha.Value.ToString("yyyy/MM/dd");
                if (rbtAbierto.Checked)
                    estado = 1;

                if (rbtCerrado.Checked)
                    estado = 0;
                if (rbtTodas.Checked)
                    estado = 2;

                objE_CuadreCaja.Estado = estado;
                objE_CuadreCaja.Fecha = fecha;
                tablaCajas.DataSource = objN_Cuadrecaja.MostrarCuadreCajas(objE_CuadreCaja);
                tablaCajas.Columns[0].Visible = false;
                tablaCajas.Columns[7].Visible = false;
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

            form = new frmAlerta("La Caja fue Cerrada con exito!!",frmAlerta.Alerta.Exitoso);
            form.ShowDialog();
            form.Dispose();

        }
        //fin metodos
        private void btnBuscar_Click(object sender, EventArgs e)
        {   
             MostrarCajas();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            frmAperturaCaja form = new frmAperturaCaja();
            form.ShowDialog();
            form.Dispose();
            MostrarCajas();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (tablaCajas.SelectedRows.Count > 0)
            {
                if (Convert.ToInt32(tablaCajas.CurrentRow.Cells[7].Value.ToString()) != 0)
                {
                    DataTable Dt = objN_Turnos.MostrarTurnosAbiertos();             
                   
                    string nCaja = tablaCajas.CurrentRow.Cells[1].Value.ToString();

                    int turno = 0;

                    form = new frmAlerta("Esta apunto de cerrar la caja #" + nCaja + ", esta seguro?", frmAlerta.Alerta.Información);
                  
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (Dt.Rows.Count > 0)
                        {
                            form = new frmAlerta("Existen turnos abiertos, deseas cerrarlos para continuar?", frmAlerta.Alerta.Información);
                            if (form.ShowDialog() == DialogResult.OK)
                            {
                                foreach (DataRow item in Dt.Rows)
                                {
                                   turno = Convert.ToInt32(item["ID_TURNO"]);                                    
                                }

                                if (objN_Turnos.MesasOcupadas() == 0 && turno!= 3)
                                {
                                    foreach (DataRow item in Dt.Rows)
                                    {
                                        objE_CuadreTurno.Id_Turno = Convert.ToInt32(item["ID_TURNO"]);
                                        objN_cuadreTurno.CerrarTurno(objE_CuadreTurno);
                                    }
                                }
                                else
                                {
                                    form = new frmAlerta("Existen mesas Ocupadas, no deben existir mesas ocupadas para cerrar caja", frmAlerta.Alerta.Información);
                                    form.ShowDialog();
                                    return;
                                }
                               
                            }
                            else
                            {
                                return;
                            }
                        }
                        else if (objN_Turnos.MesasOcupadas() != 0)
                        {
                            form = new frmAlerta("Existen mesas Ocupadas, no deben existir mesas ocupadas para cerrar caja", frmAlerta.Alerta.Información);
                            form.ShowDialog();
                            return;
                        }
                       

                        CerrarCaja(Convert.ToInt32(tablaCajas.CurrentRow.Cells[0].Value.ToString()),
                                   Convert.ToInt32(tablaCajas.CurrentRow.Cells[1].Value.ToString()));
                        CargarTurnos();
                        MostrarCajas();
                        if (EstadoCaja())
                            btnAbrirCaja.Enabled = false;
                        else
                            btnAbrirCaja.Enabled = true;
                    }                     
                    
                   
                }
                else
                {
                    form = new frmAlerta("Ya esta caja esta cerrada.", frmAlerta.Alerta.Información);
                    form.ShowDialog();
                    form.Dispose();
                }
            }
            else
            {
                form = new frmAlerta("Debes Seleccionar una caja a cerrar.", frmAlerta.Alerta.Información);
                form.ShowDialog();
                form.Dispose();
            }


        }

        private void btnTurnos_Click(object sender, EventArgs e)
        {
            frmAperturaTurno form = new frmAperturaTurno();
            form.ShowDialog();
            CargarTurnos();
        }

        public void CargarTurnos()
        {
            DataTable Datos = objN_Turnos.MostrarTurnosAbiertos();
            flowContainer.Controls.Clear();
            btnTurnos.Enabled = true;
            if (Datos.Rows.Count > 0) {            
              foreach (DataRow item in Datos.Rows)
              {
                frmTurno form = new frmTurno();
                    AddOwnedForm(form);
                form.lblFecha.Text = item[3].ToString();
                form.lblTurno.Text = item[0].ToString();
                form.lblUsuario.Text = item[2].ToString();
                form.id_turno = Convert.ToInt32(item[0]);

                form.TopLevel = false;
                flowContainer.Controls.Add(form);
                form.Show();
              }
                btnTurnos.Enabled = false;

            }
        }
    }
}
