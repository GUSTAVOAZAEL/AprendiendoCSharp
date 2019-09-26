using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compara
{
    class Program
    {
        static void Main(string[] args)
        {
            string _num1, _num2;
            int num1, num2;

            Console.Write("Numero 1: ");
            _num1 = Console.ReadLine();

            Console.Write("Numero 2: ");
            _num2 = Console.ReadLine();

            num1 = Convert.ToInt32(_num1);
            num2 = Convert.ToInt32(_num2);

            if (num1 == num2)
            {
                Console.WriteLine(String.Format("Numeros proporcionados {0} y {1}. {2}",
                    num1, num2, "Numeros Iguales"));
            }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine(String.Format("Numeros proporcionados {0} y {1}. {2}",
                        num1, num2, "El primer numero es el mayor"));
                }
                else
                {
                        Console.WriteLine(String.Format("Numeros proporcionados {0} y {1}. {2}",
                            num1, num2, "El segundo numero es el mayor"));
                }

            }

            Console.WriteLine("");
            Console.WriteLine("Preciona una tecla...");
            Console.ReadKey();

        }
    }
}
