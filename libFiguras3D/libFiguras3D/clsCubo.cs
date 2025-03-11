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
        public clsCubo() { fltLadoA = 0; fltArea = 0; fltVolumen = 0; strError = ""; }

        private bool Validar() => fltLadoA > 0;

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
    }
}
