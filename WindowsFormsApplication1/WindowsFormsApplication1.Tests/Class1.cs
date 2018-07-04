using NUnit.Framework;
using WindowsFormsApplication1.TwoArgument;
namespace WindowsFormsApplication1.Tests
{
    [TestFixture]
    public class WindowsFormsApplication1Tests
    {
        [Test]
        public void AmountTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonAmount");
            double result = calculator.Calculate(5, 5);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void SubstractionTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonDifference");
            double result = calculator.Calculate(6, 5);
            Assert.AreEqual(1, result);
        }
    }
}
