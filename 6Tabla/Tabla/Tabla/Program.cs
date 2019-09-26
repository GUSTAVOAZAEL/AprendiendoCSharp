using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabla
{
    class Program
    {
        static void Main(string[] args)
        {
            string _num;
            int num;

            Console.Write("Dame un numero del 1 al 9 para generar la tabla:  ");
            _num = Console.ReadLine();
            num = Convert.ToInt32(_num);

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(String.Format("{0}  x  {1} = {2}", num, i, num * i));

            }
            Console.WriteLine("");
            Console.WriteLine("Preciona una tecla...");
            Console.ReadKey();
        }
    }
}
