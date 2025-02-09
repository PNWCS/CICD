

namespace CICD_Core
{
    public class Calculator
    {
        public static double Divide(int v1, int v2)
        {
            if (v2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return v1 / (double)v2;
        }
    }
}
