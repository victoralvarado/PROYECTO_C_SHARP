using System;
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
        #region VARIABLES LOCALES
        private ClsConexion conexion = new ClsConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        #endregion

        #region METODOS CATEGORIA
        //METODO PARA LISTAR CATEGORIA
        public DataTable Listar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarCategoria";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        //METODO PARA REGISTRAR CATEGORIA
        public void Registrar(string nombreCategoria)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RegistrarCategoria";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreCategoria", nombreCategoria);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA MODIFICAR CATEGORIA
        public void Modificar(int idCategoria, string nombreCategoria)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA ELIMINAR CATEGORIA
        public void Eliminar(int idCategoria)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarCategoria";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA LISTAR EL TOTAL DE CATEGORIAS
        public void listarTotalC(Label lbl)
        {
            try
            {
                int dat;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select count (*) from bodega.categoria";
                comando.CommandType = CommandType.Text;
                dat = (int)comando.ExecuteScalar();
                (lbl.Text) = dat.ToString();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA FILTRAR CATEGORIA
        public DataTable FiltrarCat(string buscar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "Select idCategoria AS 'CÓDIGO CATEGORÍA', nombreCategoria " +
                    "AS 'CATEGORÍA' from bodega.categoria where idCategoria like '%" + buscar + "%' " +
                    "or nombreCategoria like '%" + buscar + "%'";
                comando.CommandType = CommandType.Text;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }
        #endregion
    }
}
