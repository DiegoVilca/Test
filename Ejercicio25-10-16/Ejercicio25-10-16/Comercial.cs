using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public class Comercial : Avion, IARBA
    {

        public Comercial(double precio, double velocidadMaxima) :base(precio, velocidadMaxima)
        {

        }





        double IARBA.CalcularImpuesto()
        {
            return base._precio * 1.25;
        }
    }
}
