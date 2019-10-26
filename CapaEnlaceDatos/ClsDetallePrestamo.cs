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


    }
}
