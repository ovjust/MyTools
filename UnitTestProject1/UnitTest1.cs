using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = int.MaxValue;
        }


        [TestMethod]
        public void TestMethod2()
        {
          
            string s = "";
            var a = new Guid(s);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Directory.CreateDirectory("D:\\.ssh");
        }
    }


   

}
