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
            Deportivo deportivoUno = new Deportivo(100, "fgh654", 500);
            Carreta carretaUno = new Carreta(100);
            Comercial comercialUno = new Comercial(100, 5000);


            //Los metodos de las interfaces son por defecto privados pero por definicion publicos
            //Forma de acceder CalcularImpuesto()
            Console.WriteLine(((IAFIP)avionUno).CalcularImpuesto());
            //Asi no se puede acceder a CalcularImpuesto()
            //Console.WriteLine(avionUno.CalcularImpuesto());



            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionUno));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(avionUno));

            Console.WriteLine(Gestion.MostrarImpuestoNacional(deportivoUno));
            Console.WriteLine(Gestion.MostrarImpuestoProvincial(deportivoUno));

            Console.WriteLine(Gestion.MostrarImpuestoProvincial(carretaUno));

            Console.WriteLine(Gestion.MostrarImpuestoProvincial(comercialUno));


            Console.ReadKey();
        }
    }
}
