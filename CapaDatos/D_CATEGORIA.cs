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
    public class D_CATEGORIA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable Mostrar(string buscar)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARCATEGORIA");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BUSCAR",buscar);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarCategoria(E_CATEGORIA categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARCATEGORIA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOMBRE",categoria.Nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION",categoria.Descripcion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditartarCategoria(E_CATEGORIA categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARCATEGORIA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDCATEGORIA",categoria.Idcategoria);
            cmd.Parameters.AddWithValue("@NOMBRE", categoria.Nombre);
            cmd.Parameters.AddWithValue("@DESCRIPCION", categoria.Descripcion);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarCategoria(E_CATEGORIA categoria)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARCATEGORIA");
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDCATEGORIA", categoria.Idcategoria);
         
            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
