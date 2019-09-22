using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    public class Categoria
    {
        private ClsCategoria categoria = new ClsCategoria();

        public DataTable ListarCategoria()
        {

            DataTable tabla = new DataTable();
            tabla = categoria.Listar();
            return tabla;
        }
        public void RegistrarCategoria(string nombreCategoria)
        {

            categoria.Registrar(nombreCategoria);
        }

        public void ModificarCategoria(string idCategoria, string nombreCategoria)
        {
            categoria.Modificar(Convert.ToInt32(idCategoria), nombreCategoria);
        }

        public void EliminarCategoria(string id)
        {

            categoria.Eliminar(Convert.ToInt32(id));
        }
    }
}
