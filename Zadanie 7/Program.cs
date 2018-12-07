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
			Console.WriteLine("Zadanie 7.");
			Console.WriteLine("Wprowadź grę np. 1.2.5 == I II IIIII");

			string input = Console.ReadLine();

			string[] inputSplit = input.Split(new char[]{ '.' }, StringSplitOptions.RemoveEmptyEntries);

			int[] inputRows = new int[inputSplit.Length];

			for (int i = 0; i < inputSplit.Length; i++)
			{
				inputRows[i] = int.Parse(inputSplit[i]);
			}

			Console.WriteLine("\nWartość gry:");
			Console.WriteLine("*" + Evaluator7.EvaluateMultirow(inputRows));

			Console.ReadKey();
		}
	}
}
