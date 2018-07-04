using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class DoublAmountTests
    {
        [TestCase(1, 1, 4)]
        [TestCase(2, 2, 8)]
        [TestCase(0, 0,0)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("DoublAmount");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

