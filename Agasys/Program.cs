using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agasys
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Elige una opcion: ");
                Console.WriteLine("\n1.-Edad: " + "\n2.-Votaciones: " + "\n3.-Calcula Sueldo:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Edades.Mayores();
                        break;
                    case 3:
                        Empleado.CalculaSueldo();
                        break;
                }
                Console.ReadKey();
            } while (opcion != 5);
        }
    }
}
