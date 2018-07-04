using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Cos : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Cos(argument);
        }
    }
}
