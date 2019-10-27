﻿using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public void RegistrarDetallePrestamo(string idPersonal, string idHerramienta, string fechaHora, string prespor)
        {
            detalleprestamo.Registrar(Convert.ToInt32(idPersonal), Convert.ToInt32(idHerramienta), fechaHora, prespor);
        }

        public void ModificarUso(string uso, string estado, string idHerramienta)
        {
            detalleprestamo.Modificar(uso,estado, Convert.ToInt32(idHerramienta));
        }
    }
}