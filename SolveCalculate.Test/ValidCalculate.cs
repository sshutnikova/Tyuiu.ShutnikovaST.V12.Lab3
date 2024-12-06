using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveCalculate.Lib;

namespace SolveCalculate.Test
{
    [TestClass]
    public class ValidCalculate
    {
        
        [TestMethod]
        public void TestCalculateSumma()
        {
            var calculator = new Calculate();
            double a = 6, b = 3;
            double result = calculator.CalculateSumma(a, b);
            Assert.AreEqual(9, result);

        }

        [TestMethod]
        public void TestCalculateDifference()
        {
            var calculator = new Calculate();
            double a = 6, b = 3;
            double result = calculator.CalculateDifference(a, b);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestCalculateMultiplication()
        {
            var calculator = new Calculate();
            double a = 6, b = 3;
            double result = calculator.CalculateMultiplication(a, b);
            Assert.AreEqual(18, result);
        }

        [TestMethod]
        public void TestCalculateQuotient()
        {
            var calculator = new Calculate();
            double a = 6, b = 3;
            double result = calculator.CalculateQuotient(a, b);
            Assert.AreEqual(2, result);
        }
    }
}