﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
/*
* @Nombre de Clase: ClsHerramienta.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaEnlaceDatos
{
    public class ClsHerramienta
    {
        private ClsConexion conexion = new ClsConexion();
        SqlDataReader leer;
        SqlDataReader leer2;
        DataTable tabla = new DataTable();
        DataTable tabla2 = new DataTable();
        DataTable tabla3 = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable ComboCategoria()
        {
            DataTable datos = new DataTable();
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarCategoriaCMB";
                comando.CommandType = CommandType.StoredProcedure;
                leer = comando.ExecuteReader();
                datos.Load(leer);
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return datos;
        }

        public DataTable Listar()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarHerramienta";
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

        public DataTable ListarHP()
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ListarHerramientasPPrestamo";
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

        public void listarTotalH(Label lbl)
        {
            try
            {
                int dat;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select count (idHerramienta) from bodega.herramienta";
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

        public void listarTotalNU(Label nueva)
        {
            try
            {
                int dat;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select count (idHerramienta) from bodega.herramienta where estado='NUEVA'";
                comando.CommandType = CommandType.Text;
                dat = (int)comando.ExecuteScalar();
                (nueva.Text) = dat.ToString();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void listarTotalNO(Label normal)
        {
            try
            {
                int dat;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select count (idHerramienta) from bodega.herramienta where estado='NORMAL'";
                comando.CommandType = CommandType.Text;
                dat = (int)comando.ExecuteScalar();
                (normal.Text) = dat.ToString();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void listarTotalDE(Label defectuosa)
        {
            try
            {
                int dat;
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select count (idHerramienta) from bodega.herramienta where estado='DEFECTUOSA'";
                comando.CommandType = CommandType.Text;
                dat = (int)comando.ExecuteScalar();
                (defectuosa.Text) = dat.ToString();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable ListarCUS(string categoria)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', " +
                    " h.idCategoria AS 'CÓDIGO CATEGORÍA', h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' " +
                    " from Bodega.herramienta h inner join Bodega.categoria c on h.idCategoria = c.idCategoria " +
                    " where c.nombreCategoria = @categoria and h.uso = 'SI' ";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@categoria", categoria);
                leer = comando.ExecuteReader();
                tabla2.Load(leer);
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla2;
        }
        public DataTable ListarCUN(string categoria)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', " +
                    "h.idCategoria AS 'CÓDIGO CATEGORÍA', h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' " +
                    "from Bodega.herramienta h inner join Bodega.categoria c on h.idCategoria = c.idCategoria " +
                    "where c.nombreCategoria = @categoria and h.uso = 'NO' ";
                comando.CommandType = CommandType.Text;
                comando.Parameters.AddWithValue("@categoria", categoria);
                leer2 = comando.ExecuteReader();
                tabla3.Load(leer2);
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return tabla3;
        }

        public DataTable Filtrar(string campo, string buscar)
        {
            //Buscar por un campo especifico de la tabla
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.idCategoria AS 'CÓDIGO CATEGORÍA', " +
                    "h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' from Bodega.herramienta h inner join Bodega.categoria c on h.idCategoria = c.idCategoria " +
                    "WHERE " + campo + " LIKE @buscar ";
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

        public DataTable FiltrarTCPrestamo(string buscar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.estado AS 'ESTADO' " +
                    "from Bodega.herramienta h where h.uso = 'NO' and (h.estado = 'NUEVA' or h.estado = 'NORMAL') and (h.idHerramienta like @buscar or h.nombreHerramienta " +
                    "like @buscar or h.estado like @buscar ) order by h.nombreHerramienta ";
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

        public DataTable FiltrarTC(string buscar)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "select h.idHerramienta AS 'CÓDIGO HERRAMIENTA', h.nombreHerramienta AS 'NOMBRE HERRAMIENTA', h.idCategoria " +
                    "AS 'CÓDIGO CATEGORÍA', h.uso AS 'USO', h.estado AS 'ESTADO', c.nombreCategoria AS 'CATEGORÍA' " +
                    "from Bodega.herramienta h inner " +
                    "join Bodega.categoria c on h.idCategoria = c.idCategoria " +
                    "WHERE h.idHerramienta LIKE @buscar or h.nombreHerramienta LIKE @buscar or h.idCategoria " +
                    "LIKE @buscar or h.uso LIKE @buscar or h.estado LIKE @buscar or c.nombreCategoria " +
                    "LIKE @buscar ";
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

        public void Registrar(string nombreHerramienta, int idCategoria, string uso, string estado)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "RegistrarHerramienta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreHerramienta", nombreHerramienta);
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);
                comando.Parameters.AddWithValue("@uso", uso);
                comando.Parameters.AddWithValue("@estado", estado);
                comando.ExecuteNonQuery();
                comando.Parameters.Clear();
                conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en:" + e + "", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Modificar(string nombreHerramienta, int idCategoria, string uso, string estado, int idHerramienta)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "ModificarHerramienta";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreHerramienta", nombreHerramienta);
                comando.Parameters.AddWithValue("@idCategoria", idCategoria);
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

        public void Eliminar(int idHerramienta)
        {
            try
            {
                comando.Connection = conexion.AbrirConexion();
                comando.CommandText = "EliminarHerramienta";
                comando.CommandType = CommandType.StoredProcedure;
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
    }
}
