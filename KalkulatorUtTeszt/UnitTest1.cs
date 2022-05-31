using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KalkulatorUt;

namespace KalkulatorUtTeszt
{
    
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Osztas()
        {
            Kalki kalki = new Kalki(15,5,'/');
            double vart = 3, kapott;
            kapott = kalki.Szam();
            Assert.AreEqual(vart, kapott);
            kalki = null;
        }
        [TestMethod]
        public void Szorzas()
        {
            Kalki kalki = new Kalki(15, 5, '*');
            
            double vart = 75, kapott;

            kapott = kalki.Szam();
            Assert.AreEqual(vart, kapott);
            kalki = null;
        }

        [TestMethod]
        public void Osszeadas()
        {
            Kalki kalki = new Kalki(15, 5, '+');
            double vart = 20, kapott;
            kapott = kalki.Szam();
            Assert.AreEqual(vart, kapott);
            kalki = null;
        }
        [TestMethod]
        public void Kivonas()
        {
            Kalki kalki = new Kalki(15, 5, '-');
            double vart = 10, kapott;
            char a = '-';
            kapott = kalki.Szam();
            Assert.AreEqual(vart, kapott);
            kalki = null;
        }
        [TestMethod]
        public void OsztasRossz()
        {
            Kalki kalki = new Kalki(15, 5, '/');
            double vart = 4, kapott;
            kapott = kalki.Szam();
            Assert.AreNotEqual(vart, kapott);
            kalki = null;
        }
        [TestMethod]
        public void SzorzasRossz()
        {
            Kalki kalki = new Kalki(15, 5, '*');

            double vart = 76, kapott;

            kapott = kalki.Szam();
            Assert.AreNotEqual(vart, kapott);
            kalki = null;
        }

        [TestMethod]
        public void OsszeadasRossz()
        {
            Kalki kalki = new Kalki(15, 5, '+');
            double vart = 21, kapott;
            kapott = kalki.Szam();
            Assert.AreNotEqual(vart, kapott);
            kalki = null;
        }
        [TestMethod]
        public void KivonasRossz()
        {
            Kalki kalki = new Kalki(15, 5, '-');
            double vart = 11, kapott;
            char a = '-';
            kapott = kalki.Szam();
            Assert.AreNotEqual(vart, kapott);
            kalki = null;
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
