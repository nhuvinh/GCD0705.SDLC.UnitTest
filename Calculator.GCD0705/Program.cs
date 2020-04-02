using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.GCD0705
{
	class Program
	{
		static void Main(string[] args)
		{
			Math m = new Math();
			try
			{
				m.Divide(3, 0);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
			Console.ReadLine();

		}
	}
}
