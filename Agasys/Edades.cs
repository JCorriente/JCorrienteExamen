using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agasys
{
    public class Edades
    {
		public static void Mayores()
		{
            //int edad;
            Random random = new Random();
            //Console.WriteLine("Persona");
            for (int i = 0; i < 20; i++)
            {
                if (ramdom >= 18)
                {
                    Console.WriteLine(random.Next(1, 20));
                    Console.WriteLine("Es Mayor de Edad: ");
                }
                else 
               {
                    Console.WriteLine("Es Menor de Edad: ");
                }
                Console.ReadLine();
            //}


        }
    }
}
