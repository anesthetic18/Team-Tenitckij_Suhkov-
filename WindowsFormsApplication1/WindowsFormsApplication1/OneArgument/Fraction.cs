﻿namespace WindowsFormsApplication1
{
    public class Fraction : ICalculateOneArgument
    {
        public double Calculate(double argument)
        {
            return 1/argument;
        }
    }
}
