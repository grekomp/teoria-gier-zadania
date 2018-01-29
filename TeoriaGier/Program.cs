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
            Evaluator6 evaluator6 = new Evaluator6();
			string game = Console.ReadLine();

			Console.WriteLine(evaluator6.EvaluateMultirow(game));

			Console.ReadKey();
        }
    }
}
