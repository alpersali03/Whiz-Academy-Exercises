using NewUnitTesting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTest
{    
    [TestFixture]

    public class CalculatorTests
    {
            private Calc calc;

        [SetUp]
        public void Setup()
        {
            this.calc = new Calc(); // Ensure Calc class is correctly referenced
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            // Arrange
            int first = 10;
            int second = 20;
            int expectedResult = 30;

            // Act
            int result = this.calc.Add(first, second);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult), "Addition result is incorrect.");

        }
    }
}
