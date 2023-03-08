using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				float dpi, eDpi;
				float sensitivity;

				Console.WriteLine("Введите ваш dpi:");
				dpi = Convert.ToSingle(Console.ReadLine());
				Console.WriteLine("Введите вашу сенсу:");
				sensitivity = Convert.ToSingle(Console.ReadLine());
				eDpi = dpi * sensitivity;

				Console.WriteLine($"Ваш eDpi: {eDpi}");
				Console.ReadLine();
			}
		}
	}
}
