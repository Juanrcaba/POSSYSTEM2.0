using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CapaDatos
{
    public class D_TURNO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarTurnos()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARTURNOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public DataTable MostrarTurnosAbiertos()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARTURNOS_ABIERTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;


            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }
      

        

        public void AbrirTurnos(E_CUADRE_TURNO cuadre)
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

            cmd.Parameters.AddWithValue("@ID_CUADRE_TURNO", cuadre.Id_Turno);
            

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public int MesasOcupadas()
        {
            int estado = 0;

            SqlCommand cmd = new SqlCommand("SP_ESTADO_MESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;         
            cmd.Parameters.Add("@estado", SqlDbType.Int).Direction = ParameterDirection.Output;

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();

            estado = Convert.ToInt32(cmd.Parameters["@estado"].Value);

            return estado;
        }
    }
}
