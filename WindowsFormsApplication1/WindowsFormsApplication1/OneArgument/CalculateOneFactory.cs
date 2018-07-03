﻿using System;

namespace WindowsFormsApplication1
{
    class CalculateOneFactory
    {
        public static ICalculateOneArgument CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "Square":
                    return new Square();
                case "Sin":
                    return new Sin();
                case "TenExp":
                    return new TenExp();
                case "Cos":
                    return new Cos();
                case "Cube":
                    return new Cube();
                case "Tan":
                    return new Tan();
                case "Atan":
                    return new Atan();
                case "Fraction":
                    return new Fraction();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}

