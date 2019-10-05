using CapaEnlaceDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogicaNegocio
{
    public class Usuario
    {
        private ClsUsuario usuario = new ClsUsuario();

        public DataTable ListarUsuario()
        {

            DataTable tabla = new DataTable();
            tabla = usuario.Listar();
            return tabla;
        }

        public DataTable ListarTUsuario()
        {

            DataTable tabla = new DataTable();
            tabla = usuario.ListarTU();
            return tabla;
        }

        public DataTable FiltrarUsuario(string buscar)
        {
            DataTable tabla = new DataTable();
            tabla = usuario.Filtrar(buscar);
            return tabla;
        }
        public void RegistrarUsuario(string userName, string password, string tipoUsuario)
        {

            usuario.Registrar(userName, password, tipoUsuario);
        }

        public void ModificarUsuario(string idUsuario, string userName, string password, string tipoUsuario)
        {
            usuario.Modificar(Convert.ToInt32(idUsuario), userName, password, tipoUsuario);
        }

        public void EliminarUsuario(string idUsuario)
        {

            usuario.Eliminar(Convert.ToInt32(idUsuario));
        }
    }
}
