using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agasys
{
    public class Empleado
    {
        public static void CalculaSueldo()
        {

			string Nombre;
			string Apellido;
			int SueldoDiario;
			double CalculaSueldo;
			int DiasTrabajados;

			Console.WriteLine("Nombre del Empleado: ");
			Nombre = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Apellido del Empleado:");
			Apellido = Convert.ToString(Console.ReadLine());
			Console.WriteLine("Sueldo Diario del Empleado");
			SueldoDiario = int.Parse(Console.ReadLine());
			Console.WriteLine("Dias que laboro");
			DiasTrabajados = int.Parse(Console.ReadLine());


			CalculaSueldo = SueldoDiario * DiasTrabajados;
			Console.WriteLine("El sueldo del empleado es:" + CalculaSueldo);
			Console.ReadLine();
		}

    }
}
