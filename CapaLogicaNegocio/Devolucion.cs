using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* @Nombre de Clase: Devolucion.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaLogicaNegocio
{
    public class Devolucion
    {
        private ClsDevolucion devolucion = new ClsDevolucion();
        public void EliminarPrestamo(string idPrestamo)
        {
            devolucion.Eliminar(Convert.ToInt32(idPrestamo));
        }

        public DataTable ListarDevolucion()
        {
            DataTable tabla = new DataTable();
            tabla = devolucion.Listar();
            return tabla;
        }

        public void RegistrarDevolucion(string idHerramienta, string idPersonal, string estadoEntre, string fechaHora, string prespor, string recibidaPor)
        {
            devolucion.Registrar(Convert.ToInt32(idHerramienta), Convert.ToInt32(idPersonal), estadoEntre, fechaHora, prespor, recibidaPor);
        }

        public DataTable FiltrarDevolucion(string campo, string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = devolucion.Filtrar(campo, buscar.Replace("'", ""));
            return tabla;
        }

        public DataTable FiltrarDevolucionTC(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = devolucion.FiltrarTC(buscar.Replace("'", ""));
            return tabla;
        }
    }
}
