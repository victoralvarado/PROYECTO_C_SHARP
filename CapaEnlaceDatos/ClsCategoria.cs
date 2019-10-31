using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsCategoria.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
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

        public void listarTotalC(Label lbl)
        {
            int dat;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count (idCategoria) from bodega.categoria";
            comando.CommandType = CommandType.Text;
            dat = (int)comando.ExecuteScalar();
            (lbl.Text) = dat.ToString();
            conexion.CerrarConexion();
        }

        public void Registrar(string nombreCategoria)
        {

            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "RegistrarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();

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
            conexion.CerrarConexion();
        }

        public DataTable FiltrarCat(string buscar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Select idCategoria AS 'CÓDIGO CATEGORÍA', nombreCategoria " +
                "AS 'CATEGORÍA' from bodega.categoria where idCategoria like '%" + buscar + "%' " +
                "or nombreCategoria like '%" + buscar + "%'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Eliminar(int idCategoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idCategoria", idCategoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }
    }
}
