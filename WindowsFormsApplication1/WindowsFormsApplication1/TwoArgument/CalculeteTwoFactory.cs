﻿using System;

namespace WindowsFormsApplication1
{
    class CalculeteTwoFactory
    {
        public static ICalculateTwoArguments CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "buttonAmount":
                    return new Amount();
                case "buttonDifference":
                    return new Subtraction();
                case "buttonMultiply":
                    return new Multiplication();
                case "buttonDivision":
                    return new Division();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}