using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
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
    }
}
