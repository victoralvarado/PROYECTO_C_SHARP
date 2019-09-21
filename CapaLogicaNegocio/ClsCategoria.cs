using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;

using CapaEnlaceDatos;

namespace CapaLogicaNegocio
{
    public class ClsCategoria
    {
        private ClsConexion Cone = new ClsConexion();

        //DECLARACION DE VARAIBLES
        private Int32 vIdCategoria;
        private String vNombreCategoria;

        public Int32 idCategoria
        {
            get { return vIdCategoria; }
            set { vIdCategoria = value; }
        }

        public String nombreCategoria
        {
            get { return vNombreCategoria; }
            set { vNombreCategoria = value; }
        }
        public DataTable Listar()
        {
            return Cone.Listado("ListarCategoria", null);
        }

    }
}
