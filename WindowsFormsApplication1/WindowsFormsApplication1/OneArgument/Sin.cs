using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Sin : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Sin(argument);
        }
    }
}
