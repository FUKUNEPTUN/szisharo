using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Negyzet;

namespace NegyszogTest
{
    [TestClass]
    public class NegyszogTest
    {
        // Arrange
        static double s = 2.0;
        Negyzet.Negyszog nsz = new Negyzet.Negyszog(s);
        [TestMethod]
        public void TestMethod1()
        {
            double kapott = nsz.Kerulet();
            double vart = 8.0;
            Assert.AreEqual(vart,kapott);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double kapott = nsz.Atlo();
            double vart = Math.Sqrt(2 * Math.Pow(s, 2));
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double kapott = nsz.Kerulet();
            double vart = 8.0;
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod,ExpectedException(typeof(ArgumentException))]
        public void TestMethod4()
        {
            double m = -10;
            nsz.setOszlop(m);
        }
    }
}
