using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Zadanie 9.");
			Console.WriteLine("Podaj współrzędne pozycji hetmana w osobnych liniach, zaczynając od 0 0");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			Evaluator9 evaluator = new Evaluator9();

			Console.WriteLine("\nWartość pozycji:");
			Console.WriteLine("*" + evaluator.Evaluate(new Tuple<int, int>(a, b)));

			Console.ReadKey();
		}
	}
}
