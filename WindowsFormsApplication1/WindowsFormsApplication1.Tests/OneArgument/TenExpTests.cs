using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.OneArgument
{
    [TestFixture]
    public class TenExpTests
    {
        [TestCase(1, 10)]
        [TestCase(2, 100)]
        [TestCase(0, 1)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("TenExp");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result);
        }
    }
}
