using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    public class CalculatorUnitTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _calc = new Calculator();
        }

       [TestCase(2.5, 3.5,6.0)]
       [TestCase(-2.5, 3.5, 1.0)]
       [TestCase(-2.5, -3.5, -6.0)]
        public void Add_AllSignCombinations_Pass(double a, double b, double expected)
        {
            // Act and Assert
            Assert.That(expected, Is.EqualTo(_calc.Add(a, b)));
        }

        [Test]
        public void Add_ExceedsMaxValueByLarge_IsPositiveInfinity()
        {
            Assert.IsTrue(Double.IsPositiveInfinity(_calc.Add(Double.MaxValue, Double.MaxValue)));
        }

        // The precision of a double is about 15 digits, so you need a number that is at least 1e292 for it to be large enough
        // to make a difference. The value of Double.MaxValue is the constant 1.7976931348623157E+308.
        [Test]
        public void Add_ExceedsMaxValueBySmall_IsStillMaxValue()
        {
            Assert.That(Double.MaxValue, Is.EqualTo(_calc.Add(Double.MaxValue, 1)));
        }

        [Test] 
        public void Add_ExceedsMinValue_IsNegativeInfinity()
        {
            Assert.IsTrue(Double.IsNegativeInfinity(_calc.Add(-1.7976931348623157E+308, -1.7976931348623157E+308)));
        }
    }
}