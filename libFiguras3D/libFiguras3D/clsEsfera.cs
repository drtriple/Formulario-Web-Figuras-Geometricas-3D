using libClasif3D;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libFiguras3D
{
    public class clsEsfera : clsRedondo
    {
        public clsEsfera() { fltRadio = 0; fltArea = 0; fltVolumen = 0; strError = ""; }

        private bool Validar() => fltRadio > 0;

        public override bool hallarArea()
        {
            if (!Validar()) return false;
            fltArea = 4 * (float)Math.PI * fltRadio * fltRadio;
            return true;
        }

        public override bool hallarVolumen()
        {
            if (!Validar()) return false;
            fltVolumen = (4f / 3f) * (float)Math.PI * (fltRadio * fltRadio * fltRadio);
            return true;
        }
    }
}
