using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KalkulatorUt;

namespace KalkulatorUtTeszt
{
    
    [TestClass]
    public class UnitTest1
    {
        Kalki kalki = new Kalki();
        [TestMethod]
        public void Osztas()
        {
            double tesztSzam = 15, tesztSzam2 = 5;
            double vart = 3, kapott;
            char a = '/';
            kapott = kalki.Szam(tesztSzam,tesztSzam2,a);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Szorzas()
        {
            double tesztSzam = 15, tesztSzam2 = 5;
            double vart = 75, kapott;
            char a = '*';
            kapott = kalki.Szam(tesztSzam, tesztSzam2, a);
            Assert.AreEqual(vart, kapott);
        }

        [TestMethod]
        public void Osszeadas()
        {
            double tesztSzam = 15, tesztSzam2 = 5;
            double vart = 20, kapott;
            char a = '+';
            kapott = kalki.Szam(tesztSzam, tesztSzam2, a);
            Assert.AreEqual(vart, kapott);
        }
        [TestMethod]
        public void Kivonas()
        {
            double tesztSzam = 15, tesztSzam2 = 5;
            double vart = 10, kapott;
            char a = '-';
            kapott = kalki.Szam(tesztSzam, tesztSzam2, a);
            Assert.AreEqual(vart, kapott);
        }

        //Nullára nem sikerult letesztelni

        //[TestMethod, ExpectedException(typeof(ArgumentNullException))]
        //public void osztasNulla()
        //{
        //    double tesztSzam = 15, tesztSzam2 = 0;
        //    double vart = 5, kapott;
        //    char a = '/';
        //    kalki.Szam(tesztSzam, tesztSzam2, a);

        //}
    }
}
