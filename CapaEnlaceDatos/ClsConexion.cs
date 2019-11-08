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
        //CLASE SqlConnection PARA LA CADENA CONEXION
        public SqlConnection Con = new SqlConnection(Properties.Settings.Default.conexion);

        //METODO PARA ABRIR LA CONEXION
        public SqlConnection AbrirConexion()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();
            return Con;
        }

        //METODO PARA CERRAR LA CONEXION
        public SqlConnection CerrarConexion()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            return Con;
        }
        #endregion
    }
}
