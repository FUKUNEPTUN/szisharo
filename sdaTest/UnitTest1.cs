using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using sda;

namespace sdaTest
{
    [TestClass]
    public class UnitTest1
    {
        Ehes ehes = new Ehes();
        int tesztSzam = 5, tesztSzam2 = 15, tesztSzam3 = 8, tesztSzam4= 12;
        string vart, kapott;

        [TestMethod]
        public void TestMethod1()
        {
            vart = "Öt";
           kapott = ehes.getSzam(tesztSzam);
            Assert.AreEqual(kapott, vart);
        }
        [TestMethod]
        public void TestMethod2()
        {
            vart = "Öttel, hárommal osztható";
            kapott = ehes.getSzam(tesztSzam2);
            Assert.AreEqual(kapott, vart);
        }
        [TestMethod]
        public void TestMethod3()
        {
            vart = "8";
            kapott = ehes.getSzam(tesztSzam3);
            Assert.AreEqual(kapott, vart);
        }
        public void TestMethod4()
        {
            vart = "Három";
            kapott = ehes.getSzam(tesztSzam4);
            Assert.AreEqual(kapott,vart);
        }
    }
}
