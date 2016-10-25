using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public class Avion :Vehiculo , IAFIP, IARBA
    {
        private double _velocidadMaxima;

        


        public Avion(double precio, double velocidadMaxima) :base(precio)
        {
            this._velocidadMaxima = velocidadMaxima;
        }



        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio en avion:"+ this._precio );
        }


        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            MostrarPrecio();
            sb.AppendLine("Velocidad Maxima: " + this._velocidadMaxima);

            return sb.ToString();
        }




        public double CalcularImpuesto()
        {
            return base._precio * 1.28;
        }




        public double ObtenerImpuesto
        {
            get { return CalcularImpuesto(); }
        }
    }
}
