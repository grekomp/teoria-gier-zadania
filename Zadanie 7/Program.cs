using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Przykładowa gra: I II IIIII = 1.2.5");

			string input = Console.ReadLine();

			string[] inputSplit = input.Split(new char[]{ '.' }, StringSplitOptions.RemoveEmptyEntries);

			int[] inputRows = new int[inputSplit.Length];

			for (int i = 0; i < inputSplit.Length; i++)
			{
				inputRows[i] = int.Parse(inputSplit[i]);
			}

			Console.WriteLine("*" + Evaluator7.EvaluateMultirow(inputRows));

			Console.ReadKey();
		}
	}
}
