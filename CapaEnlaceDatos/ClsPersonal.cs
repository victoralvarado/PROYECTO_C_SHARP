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
    public class ClsPersonal
    {
        private ClsConexion conexion = new ClsConexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        DataTable tabla1 = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Listar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarPersonal";
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

        public DataTable ListarPrestamoPersonal()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarPrestamoPersonal";
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

        public void listarTotalP(Label lbl)
        {
            int dat;
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select count (idCategoria) from bodega.categoria";
            comando.CommandType = CommandType.Text;
            dat = (int)comando.ExecuteScalar();
            (lbl.Text) = dat.ToString();
            conexion.CerrarConexion();
        }

        //Buscar el COdigo del empleado que ha realizado prestamo
        public DataTable BuscarIDEMP(string cod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select p.id AS 'CÓDIGO EMPLEADO',p.nombre AS 'NOMBRES',p.apellido " +
                "AS 'APELLIDOS',d.idPrestamo AS 'CÓDIGO PRESTAMO',d.idherramienta " +
                "AS 'CÓDIGO HERRAMIENTA',h.nombreHerramienta AS 'HERRAMIENTA',d.fechaHora " +
                "AS 'FECHA-HORA',d.prespor AS 'ASIGNADA POR' from Bodega.personal p inner join " +
                "Bodega.detallePrestamo d on p.id = d.idPersonal inner join Bodega.herramienta h " +
                "on d.idHerramienta = h.idHerramienta where p.id = '" + cod + "'";
            comando.CommandType = CommandType.Text;
            leer = comando.ExecuteReader();
            tabla1.Load(leer);
            conexion.CerrarConexion();
            return tabla1;
        }

        public DataTable Filtrar(string buscar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select id as 'CÓDIGO PERSONAL', nombre as 'NOMBRES', apellido as 'APELLIDOS', edad as 'EDAD'  " +
                    "from Bodega.personal where id like '%" + buscar + "%' or nombre like '%" + buscar + "%' or apellido like '%" + buscar + "%' or " +
                    "edad like '%" + buscar+"%' ;";
                comando.CommandType = CommandType.Text;
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

        public DataTable FiltrarPP(string buscar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "SELECT id AS 'CÓDIGO PERSONAL', nombre AS " +
                    "'NOMBRES', apellido AS 'APELLIDOS' " +
                    "FROM bodega.personal WHERE id LIKE '%" + buscar + "%' OR  nombre " +
                    "LIKE '%" + buscar + "%' OR apellido LIKE '%" + buscar + "%'";
                comando.CommandType = CommandType.Text;
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

        public void Registrar(string nombre, string apellido, string edad)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RegistrarPersonal";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@edad", edad);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Modificar(string nombre, string apellido, string edad, int idPersonal)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ModificarPersonal";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@edad", edad);
                comando.Parameters.AddWithValue("@id", idPersonal);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Eliminar(int idPersonal)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarPersonal";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@id", idPersonal);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error :" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
