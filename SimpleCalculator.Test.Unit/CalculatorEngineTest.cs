using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorEngineLibrary;

namespace CalculatorEngineLibrary.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine CalculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalculatorEngine.Calculate("plus", number1, number2);
            Assert.AreEqual(3, result);

        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOpertion()
        {

            int number1 = 1;
            int number2 = 2;
            double result = CalculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);

        }
    }
}
