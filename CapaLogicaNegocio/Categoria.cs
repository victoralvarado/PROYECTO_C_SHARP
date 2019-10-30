using System;
using System.Data;
using System.Windows.Forms;
using CapaEnlaceDatos;
/*
 * @Nombre de Clase: Categoria.
 * @Version: 1.0.
 * @Copyright: ToolSoft.
 * @Author Victor, Adrian, Andrea, Diego
 */
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

        public DataTable FiltrarCat(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla =categoria.FiltrarCat(buscar);
            return tabla;
        }

        public void ListarTotalC(Label lbl)
        {
            categoria.listarTotalC(lbl);
        }

        public void RegistrarCategoria(string nombreCategoria)
        {
            categoria.Registrar(nombreCategoria);
        }

        public void ModificarCategoria(string idCategoria, string nombreCategoria)
        {
            categoria.Modificar(Convert.ToInt32(idCategoria), nombreCategoria);
        }

        public void EliminarCategoria(string idCategoria)
        {
            categoria.Eliminar(Convert.ToInt32(idCategoria));
        }
    }
}
