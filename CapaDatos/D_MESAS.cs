using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaEntidades;
using System.Configuration;

namespace CapaDatos
{
    public class D_MESAS
    {
        // SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostarMesas()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_MOSTRAR_MESAS", conexion);
                cmd.CommandType = CommandType.StoredProcedure;

                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(Dt);

                return Dt;
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        public DataTable BalanceMesa(E_MESAS mesas)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_BALANCE_MESA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idmesa",mesas.Id_mesa);

                DataTable Dt = new DataTable();
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(Dt);

                return Dt;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void TraspasoMesa(int _IdDesde,int _IdHasta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_TRASPASO_MESA", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@iddesde", _IdDesde);
                cmd.Parameters.AddWithValue("@idhasta", _IdHasta);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
