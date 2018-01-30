using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_8
{
	class Evaluator8
	{
		static Dictionary<Tuple<int, int>, int> values = new Dictionary<Tuple<int, int>, int>();
		static Dictionary<int, List<Tuple<int, int>>> options = new Dictionary<int, List<Tuple<int, int>>>();

		public Evaluator8(int maxValue)
		{
			values[new Tuple<int, int>(1, 1)] = 0;

			// Generate values for all games up to maxValue
			for (int i = 1; i <= maxValue; i++)
			{
				for (int j = 1; j <= i; j++)
				{
					SortedSet<int> currentOptionValues = new SortedSet<int>();

					foreach (Tuple<int, int> option in GetOptions(i))
					{
						currentOptionValues.Add(values[option]);
					}

					foreach (Tuple<int, int> option in GetOptions(j))
					{
						currentOptionValues.Add(values[option]);
					}

					values[new Tuple<int, int>(j, i)] = Mex(currentOptionValues);
				}
			}
		}

		public int Evaluate(Tuple<int, int> game)
		{
			return values[game];
		}

		// Helper methods
		public static List<Tuple<int, int>> GetOptions(int game)
		{
			if (Evaluator8.options.ContainsKey(game)) return Evaluator8.options[game];

			List<Tuple<int, int>> options = new List<Tuple<int, int>>();

			for (int i = 1; i <= game / 2; i++)
			{
				options.Add(new Tuple<int, int>(i, game - i));
			}

			return options;
		}
		public static int Mex(SortedSet<int> values)
		{
			int i = 0;

			foreach(int value in values)
			{
				if (value != i)
				{
					return i;
				}

				i++;
			}

			return i;
		}
	}
}
