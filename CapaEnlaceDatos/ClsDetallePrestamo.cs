using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaEnlaceDatos
{
    public class ClsDetallePrestamo
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
                comando.CommandText = "ListarDetallePrestamo";
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
                comando.CommandText = "RegistrarDetallePrestamo";
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

        public void Modificar(string uso, string estado, int idHerramienta)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ModificarUso";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@uso", uso);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.Parameters.AddWithValue("@idHerramienta", idHerramienta);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable filtrarPrestamo(string buscar) 
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select p.id as 'CÓDIGO EMPLEADO',p.nombre as 'NOMBRES',p.apellido as 'APELLIDOS'," +
                "d.idPrestamo as 'CÓDIGO PRÉSTAMO',d.idherramienta as 'CÓDIGO HERRAMIENTA',h.nombreHerramienta as 'HERRAMIENTA'," +
                " d.fechaHora as 'FECHA-HORA',d.prespor as 'ASIGNADA POR' from bodega.personal p inner join bodega.detallePrestamo d " +
                "on p.id = d.idPersonal inner join bodega.herramienta h on d.idHerramienta=h.idHerramienta " +
                "where h.idHerramienta like '%" + buscar + "%' or h.idCategoria like '%" + buscar + "%' " +
                "or h.nombreHerramienta like '%" + buscar + "%' or  h.uso like '%" + buscar + "%' or h.estado like '%" + buscar+"%' " +
                "order by p.id asc;";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }


    }
}
