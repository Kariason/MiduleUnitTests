using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MiduleUnitTests;
using NUnit.Framework;

namespace ModuleUnitTests.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator = new Calculator();
        [Test]
        public void AdditionalMustReturnCorrectValue()
        {
            Assert.That(calculator.Additional(6, 2) == 8);
        }

        [Test]
        public void SubtractionMustReturnCorrectValue()
        {
            Assert.That(calculator.Subtraction(6, 2) == 4);
        }

        [Test]
        public void MultiplicationMustReturnCorrectValue()
        {
            Assert.That(calculator.Miltiplication(6, 2) == 12);
        }

        [Test] 
        public void DivisionMustReturnCorrectValue()
        {
            Assert.That(calculator.Division(6, 2) == 3);
        }

        [Test]
        public void DivisionMustThrowException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Division(6, 0));
        }

    }
}
