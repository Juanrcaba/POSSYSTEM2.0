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
    public class D_CLIENTES
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarClientes(E_CLIENTES oCliente)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_MOSTRAR_CLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BUSCAR", oCliente.Buscar);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarClientes(E_CLIENTES oCliente)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_CLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@NOMBRE", oCliente.Nombrecliente);
            cmd.Parameters.AddWithValue("@TIPODOC", oCliente.TipoDocumento);
            cmd.Parameters.AddWithValue("@NODOC", oCliente.NoDocumento);
            cmd.Parameters.AddWithValue("@DIRECCION", oCliente.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", oCliente.Telefono);
            cmd.Parameters.AddWithValue("@EMAIL", oCliente.Email);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarClientes(E_CLIENTES oCliente)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITAR_CLIENTES", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID_CLIENTE", oCliente.Idcliente);
            cmd.Parameters.AddWithValue("@NOMBRE", oCliente.Nombrecliente);
            cmd.Parameters.AddWithValue("@TIPODOC", oCliente.TipoDocumento);
            cmd.Parameters.AddWithValue("@NODOC", oCliente.NoDocumento);
            cmd.Parameters.AddWithValue("@DIRECCION", oCliente.Direccion);
            cmd.Parameters.AddWithValue("@TELEFONO", oCliente.Telefono);
            cmd.Parameters.AddWithValue("@EMAIL", oCliente.Email);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
