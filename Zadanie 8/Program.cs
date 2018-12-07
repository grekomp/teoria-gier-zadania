using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Zadanie 8.");
			Console.WriteLine("Podaj początkowe liczby kul w urnach w dwóch liniach");
			int a = int.Parse(Console.ReadLine());
			int b = int.Parse(Console.ReadLine());

			if (a > b)
			{
				int c = b;
				b = a;
				a = c;
			}

			Evaluator8 evaluator = new Evaluator8(b);

			Console.WriteLine("\nWartość gry:");
			Console.WriteLine("*" + evaluator.Evaluate(new Tuple<int, int>(a, b)));

			Console.ReadKey();
		}
	}
}
