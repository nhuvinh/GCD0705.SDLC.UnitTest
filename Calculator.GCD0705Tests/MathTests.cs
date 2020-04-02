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

		[TestCase(1, 1, 2)]
		[TestCase(1, 3, 4)]
		public void Add_Input1And2_Return3(int a, int b, int expectedResult)
		{
			// Arrage


			// Act
			var actualResult = math.Add(a, b);

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}
		[Test]
		public void Sub_Input3And2_Return1()
		{
			// Arrange
			int a = 3;
			int b = 2;

			// Act
			var actualResult = math.Sub(a, b);
			var expectedResult = 1;

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void Multiply_Input2And3_Return6()
		{
			// Arrange
			int a = 2;
			int b = 3;

			// Act
			var actualResult = math.Multiply(a, b);
			var expectedResult = 6;

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void Divide_InputsAre10And2_Return5()
		{
			// Arrange
			int a = 10;
			int b = 2;

			// Act
			var actualResult = math.Divide(10, 2);
			var expectedResult = 5;

			// Assert
			Assert.AreEqual(expectedResult, actualResult);
		}

		[Test]
		public void Divide_DenominatorEqualZero_ThrowDivideByZeroException()
		{
			// Arrange
			int a = 10;
			int b = 0;

			// Act 

			// Assert
		}
	}
}