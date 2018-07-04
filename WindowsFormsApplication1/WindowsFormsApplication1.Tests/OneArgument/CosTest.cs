using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.OneArgument
{
    [TestFixture]
    public class CosTests
    {
        [TestCase(0,1)]
        [TestCase(3.14, -0.99)]
        [TestCase(5, 0.28)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Cos");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result,0.01);
        }
    }
}

