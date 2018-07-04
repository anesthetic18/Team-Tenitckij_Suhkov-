﻿using WindowsFormsApplication1.OneArgument;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests.OneArgument
{
    [TestFixture]
    public class LogTests
    {
        [TestCase(1, 0)]
        [TestCase(2, 0.69)]
        [TestCase(3, 1.09)]
        public void FirstTest(double value, double expected)
        {
            ICalculateOneArgument calculator = CalculateOneFactory.CreateCalculator("Log");
            double result = calculator.Calculate(value);
            Assert.AreEqual(expected, result, 0.01);
        }
    }
}
