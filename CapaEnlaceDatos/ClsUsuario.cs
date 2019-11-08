using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsUsuario.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego.
*/
namespace CapaEnlaceDatos
{
    public class ClsUsuario
    {
        #region VARIABLES LOCALES
        private ClsConexion conexion = new ClsConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        string tipo = "";
        #endregion

        #region METODOS USUARIO
        //METODO PARA INICIAR SESION
        public string Login(string userName, string password)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select tipoUsuario from bodega.usuario where userName=@userName COLLATE  SQL_Latin1_General_CP1_CS_AS and password=@password COLLATE  SQL_Latin1_General_CP1_CS_AS";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@userName", userName);
                comando.Parameters.AddWithValue("@password", password);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                conexion.CerrarConexion();
                if (tabla.Rows.Count == 1)
                {
                    tipo = Convert.ToString(tabla.Rows[0][0]);
                }
                if (tabla.Rows.Count == 0)
                {
                    tipo = "";
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tipo;
        }

        //METODO PARA LISTAR USUARIO
        public DataTable Listar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarUsuario";
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

        //METODO PRAR LISTAR EL TIPO DE USUARIO(ADMINISTRADOR, BODEGUERO)
        public DataTable ListarTU()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarTipoUsuario";
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

        //METODO PARA FILTRAR(BUSCAR) USUARIOS
        public DataTable Filtrar(string buscar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT idUsuario AS 'CÓDIGO USUARIO', UserName AS " +
                    "'NOMBRE DE USUARIO',password, tipoUsuario AS 'TIPO DE USUARIO' " +
                    "FROM Bodega.usuario WHERE userName LIKE @buscar OR  tipoUsuario " +
                    "LIKE @buscar OR idUsuario LIKE @buscar ";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@buscar", buscar);
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        //METODO PRA REGISTRAR USUARIO
        public void Registrar(string userName, string password, string tipoUsuario)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //METODO PARA MODIFICAR USUARIO
        public void Modificar(int idUsuario, string userName, string password, string tipoUsuario)
        {
            try
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
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //METODO PARA ELIMINAR USUARIO
        public void Eliminar(int idUsuario)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarUsuario";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en: " + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
