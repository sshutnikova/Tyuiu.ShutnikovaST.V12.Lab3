using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveMathFirstExpression.Lib;

namespace SolveMathFirstExpression.Test
{
    [TestClass]
    public class ValidMathFirstExpression
    {
        [TestMethod]
        public void TestCalculateFirstExpression()
        {
            var exp1 = new MathFirstExpression();
            double x = 1, y = 2, a = 3;
            double expected = 48.167;
            double result = exp1.CalculateFirstExpression(x, y, a);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}