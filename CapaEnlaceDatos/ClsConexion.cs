using System.Data;
using System.Data.SqlClient;
/*
 * @Nombre de Clase: ClsConexion.
 * @Version: 1.0.
 *@Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea, Diego
 */
namespace CapaEnlaceDatos
{
    public class ClsConexion
    {
        #region CONEXION
        //CADENA CONEXION
        public SqlConnection Conexion = new SqlConnection("Server=(local);DataBase=Bodega;Integrated Security=SSPI");

        //METODO PARA ABRIR LA CONEXION
        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        //METODO PARA CERRAR LA CONEXION
        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
        #endregion
    }
}
