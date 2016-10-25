using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public class Comercial : Avion, IARBA
    {
        
        public double CalcularImpuesto()
        {
            return base._precio * 1.18;
        }
        
    }
}
