using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_7
{
	static class Evaluator7
	{
		public static int[] values =
		{
			0, 1, 2, 3, 1, 4, 3, 2, 1, 4, 2, 6,
			4, 1, 2, 7, 1, 4, 3, 2, 1, 4, 6, 7,
			4, 1, 2, 8, 5, 4, 7, 2, 1, 8, 6, 7,
			4, 1, 2, 3, 1, 4, 7, 2, 1, 8, 2, 7,
			4, 1, 2, 8, 1, 4, 7, 2, 1, 4, 2, 7,
			4, 1, 2, 8, 1, 4, 7, 2, 1, 8, 6, 7,
			4, 1, 2, 8, 1, 4, 7, 2, 1, 8, 2, 7
		};

		public static int Evaluate(int row)
		{
			if (row > 83)
			{
				return values[row % 12 + 72];
			}

			return values[row];
		}

		public static int EvaluateMultirow(int[] rows)
		{
			int result = 0;

			foreach(int row in rows)
			{
				result = result ^ Evaluate(row);
			}

			return result;
		}
	}
}
