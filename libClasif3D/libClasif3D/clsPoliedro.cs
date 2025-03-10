using libFigura3D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libClasif3D
{
    public abstract class clsPoliedro : clsFigura3D
    {
        protected float fltLadoA;
        public float Lado_a { set { fltLadoA = value; } }
    }
}
