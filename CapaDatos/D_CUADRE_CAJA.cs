using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidades;
using System.Configuration;

namespace CapaDatos
{
    public class D_CUADRE_CAJA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarCuadreCajas(E_CUADRE_CAJA cuadre)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CUADRE_CAJAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ESTADO", cuadre.Estado );
            cmd.Parameters.AddWithValue("@FECHA", cuadre.Fecha);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public bool MostrarCuadreCajas()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCAR_CAJAS_ABIERTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
           
           

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            if (Dt.Rows.Count > 0 && Dt != null)
                return true;
            else
            return false;
        }

        public bool EstadoCajaDia()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_ESTADO_CAJA_DIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            if (Dt.Rows.Count > 0 && Dt != null)
                return true;
            else
                return false;
        }

        public int AbrirCajas(E_CUADRE_CAJA cuadre)
        {
            SqlCommand cmd = new SqlCommand("SP_ABRIR_CAJA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDCAJA", cuadre.Id_caja);
            cmd.Parameters.AddWithValue("@SALDO_APERTURA", cuadre.Saldo_apertura);
            cmd.Parameters.AddWithValue("@fecha",cuadre.Fecha);
            cmd.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.Output;

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();


            return  Convert.ToInt32(cmd.Parameters["@resultado"].Value);
        }

        public void CerrarCajas(E_CUADRE_CAJA cuadre)
        {
            SqlCommand cmd = new SqlCommand("SP_CIERRE_CAJA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_CUADRE_CAJA", cuadre.Id_cuadre_caja);
            cmd.Parameters.AddWithValue("@ID_CAJA", cuadre.Id_caja);


            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public int Id_CajaAbierta()
        {
            int id = 0;
            SqlCommand cmd = new SqlCommand("SP_CAJA_ABIERTA",conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            conexion.Open();

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                id = Convert.ToInt32(reader["ID_CUADRE_CAJA"].ToString());
            }
            return id;
        }
    }
}
