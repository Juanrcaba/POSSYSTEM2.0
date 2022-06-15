﻿using System;
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
    public class D_VENTA
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        //aun no funciona
        public DataTable MostrarVentas(E_VENTA venta)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_BUSCAR_VENTAS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FECHA_INI", venta.Fecha_ini);
            cmd.Parameters.AddWithValue("@FECHA_FIN", venta.Fecha_fin);

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public DataTable GenerarTicket(int idVenta)
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_GENERAR_TICKET", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idventa",idVenta);
            

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public DataTable MostrarTickets()
        {
            DataTable Dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SP_MOSTRAR_TICKETS", conexion);
            cmd.CommandType = CommandType.StoredProcedure;            

            SqlDataAdapter Da = new SqlDataAdapter(cmd);
            Da.Fill(Dt);

            return Dt;
        }

        public void InsertarVenta(E_VENTA venta, DataTable Dtable)
        {
            
            SqlCommand cmd = new SqlCommand("SP_INSERTAR_VENTA", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_usuario",venta.Id_usuario);
            cmd.Parameters.AddWithValue("@id_turno", venta.Id_Turno);
            cmd.Parameters.AddWithValue("@venta_total", venta.Venta_total);
            cmd.Parameters.AddWithValue("@id_mesa", venta.Id_mesa);
         
            cmd.Parameters.Add("@id_venta", SqlDbType.Int).Direction = ParameterDirection.Output;

            try
            {
                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
                venta.Id_venta = Convert.ToInt32(cmd.Parameters["@id_venta"].Value);

               

                foreach (DataRow item in Dtable.Rows)
                {
                    cmd = new SqlCommand("SP_INSERTAR_DETALLE_VENTA", conexion);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@ID_VENTA", venta.Id_venta);
                    cmd.Parameters.AddWithValue("@ID_PRODUCTO", Convert.ToInt32(item["Idproducto"]));
                    cmd.Parameters.AddWithValue("@CANT_PRODUCTO", Convert.ToDouble(item["Cantidad"]));
                    cmd.Parameters.AddWithValue("@PRECIO_PRODUCTO", Convert.ToDouble(item["Precio"]));

                    conexion.Open();
                    cmd.ExecuteNonQuery();
                    conexion.Close();
                }
                          

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conexion.Close();
                conexion.Dispose();
            }
        }

        public void CancelarTicket(E_VENTA venta)
        {
            SqlCommand cmd = new SqlCommand("SP_CANCELAR_TICKET", conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_venta", venta.Id_venta);
            cmd.Parameters.AddWithValue("@comentario", venta.Comentario);

            conexion.Open();
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

    }
}
