using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public abstract class Vehiculo
    {
        protected double _precio;




        public Vehiculo(double precio)
        {
            this._precio = precio;
        }


        public abstract void MostrarPrecio();

        public virtual string Mostrar()
        {
            string mensaje = "Precio: "+this._precio.ToString();

            return mensaje;
        }

        

    }
}
