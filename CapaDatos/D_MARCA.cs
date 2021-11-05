using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace CapaDatos
{
   
    public class D_MARCA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarMarca(string buscar)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARMARCA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BUSCAR", buscar);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarMarca(E_MARCA marca)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARMARCA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOMBRE", marca.Nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", marca.Descripcion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarMarca(E_MARCA marca)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARMARCA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDMARCA", marca.Idmarca);
            cmd.Parameters.AddWithValue("@NOMBRE", marca.Nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", marca.Descripcion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarMarca(E_MARCA marca)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARMARCA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDMARCA", marca.Idmarca);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
