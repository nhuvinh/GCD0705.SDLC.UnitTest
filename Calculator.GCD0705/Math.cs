using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.GCD0705
{
	public class Math
	{
		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Sub(int a, int b)
		{
			return a - b;
		}

		public int Multiply(int a, int b)
		{
			return a * b;
		}

		public int Divide(int a, int b)
		{
			if (b == 0) throw new System.DivideByZeroException();
			else return a / b;
		}
	}
}
