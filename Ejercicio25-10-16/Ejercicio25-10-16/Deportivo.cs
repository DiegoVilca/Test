using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio25_10_16
{
    public class Deportivo :Auto , IAFIP, IARBA
    {

        protected int _caballoDeFuerza;

        public Deportivo(double precio, string  patente, int hp) :base(precio, patente)
        {
            this._caballoDeFuerza = hp;
        }


        public override void MostrarPatente()
        {
            Console.WriteLine("patente: " + base._patente);
        }



        double IAFIP.CalcularImpuesto()
        {
            return this._precio * 1.28;
        }

       
    
        double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.23;
        }
}
}
