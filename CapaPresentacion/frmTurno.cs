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
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmTurno : Form
    {
        public frmTurno()
        {
            InitializeComponent();
        }
        public int id_turno = 0;

        E_CUADRE_TURNO objE_CuadreTurno = new E_CUADRE_TURNO();
        N_CUADRE_TURNO objN_CuadreTurno = new N_CUADRE_TURNO();

        private void btnCerrarTurno_Click(object sender, EventArgs e)
        {
            frmCaja formcaja = Owner as frmCaja;
            frmAlerta form = new frmAlerta("Esta Apunto de Cerrar el Turno, Esta Seguro?", frmAlerta.Alerta.Información);
            if (form.ShowDialog() == DialogResult.OK)
            {
                objE_CuadreTurno.Id_Turno = id_turno;
                objN_CuadreTurno.CerrarTurno(objE_CuadreTurno);
                form = new frmAlerta("Turno Fue cerrado Satisfactoriamente!!", frmAlerta.Alerta.Exitoso);
                form.ShowDialog();
                formcaja.CargarTurnos();
            }            
        }
    }
}
