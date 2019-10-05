using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsHerramienta.
* @Version: 1.0.
* @Copyright: Sistema de registro y control de herramientas para bodega de la empresa VAAD.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaEnlaceDatos
{
    public class ClsHerramienta
    {
        private ClsConexion conexion = new ClsConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable ComboCategoria()
        {
            DataTable datos = new DataTable();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            datos.Load(leer);
            conexion.CerrarConexion();
            return datos;
        }

        public DataTable Listar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ListarHerramienta";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable Filtrar(string campo, string buscar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select h.idHerramienta AS 'ID HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.idCategoria AS 'ID CATEGORIA', " +
                "h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORIA' from Bodega.herramienta h inner join Bodega.categoria c on h.idCategoria = c.idCategoria " +
                "WHERE "+campo+" LIKE '%"+buscar+"%'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }



        public void Registrar(string nombreHerramienta, int idCategoria, string uso, string estado)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarHerramienta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreHerramienta", nombreHerramienta);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@uso", uso);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

        }

        public void Modificar(string nombreHerramienta, int idCategoria, string uso, string estado , int idHerramienta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ModificarHerramienta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreHerramienta", nombreHerramienta);
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.Parameters.AddWithValue("@uso", uso);
            comando.Parameters.AddWithValue("@estado", estado);
            comando.Parameters.AddWithValue("@idHerramienta", idHerramienta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

        public void Eliminar(int idHerramienta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarHerramienta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idHerramienta", idHerramienta);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
