using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Henger3;

namespace Henger3Teszt
{
    [TestClass]
    public class UnitTest1
    {

        Hengerke hengerke = new Hengerke(); 
        [TestMethod]
        public void TestgetTerulet()
        {
            //AAA
            //Arrange
            
            double vartEredmeny = 12.57 , kapottEredmeny;
            hengerke.setMagassag(3);
            hengerke.setSugar(2);

            //Action
            kapottEredmeny = hengerke.getTerulet();

            //Assert
            Assert.AreEqual(kapottEredmeny, vartEredmeny);
        }
        [TestMethod] 
        public void TestgetKerulet()
        {
            double vartEredmeny =12.57 , kapottEredmeny;
            hengerke.setMagassag(3);
            hengerke.setSugar(2);
            kapottEredmeny = hengerke.getKerulet();
            //Assert
            Assert.AreEqual(kapottEredmeny, vartEredmeny);
        }
        [TestMethod]
        public void TestgetTerfogat()
        {
            double vartEredmeny = 12.57*3, kapottEredmeny;
            hengerke.setMagassag(3);
            hengerke.setSugar(2);
            kapottEredmeny = hengerke.getTerfogat();
            //Assert
            Assert.AreEqual(kapottEredmeny, vartEredmeny);
        }
        [TestMethod]
        public void TestgetFelszin()
        {
            double vartEredmeny = 62.85, kapottEredmeny;
            hengerke.setMagassag(3);
            hengerke.setSugar(2);
            kapottEredmeny = hengerke.getFelszin();
            //Assert
            Assert.AreEqual(kapottEredmeny, vartEredmeny);
        }
    }
}
