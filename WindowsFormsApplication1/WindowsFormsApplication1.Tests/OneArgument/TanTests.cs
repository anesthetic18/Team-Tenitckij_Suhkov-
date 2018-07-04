using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.OneArgument
{
    [TestFixture]
    public class TanTests
    {
        [TestCase(1, 1.55)]
        [TestCase(2, -2.18)]
        [TestCase(3, -0.14)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Tan");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}


