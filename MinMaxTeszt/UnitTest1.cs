using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MinMaxUt;
using System.IO;

namespace MinMaxTeszt
{   
    [TestClass]
    public class MinMaxOsztalyTest
    {
        //arrange
        MyClass klass = new MyClass(1);
        string vart = "A minimum szám: 1, helye: 0 || A maximum szám: 100, helye: 99";
        [TestMethod]
        public void MinMaxTest()
        {
            //Act
            using (StringWriter sw = new StringWriter())
            {
                
                Console.SetOut(sw);
                klass.kaka();
                string kapott = sw.ToString().Trim();
                //Assert
                Assert.AreEqual(kapott, vart);
            }
        }
    }
}
