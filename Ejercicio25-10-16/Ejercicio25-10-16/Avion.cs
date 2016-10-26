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


        //implementacion explicita

        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 1.33;
        }

        double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.27;
        }




        //como tengo dos metodos de igual nombre pero distinta interfaz, si declaro uno implicito el otro debera ser explicito

        //public double CalcularImpuesto()
        //{
        //    throw new NotImplementedException();
        //}

        //double IARBA.CalcularImpuesto()
        //{
        //    throw new NotImplementedException();
        //}

        //Si implementara las interfaces de manera implicita deberia castear en el program Ej: ((IAFIP)avionUno).CalcularImpuesto() (No confirmado, faltaria aprobarlo en el main)
        
    }
}
