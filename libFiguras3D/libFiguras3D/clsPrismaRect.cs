using libClasif3D;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFiguras3D
{
    public class clsPrismaRect : clsPrisma
    {
        #region Constructores sobre cargados
        public clsPrismaRect() { 
            fltLadoA = 0; 
            fltLadoB = 0; 
            fltAltura = 0; 
            fltArea = 0; 
            fltVolumen = 0; 
            strError = ""; 
        }
        public clsPrismaRect(float _LadoA, float _LadoB, float _Altura)
        {
            fltLadoA = _LadoA;
            fltLadoB = _LadoB;
            fltAltura = _Altura;
            fltArea = 0;
            fltVolumen = 0;
            strError = string.Empty;
        }
        #endregion

        #region Metodos Privados
        private bool Validar()
        {
            if (fltLadoA <= 0)
            {
                strError = " Lado A no Válido";
                return false;
            }
            if (fltLadoB <= 0)
            {
                strError = "Lado B no Válido";
                return false;
            }
            if (fltAltura <= 0)
            {
                strError = "Altura no Válido";
                return false;
            }
            return true;
        }
        #endregion

        #region Metodos Publicos - Polimorfismo
        public override bool hallarArea()
        {
            if (!Validar()) return false;
            fltArea = 2 * ((fltLadoA * fltLadoB) + (fltLadoA * fltAltura) + (fltLadoB * fltAltura));
            return true;
        }

        public override bool hallarVolumen()
        {
            if (!Validar()) return false;
            fltVolumen = fltLadoA * fltLadoB * fltAltura;
            return true;
        }
        #endregion
    }
}