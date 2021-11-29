using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmAperturaTurno : Form
    {
        public frmAperturaTurno()
        {
            InitializeComponent();
        }

        N_TURNO objTurnos = new N_TURNO();
        int idTurno = 0;
        double saldo = 0;

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAperturaTurno_Load(object sender, EventArgs e)
        {
            MostrarTurno();
        }

        //Metodos
        void MostrarTurno()
        {
            DataTable Datos = objTurnos.MostrarTurnos();

            foreach (DataRow item in Datos.Rows)
            {
                idTurno = Convert.ToInt32(item[0]);
                lblTurno.Text = item[2].ToString();
                lblFecha.Text = DateTime.Now.ToString();
            }
        }

        void AbrirTurno(int idturno, double saldo)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
               
                    if (double.TryParse(txtSaldo.Text, out saldo))
                        AbrirTurno(idTurno, saldo);
                    else
                    {
                        frmAlerta form = new frmAlerta("Debe insertar datos numericos en el Saldo inicial", frmAlerta.Alerta.Error);
                        form.ShowDialog();
                        txtSaldo.Focus();
                    }
            }
            catch (Exception ex)
            {

                frmAlerta form = new frmAlerta("El saldo es incorrecto", frmAlerta.Alerta.Error);
                form.ShowDialog();

            }
        }
    }
}
