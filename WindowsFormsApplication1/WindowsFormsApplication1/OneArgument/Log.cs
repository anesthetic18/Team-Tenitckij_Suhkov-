using System;

namespace WindowsFormsApplication1
{
    public class Log : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return Math.Log(argument);
        }
    }
}
