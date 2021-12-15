using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmMesas : Form
    {
        public frmMesas()
        {
            InitializeComponent();
        }
        N_TURNO objTurno = new N_TURNO();
        N_MESAS objMesas = new N_MESAS();
        E_MESAS objE_mesas = new E_MESAS();
        frmAlerta formAlerta;

        int idTurno = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            PagePrincipal form = new PagePrincipal();
            form.Show();
            this.Hide();
        }
        void pantallaOK()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            pantallaOK();
            if(ValidarTurno())
            CargarMesas();

        }

        private void CargarMesas()
        {
            DataTable DtMesas = objMesas.MostrarMesas();
            DataTable DtBalance;
            string Balance = "0.00";

            if (DtMesas != null)
                if(DtMesas.Rows.Count > 0)
                {
                    foreach (DataRow item in DtMesas.Rows)
                    {
                        objE_mesas.Id_mesa = Convert.ToInt32(item["ID_MESA"]);
                        DtBalance = objMesas.BalanceMesas(objE_mesas);
                       
                        if (DtBalance.Rows.Count > 0 && DtBalance.Rows[0][0].ToString() != "")
                            Balance =(DtBalance.Rows[0][0].ToString());
                        else
                            Balance = "0.00";

                        frmControlMesa btn = new frmControlMesa(Convert.ToInt32(item["ID_MESA"]), item["NOMBRE"].ToString(), Balance,idTurno);
                        AddOwnedForm(btn);
                        btn.TopLevel = false;
                        flowContainer.Controls.Add(btn);
                        btn.Show();
                    }
                }
                else
                {
                    formAlerta = new frmAlerta("No existen mesas",frmAlerta.Alerta.Información);
                    formAlerta.ShowDialog();
                    formAlerta.Dispose();
                }

            
        }

        private bool ValidarTurno()
        {
            DataTable dt = objTurno.MostrarTurnosAbiertos();
            if (dt.Rows.Count > 0)
            {
                idTurno = Convert.ToInt32(dt.Rows[0][0]);
                return true;
            }              
            else
                return false;
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            frmCaja form = new frmCaja();
            form.Show();
            this.Hide();
        }

       

        
    }
}
