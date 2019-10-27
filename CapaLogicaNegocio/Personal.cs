﻿using CapaEnlaceDatos;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaLogicaNegocio
{
    public class Personal
    {
        private ClsPersonal personal = new ClsPersonal();

        public DataTable ListarPersonal()
        {
            DataTable tabla = new DataTable();
            tabla = personal.Listar();
            return tabla;
        }

        public DataTable ListarPP()
        {
            DataTable tabla = new DataTable();
            tabla = personal.ListarPrestamoPersonal();
            return tabla;
        }

        public void ListarTotalP(Label lbl)
        {
            personal.listarTotalP(lbl);
        }

        //public DataTable FiltrarPersonal(string buscar)
        //{
        //    DataTable tabla = new DataTable();
        //    tabla = personal.Filtrar(buscar);
        //    return tabla;
        //}

        public DataTable FiltrarPersonal(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = personal.FiltrarPP(buscar.Replace("'",""));
            return tabla;
        }

        public void RegistrarPersonal(string nombre, string apellido, string edad)
        {
            personal.Registrar(nombre, apellido, edad);
        }

        public void ModificarPersonal(string nombre, string apellido, string edad, string idPersonal)
        {
            personal.Modificar(nombre, apellido, edad, Convert.ToInt32(idPersonal));
        }

        public void EliminarPersonal(string idPersonal)
        {
            personal.Eliminar(Convert.ToInt32(idPersonal));
        }
    }
}