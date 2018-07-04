using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.SimpleTests
{
    [TestFixture]
    public class AmountTests
    {
        [Test]
        public void AmountTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonAmount");
            double result = calculator.Calculate(5, 5);
            Assert.AreEqual(10, result);
        }
    }
}
