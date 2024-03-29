﻿using CapaEnlaceDatos;
using System;
using System.Data;
using System.Windows.Forms;
/*
* @Nombre de Clase: DetallePrestamo.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaLogicaNegocio
{
    public class DetallePrestamo
    {
        private ClsDetallePrestamo detalleprestamo = new ClsDetallePrestamo();

        public DataTable ListarDetallePrestamo()
        {
            DataTable tabla = new DataTable();
            tabla = detalleprestamo.Listar();
            return tabla;
        }

        public DataTable ListarPP()
        {
            DataTable tabla1 = new DataTable();
            tabla1 = detalleprestamo.ListarPP();
            return tabla1;
        }

        public void listarTotalDP(Label lbl)
        {
            detalleprestamo.listarTotalDP(lbl);
        }

        public void RegistrarDetallePrestamo(string idPersonal, string idHerramienta, string fechaHora, string prespor)
        {
            detalleprestamo.Registrar(Convert.ToInt32(idPersonal), Convert.ToInt32(idHerramienta), fechaHora, prespor);
        }

        public void ModificarUso(string uso, string estado, string idHerramienta)
        {
            detalleprestamo.Modificar(uso, estado, Convert.ToInt32(idHerramienta));
        }

        public DataTable filtrarPrestamo(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = detalleprestamo.filtrarPrestamo(buscar);
            return tabla;
        }

        public DataTable filtrarPP(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = detalleprestamo.filtrarPP(buscar);
            return tabla;
        }
    }
}
