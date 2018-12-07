using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGier
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Zadanie 6.");
			Console.WriteLine("Podaj grę w formacie np. wbwbb");

            Evaluator6 evaluator6 = new Evaluator6();
			string game = Console.ReadLine();

			Console.WriteLine(evaluator6.EvaluateMultirow(game));

			Console.ReadKey();
        }
    }
}
