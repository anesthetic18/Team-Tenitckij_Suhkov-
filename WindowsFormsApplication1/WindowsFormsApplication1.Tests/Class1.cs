using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
