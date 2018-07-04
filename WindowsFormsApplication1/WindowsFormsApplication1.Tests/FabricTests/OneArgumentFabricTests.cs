using System;
using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.FabricTests
{
    class OneArgumentFabricTests
    {
        [TestCase("Cos", typeof(Cos))]
        [TestCase("Tan", typeof(Tan))]
        public void FirstTest(string name, Type type)
        {
            var calculator = CalculateOneFactory.CreateCalculator(name);
            Assert.IsInstanceOf(type, calculator);
        }
    }
}
