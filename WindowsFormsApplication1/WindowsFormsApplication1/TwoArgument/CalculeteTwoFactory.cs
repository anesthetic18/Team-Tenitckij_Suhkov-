using System;

namespace WindowsFormsApplication1.TwoArgument
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
                case "DoublAmount":
                    return new DoublAmount();
                case "doubleDifference":
                    return new DoubleDifference();
                case "doubleMultiply":
                    return new DoubleMultiply();
                case "doubleDivision":
                    return new DoubleDivision();
                case "amountSquare":
                    return new AmountSquare();
                case "doubleDifSquare":
                    return new DoubleDifSquare();
                case "difDivision":
                    return new DifDivision();
                case "amountCube":
                    return new AmountCube();
                default:
                    throw new Exception("Неизвестная операция");
            }
        }
    }
}
