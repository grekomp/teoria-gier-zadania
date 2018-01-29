using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGier
{
    class Evaluator6
    {
		Dictionary<string, Number> values = new Dictionary<string, Number>();

		public Number Evaluate(string game)
		{
			List<string> leftOptions = GetOptions(game, 'b');

			Number leftValue = null;
			Number rightValue = null;

			foreach (string option in leftOptions)
			{
				if (!values.ContainsKey(option))
				{
					values[option] = Evaluate(option);
				}

				if (leftValue != null)
				{
					if (leftValue.value < values[option].value)
					{
						leftValue = values[option];
					}
				}
				else
				{
					leftValue = values[option];
				}
			}

			List<string> rightOptions = GetOptions(game, 'w');

			foreach (string option in rightOptions)
			{
				if (!values.ContainsKey(option))
				{
					values[option] = Evaluate(option);
				}

				if (rightValue != null)
				{
					if (rightValue.value > values[option].value)
					{
						rightValue = values[option];
					}
				}
				else
				{
					rightValue = values[option];
				}
			}

			return SimplestBetween(leftValue, rightValue);
		}
		public Number EvaluateMultirow(string game)
		{
			string[] games = game.Split('|');

			Number combinedResult = new Number();

			foreach(string row in games)
			{
				combinedResult = combinedResult + Evaluate(row);
			}

			return combinedResult;
		}

		public List<string> GetOptions(string game, char player)
        {
            List<string> options = new List<string>();

            for (int i = 0; i < game.Length; i++)
            {
                if (game.ElementAt(i) == player)
                {
                    options.Add(RemoveNthUp(game, i));
                }
            }

            return options;
        }

        public string RemoveNthUp(string game, int n)
        {
            StringBuilder newGameBuilder = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                newGameBuilder.Append("" + game.ElementAt(i));
            }

            return newGameBuilder.ToString();
        }

		public Number SimplestBetween(Number left, Number right)
		{
			if (left == null && right == null)
			{
				return new Number(0, 1);
			}

			if (left == null)
			{
				if (right.value > 0)
				{
					return new Number(0, 1);
				}
				else
				{
					return new Number((int)right.value - 1, 1);
				}
			}

			if (right == null)
			{
				if (left.value < 0)
				{
					return new Number(0, 1);
				}
				else
				{
					return new Number((int)left.value + 1, 1);
				}
			}

			if (left.value < 0 && right.value > 0)
			{
				// If 0 is available, pick it

				return new Number(0, 1);
			}

			if (Math.Abs(left.value - right.value) > 1.0)
			{
				// Value will be an integer

				if (right.value <= 0)
				{
					return new Number((int)right.value - 1, 1);
				}

				if (left.value >= 0)
				{
					return new Number((int)left.value + 1, 1);
				}
			}
			else
			{
				// Calculate simplest fraction between left and right

				int currentNominator = 0;
				int currentDenominator = 1;

				int direction = 1;

				if (right.value <= 0)
				{
					direction = -1;
				}

				Number currentNumber = new Number(currentNominator, currentDenominator);

				while (currentNumber.value >= right.value || currentNumber.value <= left.value)
				{
					currentNominator = 0;
					currentDenominator *= 2;

					currentNumber = new Number(currentNominator, currentDenominator);

					int fitness = 0;

					if (currentNumber.value >= right.value)
					{
						fitness = -1;
					}

					if (currentNumber.value <= left.value)
					{
						fitness = 1;
					}

					while (fitness == direction)
					{
						currentNominator += direction;

						currentNumber = new Number(currentNominator, currentDenominator);

						fitness = 0;

						if (currentNumber.value >= right.value)
						{
							fitness = -1;
						}

						if (currentNumber.value <= left.value)
						{
							fitness = 1;
						}
					}

				}

				return currentNumber;

			}

			throw new ArgumentException("Unable to find a number between: " + left + " and " + right);
		}
    }
}
