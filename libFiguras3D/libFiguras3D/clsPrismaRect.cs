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
        public clsPrismaRect() { fltLadoA = 0; fltLadoB = 0; fltAltura = 0; fltArea = 0; fltVolumen = 0; strError = ""; }

        private bool Validar() => fltLadoA > 0 && fltLadoB > 0 && fltAltura > 0;

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
    }
}
