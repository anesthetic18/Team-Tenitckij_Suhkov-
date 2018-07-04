using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class DoubleDivisionTests
    {
        [TestCase(1, 1, 2)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 2)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("doubleDivision");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
