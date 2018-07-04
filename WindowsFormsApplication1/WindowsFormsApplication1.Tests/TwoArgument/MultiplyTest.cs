using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class MultiplyTests
    {
        [Test]
        public void FirstTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonMultiply");
            double result = calculator.Calculate(5, 5);
            Assert.AreEqual(25, result);
        }
    }
}
