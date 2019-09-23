﻿using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Usuario
    {
        private ClsUsuario usuario = new ClsUsuario();

        public DataTable ListarUsuario()
        {

            DataTable tabla = new DataTable();
            tabla = usuario.Listar();
            return tabla;
        }
        public DataTable ListarTipo()
        {
            DataTable combo = new DataTable();
            combo = usuario.ListarTipoU();
            return combo;
        }
        public void RegistrarUsuario(string userName, string password, string tipoUsuario)
        {

            usuario.Registrar(userName, password, tipoUsuario);
        }

        public void ModificarUsuario(string idUsuario, string userName, string password, string tipoUsuario)
        {
            usuario.Modificar(Convert.ToInt32(idUsuario), userName, password, tipoUsuario);
        }

        public void EliminarUsuario(string idUsuario)
        {

            usuario.Eliminar(Convert.ToInt32(idUsuario));
        }
    }
}