using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

namespace CapaEnlaceDatos
{
    public class ClsConexion
    {
        public SqlConnection conexion = new SqlConnection("Server=DESKTOP-4BS9RLI;DataBase=Bodega;Integrated Security=SSPI");

        public void Conectar()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();
        }

        public void Desconectar()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();
        }

        public DataTable Listado(String NombreSP, List<ClsParametros> lst)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da;
            try
            {
                Conectar();
                da = new SqlDataAdapter(NombreSP, conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                    }
                }
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
            return dt;
        }

        public void EjecutarSP(String NombreSP, ref List<ClsParametros> lst)
        {
            SqlCommand cmd;
            try
            {
                Conectar();
                cmd = new SqlCommand(NombreSP, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].Direccion == ParameterDirection.Input)
                            cmd.Parameters.AddWithValue(lst[i].Nombre, lst[i].Valor);
                        if (lst[i].Direccion == ParameterDirection.Output)
                            cmd.Parameters.Add(lst[i].Nombre, lst[i].TipoDato, lst[i].Tamaño).Direction = ParameterDirection.Output;
                    }
                    cmd.ExecuteNonQuery();
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (cmd.Parameters[i].Direction == ParameterDirection.Output)
                            lst[i].Valor = cmd.Parameters[i].Value;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            Desconectar();
        }
    }
}
