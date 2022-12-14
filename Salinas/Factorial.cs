using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salinas
{
    class Factorial
    {
        public static void Numeros()
        {
            Console.WriteLine("Ingrese el numero");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine("El factorial del numero es: " + factorial);
            Console.ReadLine();
        }
    }
}
