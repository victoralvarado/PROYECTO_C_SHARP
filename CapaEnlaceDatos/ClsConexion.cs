using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace CapaEnlaceDatos
{
    public class ClsConexion
    {
        public SqlConnection Conexion = new SqlConnection("Server=(local);DataBase=Bodega;Integrated Security=SSPI");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
