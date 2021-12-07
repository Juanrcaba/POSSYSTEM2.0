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
    public class D_DETALLE_MESA
    {

        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarDetalleMesa(E_DETALLE_MESA Dmesa)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCAR_DETALLE_MESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idmesa",Dmesa.Id_mesa);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarDetalleMesa(E_DETALLE_MESA Dmesa)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_DETALLE_MESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@idmesa", Dmesa.Id_mesa);
            cmd.Parameters.AddWithValue("@idproducto", Dmesa.Id_producto);           
            cmd.Parameters.AddWithValue("@precio", Dmesa.Precio);
         
           


            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarDetalleMesa(E_DETALLE_MESA Dmesa)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_DETALLE_MESA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@id_mesa", Dmesa.Id_mesa);
            cmd.Parameters.AddWithValue("@id_producto", Dmesa.Id_producto);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
