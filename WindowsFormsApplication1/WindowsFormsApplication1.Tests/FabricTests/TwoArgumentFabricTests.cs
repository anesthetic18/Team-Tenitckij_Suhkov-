using System;
using WindowsFormsApplication1.TwoArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.FabricTests
{
    class TwoArgumentFabricTests
    {
        [TestCase("DoublAmount", typeof(DoublAmount))]
        [TestCase("doubleDifference", typeof(DoubleDifference))]
        public void FirstTest(string name, Type type)
        {
            var calculator = CalculeteTwoFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
