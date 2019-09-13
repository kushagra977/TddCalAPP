using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TddCalApp.Library;

namespace TddCalApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void ShouldReturnPositiveOnPassingTWoPositiveNumbers()
        {
            Calculator testCalculator = new Calculator();
            int num1 = 3;
            int num2 = 2;
            int result;
            result = testCalculator.Add(num1, num2);
            Assert.AreEqual(5, result, "testing two integer");

        }
        public void ShouldReturnZeroOnPassingPairOfPositiveAndNegativeInteger()
        {
            Calculator testCalculator = new Calculator();
            int num1 = -3;
            int num2 = 3;
            int result;
            result = testCalculator.Add(num1, num2);
            Assert.AreEqual(0, result, "Testing pair of integer positive and negative");
        }
        
    }
}
