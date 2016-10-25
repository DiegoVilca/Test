using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio25_10_16;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avionUno = new Avion(100, 10000);

            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionUno));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(avionUno));

            Console.ReadKey();
        }
    }
}
