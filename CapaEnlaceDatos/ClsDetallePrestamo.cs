using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsDetallePrestamo.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaEnlaceDatos
{
    public class ClsDetallePrestamo
    {
        #region VARIABLES LOCALES
        private ClsConexion conexion = new ClsConexion();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tabla1 = new DataTable();
        SqlCommand comando = new SqlCommand();
        #endregion

        //METODO PARA LISTAR DETALLE PRESTAMO
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
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;

        }


        //METODO PARA LISTAR TOTAL DE PRESTAMOS
        public void listarTotalDP(Label lbl)
        {
            try
            {
                int dat;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select count(*) from bodega.detalleprestamo";
                comando.CommandType = CommandType.Text;
                dat = (int)comando.ExecuteScalar();
                (lbl.Text) = dat.ToString();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //METODO PARA LISTAR PERSONAL QUE HA HECHO PRESTAMO
        public DataTable ListarPP()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarPrestamoPersonal";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                tabla1.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla1;
        }


        //METODO PARA REGISTRAR DETALLE PRESTAMO
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
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable filtrarPrestamo(string buscar)
        {
            try
            {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select p.id as 'CÓDIGO EMPLEADO',p.nombre as 'NOMBRES',p.apellido as 'APELLIDOS'," +
                "d.idPrestamo as 'CÓDIGO PRÉSTAMO',d.idherramienta as 'CÓDIGO HERRAMIENTA',h.nombreHerramienta as 'HERRAMIENTA'," +
                " d.fechaHora as 'FECHA-HORA',d.prespor as 'ASIGNADA POR' from bodega.personal p inner join bodega.detallePrestamo d " +
                "on p.id = d.idPersonal inner join bodega.herramienta h on d.idHerramienta=h.idHerramienta " +
                "where p.id like @buscar or p.nombre like @buscar or p.apellido like @buscar or d.idPrestamo like @buscar or d.idHerramienta " +
                "like @buscar or h.idHerramienta like @buscar or h.idCategoria like @buscar or d.fechaHora like @buscar or d.prespor like @buscar " +
                "or h.nombreHerramienta like @buscar ";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@buscar", buscar);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }

        public DataTable filtrarPP(string buscar)
        {
            try
            {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT distinct p.id AS 'CÓDIGO EMPLEADO', p.nombre+ ' ' +p.apellido AS 'NOMBRE COMPLETO' FROM Bodega.personal p inner join" +
                " bodega.detallePrestamo d on p.id = d.idPersonal where p.id like @buscar or p.nombre+ ' ' +p.apellido like @buscar";
            comando.CommandType = CommandType.Text;
            comando.Parameters.AddWithValue("@buscar", buscar);
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            comando.Parameters.Clear();
            conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla;
        }


    }
}
