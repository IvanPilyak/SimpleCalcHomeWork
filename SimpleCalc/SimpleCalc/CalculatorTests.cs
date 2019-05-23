using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace SimpleCalc
{
	[TestFixture]
	public class CalculatorTests
	{
        private readonly Calculator calculator;

        public CalculatorTests()
        {
            calculator = new Calculator();
        }

        [TestCase(3.3,5.2,8.5)]
        [TestCase(1,1,2)]
        [TestCase(-12,12,0)]
        [TestCase(0,0,0)]
        public void AddTest(double firstValue, double secondValue, double result)
        {
            //Arange
            calculator.Number1 = firstValue;
            calculator.Number2 = secondValue;

            //Act
            var actualResult = calculator.Add();

            //Assert
            Assert.AreEqual(actualResult, result);

        }

        [TestCase(3.3, 3, 0.3)]
        [TestCase(1, 1, 0)]
        [TestCase(0, 0, 0)]
        public void SubtractTest(double firstValue, double secondValue, double result)
        {
            //Arange
            calculator.Number1 = firstValue;
            calculator.Number2 = secondValue;

            //Act
            var actualResult = Math.Round(calculator.Subtract(), 9);

            //Assert
            Assert.AreEqual(actualResult, result);

        }

        [TestCase(3.3, 3, 9.9)]
        [TestCase(1, 1, 1)]
        [TestCase(0, 0, 0)]
        public void MultiplyTest(double firstValue, double secondValue, double result)
        {
            //Arange
            calculator.Number1 = firstValue;
            calculator.Number2 = secondValue;

            //Act
            var actualResult = Math.Round(calculator.Multiply(),9);

            //Assert
            Assert.AreEqual(actualResult, result);

        }

        [TestCase(3.3, 1, 3.3)]
        [TestCase(1, 1, 1)]
        [TestCase(0,4.5,0)]
        public void DevideTest(double firstValue, double secondValue, double result)
        {
            //Arange
            calculator.Number1 = firstValue;
            calculator.Number2 = secondValue;

            //Act
            var actualResult = Math.Round(calculator.Divide(), 9);

            //Assert
            Assert.AreEqual(actualResult, result);

        }

        [TestCase(3.3, 0)]
        [TestCase(1, 0)]
        [TestCase(0, 0)]
        [TestCase(-10.3, 0)]
        public void DevideByZeroTest(double firstValue, double secondValue)
        {
            //Arange
            calculator.Number1 = firstValue;
            calculator.Number2 = secondValue;

            //Act
            //Assert
            Assert.Throws(typeof(DivideByZeroException),()=> calculator.Divide());

        }
    }
}
