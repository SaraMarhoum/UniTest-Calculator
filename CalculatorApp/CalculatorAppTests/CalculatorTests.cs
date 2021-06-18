using System;
using CalculatorConsole;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorAppTests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator calculator;

        [TestInitialize]
        public void Initialize()
        {
            calculator = new Calculator();
        }

        [TestCleanup]
        public void Cleanup()
        {
        }

        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(15, calculator.Add(10, 5));

        }

        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(0, calculator.Subtract(1, 1));

        }

        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(6, calculator.Multiply(3, 2));

        }

        [TestMethod]
        public void Divide()
        {
            Assert.AreEqual(4, calculator.Divide(8, 2));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void DivideException()
        {
            calculator.Divide(2, 0);
        }

    }
}