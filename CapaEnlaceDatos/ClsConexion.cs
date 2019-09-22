using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
/*
 * @Nombre de Clase: ClsConexion.
 * @Version: 1.0.
 * @Copyright: Sistema de registro y control de herramientas para bodega de la empresa VAAD.
 * @Author Victor, Adrian, Andrea, Diego
 */
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
