using System;

namespace WindowsFormsApplication1
{
    public class TenExp : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Pow(10, argument);
        }
    }
}
