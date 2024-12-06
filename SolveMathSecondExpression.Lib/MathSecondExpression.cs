namespace SolveMathSecondExpression.Lib
{
    public class MathSecondExpression
    {
        public double CalculateSecondExpression(double x, double y, double a)
        {
            return 10 * x - ((3 * x + 2 * a - a) / (3 * a + 2 * x + y)) + ((a * y * x / (3 * y)) / (3 * a / x)) - 2 * x;
        }
    }
}