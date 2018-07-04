using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class AmountSquareTests
    {
        [TestCase(0, 0, 0)]
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 8)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("amountSquare");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
