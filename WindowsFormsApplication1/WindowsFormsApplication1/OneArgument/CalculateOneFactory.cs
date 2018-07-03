using System;

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
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}

