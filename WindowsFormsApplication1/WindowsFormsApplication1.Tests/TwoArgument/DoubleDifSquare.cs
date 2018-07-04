using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class DoubleDifSquareTests
    {
        [TestCase(1, 3, -8)]
        [TestCase(2, 3, -5 )]
        [TestCase(4, 2, 12)]
        public void FirstTest(double firstValue, double secondValue, double expected)
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("doubleDifSquare");
            double result = calculator.Calculate(firstValue, secondValue);
            Assert.AreEqual(expected, result);
        }
    }
}

