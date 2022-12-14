using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salinas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("\n1.-Factorial: " + "\n2.-Votaciones: " + "\n3.-Calcula Sueldo:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Factorial.Numeros();
                        break;
                    //case 3:
                    //    Empleado.CalculaSueldo();
                    //    break;
                }
                Console.ReadKey();
            } while (opcion != 5);
        }
    }
}
