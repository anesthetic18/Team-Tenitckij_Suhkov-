using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.OneArgument
{
    [TestFixture]
    public class CtanTest
    {
        [TestCase(1, 0.64)]
        [TestCase(2, -0.46)]
        [TestCase(3, -7.02)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Ctan");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result);
        }
    }
}
