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
    public class D_CAJA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarCajas()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARCAJA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
           

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarCajas(E_CAJA caja)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCAJAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOMBRE", caja.Nombre);
           

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarCajas(E_CAJA caja)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCAJAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDCAJA", caja.Id_caja);
            cmd.Parameters.AddWithValue("@NOMBRE", caja.Nombre);
           
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        
    }
}
