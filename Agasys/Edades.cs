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
            
            for (int i = 0; i < 20; i++)
            {
                Random random = new Random();
                int dato = random.Next();
                
                if (dato >= 18)
                {
                    Console.WriteLine(random.Next());
                    Console.WriteLine("Es Mayor de Edad: " );
                }
                else 
               {
                    Console.WriteLine("Es Menor de Edad: ");
                }
                Console.ReadLine();
            }

        }
    }
}
