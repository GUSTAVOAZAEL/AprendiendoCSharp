using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acumulado
{
    class Program
    {
        static void Main(string[] args)
        {
            string _num;
            int num;
            int acum = 0;

            Console.WriteLine("Introduzca los enteros a acumular.");
            Console.WriteLine("Para salir, solo dejar vacio y precionar INTRO.");
            Console.WriteLine("");

            while (true)
            {
                Console.Write("Dame un numero entero: ");
                _num = Console.ReadLine();
                if (_num == "")
                {
                    break;
                }
                else
                {
                    if (int.TryParse(_num, out num))
                    {
                        acum += num;
                        Console.WriteLine(String.Format("Monto acumulado: {0}", acum));
                    }
                    else
                    {
                        Console.WriteLine("El dato proporcionado no es un numero entero.");
                        Console.WriteLine("Intenta de nuevo.");
                    }
                }
            }
            Console.WriteLine("");
            Console.WriteLine("Preciona una INTRO para salir.");
            Console.ReadKey();
        }
    }
}
