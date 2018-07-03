using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class CalculeteTwoFactory
    {
        public static ICalculateTwoArguments CreateCalculator(string calculatorName)
        {
            switch (calculatorName)
            {
                case "buttomAmount":
                    return new ClassAmount();
                case "buttonDifference":
                    return new ClassSubtraction();
                case "buttonMultiply":
                    return new ClassMultiplication();
                case "buttonDivision":
                    return new ClassDivision();
                default:
                    throw new Exception("Неизвестная операция");
            }

        }
    }
}
