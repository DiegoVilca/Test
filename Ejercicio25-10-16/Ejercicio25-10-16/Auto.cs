using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public abstract class Auto : Vehiculo
    {

        protected string _patente;

        public Auto(double precio, string patente) : base(precio)
        {
            this._patente = patente;
        }


        public abstract void MostrarPatente();



        public override void MostrarPrecio()
        {
            Console.WriteLine("Precio en Auto: "+ this._precio);
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            MostrarPrecio();
            sb.AppendLine("Patente: " + this._patente);

            return sb.ToString();
        }
    }
}
