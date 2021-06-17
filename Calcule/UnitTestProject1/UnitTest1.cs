using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calcule;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Moyen C = new Moyen();
            double m = C.CalculerMoyenne(17, 14, 18);
            Assert.AreEqual(m, 16.2);

        }
    }
}
