using System;

namespace WindowsFormsApplication1.OneArgument
{
    public class Tan : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Tan(argument);
        }
    }
}
