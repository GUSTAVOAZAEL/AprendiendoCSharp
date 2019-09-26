using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = "1234";
            Console.WriteLine(num.GetType().ToString());

            int num1 = Convert.ToInt32(num);
            Console.WriteLine(num1.GetType().ToString());

            Double prueba = Convert.ToDouble(num1);
            Console.WriteLine(prueba.GetType().ToString());



            Console.ReadLine();
        

        }
    }
}
