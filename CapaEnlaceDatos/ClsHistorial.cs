using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsHistorial.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaEnlaceDatos
{
    public class ClsHistorial
    {
        private ClsConexion conexion = new ClsConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Listar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarHistorialPrestamo";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;

        }

        public void Registrar(int idPersonal, int idHerramienta, string fechaHora, string prespor)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RegistrarHistorialPrestamo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPersonal", idPersonal);
                comando.Parameters.AddWithValue("@idHerramienta", idHerramienta);
                comando.Parameters.AddWithValue("@fechaHora", fechaHora);
                comando.Parameters.AddWithValue("@prespor", prespor);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public DataTable Filtrar(string campo, string buscar)
        {
            //Buscar por un campo especifico de la tabla
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',hi.idPrestamoH AS 'CÓDIGO PRESTAMO'," +
                "hi.idherramienta 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'HERRAMIENTA',hi.fechaHora AS 'FECHA-HORA',hi.prespor AS 'ASIGNADA POR' " +
                "from bodega.personal p inner join bodega.historial hi on p.id = hi.idPersonal inner join bodega.herramienta h on hi.idHerramienta=h.idHerramienta " +
                "WHERE " + campo + " LIKE '%" + buscar + "%'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable FiltrarTC(string buscar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = " select p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',hi.idPrestamoH AS 'CÓDIGO HISTORIAL'," +
                "hi.idherramienta 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'HERRAMIENTA',hi.fechaHora AS 'FECHA-HORA',hi.prespor AS 'ASIGNADA POR' " +
                "from bodega.personal p inner join bodega.historial hi on p.id = hi.idPersonal inner join bodega.herramienta h on hi.idHerramienta=h.idHerramienta " +
                "where p.id like '%" + buscar + "%' or p.nombre like '%" + buscar + "%' or p.apellido like '%" + buscar + "%' or hi.idPrestamoH like '%" + buscar + "%' " +
                "or hi.idHerramienta like '%" + buscar + "%' or h.nombreHerramienta like '%" + buscar + "%' or hi.fechaHora like '%" + buscar + "%' or hi.prespor like '%" + buscar + "%'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }
    }
}
