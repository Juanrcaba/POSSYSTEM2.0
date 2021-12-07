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
   public class D_PRODUCTO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarProducto()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_LISTARPRODUCTOS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;            

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }
        public DataTable BuscarProducto(string buscar)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PRODUCTO", buscar);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public DataTable BuscarProductoCategoria(int buscar)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCARPRODUCTO_CATEGORIA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdCateogria", buscar);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarProductos(E_PRODUCTO producto)
        {
            SqlCommand cmd = new SqlCommand("SP_INSERTARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@PRODUCTO", producto.Producto);
            cmd.Parameters.AddWithValue("@PRECIO_COMPRA", producto.Precio_compra);
            cmd.Parameters.AddWithValue("@PRECIO_VENTA", producto.Precio_venta);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", producto.Idcategoria);
            cmd.Parameters.AddWithValue("@IDMARCA", producto.Idmarca);
            cmd.Parameters.AddWithValue("@STOCK", producto.Stock);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EditarProductos(E_PRODUCTO producto)
        {
            SqlCommand cmd = new SqlCommand("SP_EDITARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDPRODUCTO", producto.Idproducto);
            cmd.Parameters.AddWithValue("@PRODUCTO", producto.Producto);
            cmd.Parameters.AddWithValue("@PRECIO_COMPRA", producto.Precio_compra);
            cmd.Parameters.AddWithValue("@PRECIO_VENTA", producto.Precio_venta);
            cmd.Parameters.AddWithValue("@IDCATEGORIA", producto.Idcategoria);
            cmd.Parameters.AddWithValue("@IDMARCA", producto.Idmarca);
            cmd.Parameters.AddWithValue("@STOCK", producto.Stock);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void EliminarProducto(E_PRODUCTO producto)
        {
            SqlCommand cmd = new SqlCommand("SP_ELIMINARPRODUCTO", conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IDPRODUCTO", producto.Idproducto);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public int ContarMarca()
        {
            SqlCommand cmd = new SqlCommand("select count(*) marca from MARCA",conexion);
            conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int Count = 0;

            if (reader.Read())
            {
                Count = Convert.ToInt32(reader["marca"]);
            }
            else
            {
                return 0;
            }
            conexion.Close();
            return Count;
            
        }

        public int ContarCategoria()
        {
            SqlCommand cmd = new SqlCommand("select count(*) categoria from Categoria", conexion);
            conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int Count = 0;

            if (reader.Read())
            {
                Count = Convert.ToInt32(reader["categoria"]);
            }
            else
            {
                return 0;
            }
            conexion.Close();
            return Count;

        }
        public int ContarProducto()
        {
            SqlCommand cmd = new SqlCommand("select count(*) producto from PRODUCTOS", conexion);
            conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int Count = 0;

            if (reader.Read())
            {
                Count = Convert.ToInt32(reader["producto"]);
            }
            else
            {
                return 0;
            }
            conexion.Close();
            return Count;

        }

        public int ContarTotalProducto()
        {
            SqlCommand cmd = new SqlCommand("select sum(stock) producto from PRODUCTOS", conexion);
            conexion.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            int Count = 0;

            if (reader.Read() && !(reader["producto"] is DBNull))
            {
                
                Count = Convert.ToInt32(reader["producto"]);
            }
            else
            {
                return 0;
            }
            conexion.Close();
            return Count;

        }


    }
}
