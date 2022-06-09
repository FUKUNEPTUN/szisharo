using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TeglaTDD;

namespace TeglaTDDtest
{
    [TestClass]
    public class UnitTest1
    {
        Harem harem = new Harem();

        [TestMethod]
        public void TestFelszin()
        {
            //test 1
            int kapott = harem.getFelszin(1, 2,2);
            int vart = 16;
            Assert.AreEqual(kapott, vart);
            //test 2
            vart = 82; kapott = harem.getFelszin(7,2, 3);
            Assert.AreEqual(kapott, vart);

            // rossz 
            vart = 2; kapott = harem.getFelszin(8,2, 3);
            Assert.AreNotEqual(kapott, vart);
        }
        [TestMethod]
        public void TestFelszin2()
        {
            //test 2
            int vart = 82; int kapott = harem.getFelszin(7, 2, 3);
            Assert.AreEqual(kapott, vart);

            // rossz 
            vart = 2; kapott = harem.getFelszin(8, 2, 3);
            Assert.AreNotEqual(kapott, vart);
        }
        [TestMethod]
        public void TestFelszinROSSZ()
        {
            // rossz 
            int vart = 2; int kapott = harem.getFelszin(8, 2, 3);
            Assert.AreNotEqual(kapott, vart);
        }
        [TestMethod]
        public void TestTerfogat()
        {
            //test1
            int kapott = harem.getTerfogat(1, 2,3);
            int vart = 6;
            Assert.AreEqual(kapott, vart);
            //test2
            vart = 18; kapott = harem.getTerfogat(2, 3,3);
            Assert.AreEqual(kapott, vart);

            // rossz 
            vart = 2; kapott = harem.getTerfogat(2, 3,2);
            Assert.AreNotEqual(kapott, vart);
        }
        [TestMethod]
        public void TestTerfogat2()
        {
            //test1

            //test2
            int vart = 18; int kapott = harem.getTerfogat(2, 3, 3);
            Assert.AreEqual(kapott, vart);
        }
        [TestMethod]
        public void TestTerfogatROSSZ()
        {

            // rossz 
            int vart = 2; int kapott = harem.getTerfogat(2, 3, 2);
            Assert.AreNotEqual(kapott, vart);
        }
    }

}
