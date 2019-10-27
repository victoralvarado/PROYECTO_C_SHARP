using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEnlaceDatos
{
    public class ClsDevolucion
    {
        private ClsConexion conexion = new ClsConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void Eliminar(int idPrestamo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarDetallePrestamo";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idPrrestamo", idPrestamo);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
            conexion.CerrarConexion();
        }

    }
}
