﻿using CapaEnlaceDatos;
using System;
using System.Data;
using System.Windows.Forms;
/*
* @Nombre de Clase: Herramienta.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaLogicaNegocio
{
    public class Herramienta
    {
        private ClsHerramienta herramienta = new ClsHerramienta();

        public DataTable ListarCategoriaCombo()
        {
            DataTable datos = new DataTable();
            datos = herramienta.ComboCategoria();
            return datos;
        }

        public void ListarTotalH(Label lbl)
        {
            herramienta.listarTotalH(lbl);
        }

        public void ListarTotalNU(Label nueva)
        {
            herramienta.listarTotalNU(nueva);
        }

        public void ListarTotalNO(Label normal)
        {
            herramienta.listarTotalNO(normal);
        }

        public void ListarTotalDE(Label defectusa)
        {
            herramienta.listarTotalDE(defectusa);
        }

        public DataTable ListarHerramienta()
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.Listar();
            return tabla;
        }

        public DataTable ListarHerramientasPPrestamo()
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.ListarHP();
            return tabla;
        }

        public DataTable ListarHerramientaCUS(string categoria)
        {
            DataTable tabla2 = new DataTable();
            tabla2 = herramienta.ListarCUS(categoria);
            return tabla2;
        }

        public DataTable ListarHerramientaCUN(string categoria)
        {
            DataTable tabla3 = new DataTable();
            tabla3 = herramienta.ListarCUN(categoria);
            return tabla3;
        }


        public DataTable FiltrarHerramienta(string campo, string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.Filtrar(campo, buscar);
            return tabla;
        }

        public DataTable FiltrarHerramientaTC(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.FiltrarTC(buscar);
            return tabla;
        }

        public DataTable FiltrarHerramientaTCPrestamo(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.FiltrarTCPrestamo(buscar);
            return tabla;
        }

        public void RegistrarHerramienta(string nombreHerramienta, string idCategoria, string uso, string estado)
        {
            herramienta.Registrar(nombreHerramienta, Convert.ToInt32(idCategoria), uso, estado);
        }

        public void ModificarHerramienta(string nombreHerramienta, string idCategoria, string uso, string estado, string idHerramienta)
        {
            herramienta.Modificar(nombreHerramienta, Convert.ToInt32(idCategoria), uso, estado, Convert.ToInt32(idHerramienta));
        }

        public void EliminarHerramienta(string idHerramienta)
        {
            herramienta.Eliminar(Convert.ToInt32(idHerramienta));
        }
    }
}
