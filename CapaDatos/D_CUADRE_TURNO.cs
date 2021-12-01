using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
     public class D_CUADRE_TURNO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);  

       

        public void AbrirTurno(E_CUADRE_TURNO cuadre)
        {
            SqlCommand cmd = new SqlCommand("SP_ABRIR_TURNO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDTURNO", cuadre.Id_Turno);
            cmd.Parameters.AddWithValue("@ID_CUADRE_CAJA", cuadre.Id_cuadre_caja);
            cmd.Parameters.AddWithValue("@ID_USUARIO", cuadre.Id_Usuario);
            cmd.Parameters.AddWithValue("@SALDO_INICIAL", cuadre.Saldo_Inicial);


            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void CerrarTurno(E_CUADRE_TURNO cuadre)
        {
            SqlCommand cmd = new SqlCommand("SP_CIERRE_TURNO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

           
            cmd.Parameters.AddWithValue("@ID_TURNO", cuadre.Id_Turno);


            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }


    }
}
