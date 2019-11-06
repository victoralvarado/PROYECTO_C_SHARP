using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsDevolucion.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
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

        public DataTable Listar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarDevolucion";
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

        public void Registrar(int idHerramienta, int idPersonal, string estadoEntre,string fechaHora,string prespor,string recibidaPor)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RegistrarDevolucion";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPersonal", idPersonal);
                comando.Parameters.AddWithValue("@idHerramienta", idHerramienta);
                comando.Parameters.AddWithValue("@estadoEntre", estadoEntre);
                comando.Parameters.AddWithValue("@fechaHora", fechaHora);
                comando.Parameters.AddWithValue("@prespor", prespor);
                comando.Parameters.AddWithValue("@recibidaPor", recibidaPor);
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
            comando.CommandText = "select de.idDevolucion AS 'CÓDIGO DEVOLUCIÓN',p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',h.idHerramienta " +
                "AS 'CÓDIGO HERRAMIENTA',h.nombreHerramienta AS 'HERRAMIENTA', de.estadoEntre AS 'ESTADO DE ENTREGA',de.prespor AS 'ASIGNADA POR', de.recibidaPor AS 'RECIBIDA POR', " +
                "de.fechaHora AS 'FECHA-HORA' from bodega.devolucion de inner join bodega.personal p on de.idPersonal=p.id inner join bodega.herramienta h on de.idHerramienta=h.idHerramienta " +
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
            comando.CommandText = "select de.idDevolucion AS 'CÓDIGO DEVOLUCIÓN',p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido AS 'APELLIDOS',h.idHerramienta AS 'CÓDIGO HERRAMIENTA', " +
                "h.nombreHerramienta AS 'HERRAMIENTA', de.estadoEntre AS 'ESTADO DE ENTREGA',de.prespor AS 'ASIGNADA POR', de.recibidaPor AS 'RECIBIDA POR',de.fechaHora AS 'FECHA-HORA' from " +
                "bodega.devolucion de inner join bodega.personal p on de.idPersonal=p.id inner join bodega.herramienta h on de.idHerramienta=h.idHerramienta where de.idDevolucion like '%" + buscar + "%'" +
                " or p.id like '%" + buscar + "%' or p.nombre like '%" + buscar + "%' or p.apellido like '%" + buscar + "%' or h.idHerramienta like '%" + buscar + "%' or h.nombreHerramienta like '%" + buscar + "%' " +
                "or de.estadoEntre like '%" + buscar + "%' or de.prespor like '%" + buscar + "%' or de.recibidaPor like '%" + buscar + "%' or de.fechaHora like '%" + buscar + "%' ";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
