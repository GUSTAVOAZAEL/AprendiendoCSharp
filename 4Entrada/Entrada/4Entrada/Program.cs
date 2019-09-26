using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Entrada
{
    class Program
    {
        static void Main(string[] args)
        {
            string datoP;
            int valor = 0;
            Console.Write("Teclea un dato: ");
            datoP = Console.ReadLine();

            if (int.TryParse(datoP, out valor))
            {
                Console.WriteLine(String.Format("El dato -{0}- es un entero. Gracias! :D", valor));
            }
            else
            {
                Console.WriteLine("No pude identificar el dato proporcionado. Intenta de nuevo.");
            }
            Console.WriteLine("");
            Console.WriteLine("Preciona una tecla...");
            Console.ReadKey();

        }
    }
}
