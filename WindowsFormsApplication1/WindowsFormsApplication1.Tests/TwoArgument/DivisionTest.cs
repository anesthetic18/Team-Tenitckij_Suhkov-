using System;
using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.TwoArgument
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void FirstTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonDivision");
            double result = calculator.Calculate(5, 5);
            Assert.AreEqual(1, result);
        }
        [Test]
        public void DivisionExeptionTest()
        {
            ICalculateTwoArguments calculator = CalculeteTwoFactory.CreateCalculator("buttonDivision");
            Assert.Throws<Exception>(() => calculator.Calculate(5, 0));
        }
    }
}
