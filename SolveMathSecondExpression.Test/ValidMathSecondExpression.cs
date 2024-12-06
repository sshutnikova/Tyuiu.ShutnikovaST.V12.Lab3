using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveMathSecondExpression.Lib;

namespace SolveMathSecondExpression.Test
{
    [TestClass]
    public class ValidMathSecondExpression
    {
        [TestMethod]
        public void TestCalculateSecondExpression()
        {
            var exp2 = new MathSecondExpression();
            double x = 1, y = 2, a = 3;
            double expected = 7.649;
            double result = exp2.CalculateSecondExpression(x, y, a);
            Assert.AreEqual(expected, result, 0.001);
        }
    }
}