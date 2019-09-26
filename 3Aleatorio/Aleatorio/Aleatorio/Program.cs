using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    class Program
    {
        static public float numX = 50F;  //variable de clase
        
        static void Main(string[] args)
        {
            float numY = 0F;            //variable local
            Random numAle = new Random();
            numY = (float)numAle.Next(1, 11);

            Console.WriteLine(String.Format("La suma de {0} y {1} es {2}", numX, numY, numX + numY));
            Console.ReadLine();


        }
    }
}
