﻿namespace WindowsFormsApplication1.TwoArgument
{
    public class Amount : ICalculateTwoArguments
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + secondArgument;
        }
    }
}
