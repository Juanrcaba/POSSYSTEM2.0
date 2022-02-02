using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class D_USUARIO
    {
        SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public DataTable MostrarUsuarios(E_USUARIO usuario)
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_BUSCARUSUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BUSCAR", usuario.BUSCAR);


                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(Dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return Dt;
        }

        public DataTable MostrarPerfiles()
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("select * from PERFILES", conexion);
                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(Dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return Dt;
        }

        public DataTable Login(E_USUARIO e_objUsuario)
        {
            DataTable Dt = new DataTable();

            try
            {
                SqlCommand cmd = new SqlCommand("SP_LOGIN", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@USUARIO", e_objUsuario.USUARIO);
                //cmd.Parameters.AddWithValue("@CONTRASEÑA", e_objUsuario.CONTRASEÑA);


                SqlDataAdapter Da = new SqlDataAdapter(cmd);
                Da.Fill(Dt);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

            return Dt;
        }

        public void InsertarDatos(E_USUARIO usuario)
        {
            
            try
            {
                SqlCommand cmd = new SqlCommand("SP_INSERTAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NOMBRE", usuario.NOMBRE);
                cmd.Parameters.AddWithValue("@USUARIO", usuario.USUARIO);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.CONTRASEÑA);
                cmd.Parameters.AddWithValue("@PERFIL", usuario.PERFIL);
                cmd.Parameters.AddWithValue("@SEXO", usuario.SEXO);
                cmd.Parameters.AddWithValue("@SALT", usuario.SALT);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

        }

        public void EditarDatos(E_USUARIO usuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SP_EDITAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IDUSUARIO", usuario.ID_USUARIO);
                cmd.Parameters.AddWithValue("@NOMBRE", usuario.NOMBRE);
                cmd.Parameters.AddWithValue("@USUARIO", usuario.USUARIO);
                cmd.Parameters.AddWithValue("@CONTRASEÑA", usuario.CONTRASEÑA);
                cmd.Parameters.AddWithValue("@PERFIL", usuario.PERFIL);
                cmd.Parameters.AddWithValue("@SEXO", usuario.SEXO);
                cmd.Parameters.AddWithValue("@SALT", usuario.SALT);
                cmd.Parameters.AddWithValue("@ESTADO", usuario.ESTADO);

                conexion.Open();
                cmd.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) conexion.Close();
            }

        }
    }
}
