using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace OszthatoTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
                           //AAA
            string vartEredmeny = "Hello Bello";


            //Action
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);
                ConsoleWrite.Program.Main();
                var kapottEredmeny = sw.ToString().Trim();
                //Assert
                Assert.AreEqual(kapottEredmeny, vartEredmeny);
            }

        }
    }
}
