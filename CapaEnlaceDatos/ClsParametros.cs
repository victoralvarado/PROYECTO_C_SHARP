using System;

using System.Data;

namespace CapaEnlaceDatos
{
    public class ClsParametros
    {
        //PARAMETROS
        #region PARAMETROS GENERALES
        private String pNombre;
        private Object pValor;
        private SqlDbType pTipoDato;
        private ParameterDirection pDireccion;
        private int pTamaño;

        public String Nombre
        {
            get { return pNombre; }
            set { pNombre = value; }
        }

        public Object Valor
        {
            get { return pValor; }
            set { pValor = value; }
        }

        public SqlDbType TipoDato
        {
            get { return pTipoDato; }
            set { pTipoDato = value; }
        }


        public ParameterDirection Direccion
        {
            get { return pDireccion; }
            set { pDireccion = value; }
        }


        public int Tamaño
        {
            get { return pTamaño; }
            set { pTamaño = value; }
        }
        #endregion

        //CONSTRUCTORES
        #region CONSTRUCTORES
        //C.ENTRADA
        public ClsParametros(String objNombre, Object objValor)
        {
            pNombre = objNombre;
            pValor = objValor;
            pDireccion = ParameterDirection.Input;
        }
        //C.SALIDA
        public ClsParametros(String objNombre, Object objValor, SqlDbType objTipoDato, ParameterDirection objDireccion, int objTamaño)
        {
            pNombre = objNombre;
            pValor = objValor;
            pTipoDato = objTipoDato;
            pDireccion = objDireccion;
            pTamaño = objTamaño;
        }
        #endregion
    }
}
