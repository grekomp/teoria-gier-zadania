using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaGier
{
	class Number
	{
		public Number() { }
		public Number(int nominator, int denominator)
		{
			this.nominator = nominator;
			this.denominator = denominator;
		}

		public int nominator = 0;
		public int denominator = 1;

		public double value { get { return nominator / (double)denominator; } }

		public static Number operator +(Number left, Number right)
		{
			int commonDenominator = 0;

			if (left.denominator > right.denominator)
			{
				commonDenominator = left.denominator;
			} else
			{
				commonDenominator = right.denominator;
			}

			int sumNominator = (commonDenominator / left.denominator) * left.nominator + (commonDenominator / right.denominator) * right.nominator;

			return new Number(sumNominator, commonDenominator);
		}

		public override string ToString()
		{
			return nominator.ToString() + "/" + denominator.ToString() + " (" + value + ")";
		}
	}
}
