using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(String.Format("Tabla del {0}: ", i));
                Console.WriteLine();

                for (int o = 1; o <= 10; o++)
                {
                    Console.WriteLine(String.Format("{0} x {1} = {2}", i, o, i * o));
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Preciona una tecla...");
            Console.ReadKey();
        }
    }
}
