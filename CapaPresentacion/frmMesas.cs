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
        N_MESAS objMesas = new N_MESAS();
        E_MESAS objE_mesas = new E_MESAS();
        frmAlerta formAlerta;

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

                        frmControlMesa btn = new frmControlMesa(Convert.ToInt32(item["ID_MESA"]), item["NOMBRE"].ToString(), Balance);
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

        private void Mostrarmensaje(int id,string mesa)
        {
            frmComanda form = new frmComanda();
            form.Show();
            this.Hide();
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            frmCaja form = new frmCaja();
            form.Show();
            this.Hide();
        }

       

        
    }
}
