using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplo
{
    class Program
    {
        static void Main(string[] args)
        {
            string _num;
            int num;
            bool esMul3, esMul5, esMul7;

            try
            {
                Console.Write("Dame un numero entero:  ");
                _num = Console.ReadLine();
                num = Convert.ToInt32(_num);


                esMul3 = ((num % 3) == 0);
                esMul5 = ((num % 5) == 0);
                esMul7 = ((num % 7) == 0);

                if ((esMul3 & esMul5) | esMul7)
                {
                    Console.WriteLine("Correcto.");
                }
                else
                {
                    Console.WriteLine("Incorrecto.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("El dato proporcionado causa errores.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Preciona INTRO...");
                Console.ReadKey();
            }
        }
    }
}
