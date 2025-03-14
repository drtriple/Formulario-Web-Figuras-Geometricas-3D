using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace libFigura3D
{
    public abstract class clsFigura3D
    {
        #region Atributos
        protected float fltArea;
        protected float fltVolumen;
        protected string strError;
        #endregion

        #region Propiedades
        public float Area
        {
            get => fltArea;
        }
        public float Volumen
        {
            get => fltVolumen;
        }
        public string Error
        {
            get => strError;
        }
        #endregion

        #region Metodos Publicos
        public abstract bool hallarArea();
        public abstract bool hallarVolumen();
        #endregion
    }
}
