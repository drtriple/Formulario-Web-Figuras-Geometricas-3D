using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libClasif3D;
using libFigura3D;

namespace libFiguras3D
{
    public class clsEsfera : clsRedondo
    {
        public clsEsfera() { 
            fltRadio = 0; 
            fltArea = 0;
            fltVolumen = 0; 
            strError = ""; 
        }
        public clsEsfera(float _Radio) { 
            fltRadio = _Radio;
            fltArea = 0;
            fltVolumen = 0; 
            strError = ""; 
        }

        private bool Validar()
        {
            if (fltRadio < 0)
            {
                strError = "Radio no Válido";
                return false;
            }
            return true;
        }

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
