using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace TestConsoleWrite
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConsoleWrite()
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
