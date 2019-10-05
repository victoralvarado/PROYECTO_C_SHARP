using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsUsuario.
* @Version: 1.0.
* @Copyright: Sistema de registro y control de herramientas para bodega de la empresa VAAD.
* @Author Victor, Adrian, Andrea & Diego.
*/
namespace CapaEnlaceDatos
{
    public class ClsUsuario
    {
        private ClsConexion conexion = new ClsConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        ComboBox combo = new ComboBox();
        SqlCommand comando = new SqlCommand();

        public DataTable Listar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }
        public DataTable ListarTU()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarTipoUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Registrar(string userName, string password, string tipoUsuario)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@userName", userName);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Modificar(int idUsuario, string userName, string password, string tipoUsuario)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@userName", userName);
            comando.Parameters.AddWithValue("@password", password);
            comando.Parameters.AddWithValue("@tipoUsuario", tipoUsuario);
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int idUsuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idUsuario", idUsuario);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
