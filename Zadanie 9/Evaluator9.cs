using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_9
{
	class Evaluator9
	{
		static Dictionary<Tuple<int, int>, int> values = new Dictionary<Tuple<int, int>, int>();
		static Dictionary<int, List<Tuple<int, int>>> options = new Dictionary<int, List<Tuple<int, int>>>();

		public int Evaluate(Tuple<int, int> position)
		{
			if (!values.ContainsKey(position))
			{
				if (position.Item1 == 0 && position.Item2 == 0) return 0;

				// Generate values for all positions up to selected position
				values[new Tuple<int, int>(0, 0)] = 0;

				for (int i = 0; i <= position.Item1; i++)
				{
					for (int j = 0; j <= position.Item2; j++)
					{
						Tuple<int, int> currentPosition = new Tuple<int, int>(i, j);

						if (!values.ContainsKey(currentPosition))
						{
							SortedSet<int> currentOptionValues = new SortedSet<int>();

							foreach (Tuple<int, int> option in GetOptions(currentPosition))
							{
								currentOptionValues.Add(values[option]);
							}

							values[currentPosition] = Mex(currentOptionValues);
						}
					}
				}
			}

			return values[position];
		}

		// Helper methods
		public static List<Tuple<int, int>> GetOptions(Tuple<int, int> position)
		{
			List<Tuple<int, int>> options = new List<Tuple<int, int>>();

			for (int i = position.Item1 - 1; i >= 0; i--)
			{
				options.Add(new Tuple<int, int>(i, position.Item2));
			}

			for (int i = position.Item2 - 1; i >= 0; i--)
			{
				options.Add(new Tuple<int, int>(position.Item1, i));
			}

			for (int i = 1; position.Item1 - i >= 0 && position.Item2 - i >= 0; i++)
			{
				options.Add(new Tuple<int, int>(position.Item1 - i, position.Item2 - i));
			}

			return options;
		}
		public static int Mex(SortedSet<int> values)
		{
			int i = 0;

			foreach (int value in values)
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
