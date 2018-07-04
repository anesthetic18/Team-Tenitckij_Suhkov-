using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class DifferenceTests
    {
        [Test]
        public void FirstTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonDifference");
            double result = calculator.Calculate(6, 5);
            Assert.AreEqual(1, result);
        }
    }
}
