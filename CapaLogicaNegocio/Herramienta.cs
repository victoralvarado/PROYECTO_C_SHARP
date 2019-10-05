using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public DataTable ListarHerramienta()
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.Listar();
            return tabla;
        }

        public DataTable FiltrarHerramienta(string campo, string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = herramienta.Filtrar(campo, buscar);
            return tabla;
        }

            public void RegistrarHerramienta(string nombreHerramienta, string idCategoria, string uso, string estado)
        {
            herramienta.Registrar(nombreHerramienta, Convert.ToInt32(idCategoria),uso,estado);
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
