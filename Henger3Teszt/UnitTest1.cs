using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger3;

namespace Henger3Teszt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestgetTerulet()
        {
            //AAA
            //Arrange
            Hengerke hengerke = new Hengerke();
            double vartEredmeny = 12.57 , kapottEredmeny;
            hengerke.setMagassag(3);
            hengerke.setSugar(2);

            //Action
            kapottEredmeny = hengerke.getTerulet();

            //Assert
            Assert.AreEqual(kapottEredmeny, vartEredmeny);
        }
    }
}
