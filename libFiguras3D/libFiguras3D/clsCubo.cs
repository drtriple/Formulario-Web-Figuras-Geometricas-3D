using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libClasif3D;
using libFigura3D;

namespace libFiguras3D
{
    public class clsCubo : clsRegular
    {
        #region Constructores Sobrecargados
        public clsCubo() { 
            fltLadoA = 0;
            fltArea = 0; 
            fltVolumen = 0; 
            strError = string.Empty; 
        }

        public clsCubo(float _LadoA) { 
            fltLadoA = _LadoA; 
            fltArea = 0; 
            fltVolumen = 0;
            strError = string.Empty; 
        }
        #endregion

        #region Metodos Privados
        private bool Validar()
        {
            if (fltLadoA < 0)
            {
                strError = " Lado A no Válido";
                return false;
            }
            return true;
        }
        #endregion

        #region Metodos Publicos - Polimorfismo
        public override bool hallarArea()
        {
            if (!Validar()) return false;
            fltArea = 6 * (fltLadoA * fltLadoA);
            return true;
        }

        public override bool hallarVolumen()
        {
            if (!Validar()) return false;
            fltVolumen = fltLadoA * fltLadoA * fltLadoA;
            return true;
        }
        #endregion
    }
}
