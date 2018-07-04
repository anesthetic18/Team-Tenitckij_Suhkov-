using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WindowsFormsApplication1.Tests
{
    [TestFixture]
    public class WindowsFormsApplication1Tests
    {
        [Test]
        public void AmountTest()
        {
            // подготовительные действия
            Assert.AreEqual(предполагаемыйРезультат, фактическийРезультат);
        }
    }
}
