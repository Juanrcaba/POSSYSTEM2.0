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
    public class D_PROVEEDORES
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarProveedores(E_PROVEEDORES oProveedor)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_MOSTRAR_PROVEEDORES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BUSCAR", oProveedor.Buscar);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarProveedor(E_PROVEEDORES oProveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_PROVEEDORES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@RAZON", oProveedor.RazonSocial);
            cmd.Parameters.AddWithValue("@TIPODOC", oProveedor.TipoDocumento);
            cmd.Parameters.AddWithValue("@NODOC", oProveedor.NoDocumento);
            cmd.Parameters.AddWithValue("@DIRECCION", oProveedor.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", oProveedor.Telefono);
            cmd.Parameters.AddWithValue("@EMAIL", oProveedor.Email);             

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarProveedor(E_PROVEEDORES oProveedor)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_PROVEEDORES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_PROVEEDOR", oProveedor.Idproveedor);
            cmd.Parameters.AddWithValue("@RAZON", oProveedor.RazonSocial);
            cmd.Parameters.AddWithValue("@TIPODOC", oProveedor.TipoDocumento);
            cmd.Parameters.AddWithValue("@NODOC", oProveedor.NoDocumento);
            cmd.Parameters.AddWithValue("@DIRECCION", oProveedor.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", oProveedor.Telefono);
            cmd.Parameters.AddWithValue("@EMAIL", oProveedor.Email);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
