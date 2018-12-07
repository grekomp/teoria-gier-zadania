using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Zadanie 10.");
			Console.WriteLine("Wprowadź grę np. orrorr");
			string input = Console.ReadLine();

			if (input[0] == 'O' || input[0] == 'o')
			{
				Console.WriteLine("\nWartość gry:\n*0");
			}

			if (input[0] == 'R' || input[0] == 'r')
			{
				Console.WriteLine("\nWartość gry:\n*1");
			}

			Console.ReadKey();
		}
	}
}
