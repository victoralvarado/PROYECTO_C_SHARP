using System;

using System.Data;
using System.Data.SqlClient;

namespace CapaEnlaceDatos
{
    public class ClsCategoria
    {
        private ClsConexion conexion = new ClsConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Listar()
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;

        }

        public void Registrar(string nombreCategoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();

        }

        public void Modificar(int idCategoria, string nombreCategoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void Eliminar(int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCategoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idCategoria", idCategoria);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
