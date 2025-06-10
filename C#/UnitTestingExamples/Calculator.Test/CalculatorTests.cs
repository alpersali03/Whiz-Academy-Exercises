using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingExamples;
using NUnit.Framework;

namespace Calc.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator _calc;

        [SetUp]
        public void Setup(){
            _calc = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum(){
            // A A A
            // Arrange
            int x = 5;
            int y = 10;
const int fixedResult = 15;

            // Act 
            int result = _calc.Add(x,y);


            // Assert 
            Assert.That(result, Is.EqualTo(fixedResult), "Wrong sum");
        }

           [Test]
        public void Add_ShouldNotReturnCorrectSum(){
            // A A A
            // Arrange
            int x = 5;
            int y = 10;

const int wrongResult = 10;

            // Act 
            int result = _calc.Add(x,y);


            // Assert 
            Assert.That(result, Is.NotEqual(fixedResult), "Wrong sum");


        }

    }
}
