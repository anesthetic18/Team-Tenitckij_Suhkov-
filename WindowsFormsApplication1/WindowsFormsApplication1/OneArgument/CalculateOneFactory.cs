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
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}

