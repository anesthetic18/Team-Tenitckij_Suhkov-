using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.OneArgument
{
    [TestFixture]
    public class CubeTests
    {
        [TestCase(1, 1)]
        [TestCase(2, 8)]
        [TestCase(3, 27)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Cube");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}

