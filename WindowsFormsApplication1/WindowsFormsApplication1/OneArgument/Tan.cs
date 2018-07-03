using System;

namespace WindowsFormsApplication1
{
    public class Tan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
