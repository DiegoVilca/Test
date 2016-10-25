using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public class Carreta : Vehiculo, IARBA
    {

        public Carreta(double precio) : base(precio)
        {

        }

        

        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio en carreta: " + this._precio);
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            MostrarPrecio();
            

            return sb.ToString();
        }



        public double CalcularImpuesto()
        {
            return this._precio * 1.18;
        }
    }
}
