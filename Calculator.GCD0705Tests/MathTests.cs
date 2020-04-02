using NUnit.Framework;
using Calculator.GCD0705;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.GCD0705.Tests
{
	[TestFixture]
	public class MathTests
	{
		Math math;

		[SetUp]
		public void Setup()
		{
			math = new Math();
		}


		// AAA
		// A: Arrange
		// A: Act
		// A: Assert

		[Test]
		public void Add_Input1And2_Return3()
		{
			// Arrage
			int a = 1;
			int b = 2;

			// Act
			var result = math.Add(1, 2);

			// Assert
			Assert.AreEqual(3, result);
		}
	}
}