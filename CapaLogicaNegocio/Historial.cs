using CapaEnlaceDatos;
using System;
using System.Data;
/*
* @Nombre de Clase: Historial.
* @Version: 1.0.
* @Copyright: ToolSoft.
* @Author Victor, Adrian, Andrea & Diego
*/
namespace CapaLogicaNegocio
{
    public class Historial
    {
        private ClsHistorial historial = new ClsHistorial();

        public DataTable ListarHistorial()
        {
            DataTable tabla = new DataTable();
            tabla = historial.Listar();
            return tabla;
        }

        public void RegistrarHistorial(string idPersonal, string idHerramienta, string fechaHora, string prespor)
        {
            historial.Registrar(Convert.ToInt32(idPersonal), Convert.ToInt32(idHerramienta), fechaHora, prespor);
        }

        public DataTable FiltrarHistorial(string campo, string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = historial.Filtrar(campo, buscar.Replace("'", ""));
            return tabla;
        }

        public DataTable FiltrarHistorialTC(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = historial.FiltrarTC(buscar.Replace("'", ""));
            return tabla;
        }

    }
}
