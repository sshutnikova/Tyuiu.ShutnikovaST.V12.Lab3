namespace SolveMathFirstExpression.Lib
{
    public class MathFirstExpression
    {
        public double CalculateFirstExpression(double x, double y, double a)
        {
            return 12 * a + ((a / y) / ((3 * a + x * a) / x)) * ((3 * x + 2 * a + a) / (3 * a + 2 * x - y)) + 12 * x;
        }
    }
}