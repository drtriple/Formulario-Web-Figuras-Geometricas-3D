using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libClasif3D
{
    public abstract class clsIrregular : clsPoliedro
    {
        protected float fltLadoB;
        protected float fltAltura;

        public float Lado_b { set { fltLadoB = value; } }
        public float Altura { set { fltAltura = value; } }
    }
}
