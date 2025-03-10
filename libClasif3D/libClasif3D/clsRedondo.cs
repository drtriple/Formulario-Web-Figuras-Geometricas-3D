using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libFigura3D;

namespace libClasif3D
{
    public abstract class clsRedondo : clsFigura3D
    {
        protected float fltRadio;
        public float Radio { set { fltRadio = value; } }
    }
}
