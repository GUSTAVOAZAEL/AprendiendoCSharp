using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nombre
{
    class Program
    {
        static void Main(string[] args)
        {
            string nom;
            string aps;

            Console.Write("Escribe un nombre:  ");
            nom = Console.ReadLine();

            Console.Write("Escribe los apellidos:  ");
            aps = Console.ReadLine();

            nom = nom.ToUpper();
            aps = aps.ToUpper();

            StringBuilder nomCompl = new StringBuilder(nom);
            nomCompl.Append("  ");
            nomCompl.Append(aps);

            Console.Write(nomCompl);

            Console.WriteLine("  ");
            Console.Write("Preciona una tecla...");
            Console.ReadKey();


        }
    }
}
