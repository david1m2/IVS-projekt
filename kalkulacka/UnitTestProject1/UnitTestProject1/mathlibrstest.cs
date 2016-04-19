using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void addtest()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(5,4);
            Assert.AreEqual(9, result);             
        }
        [TestMethod]
        public void subtest()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.add(5, 4);
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void odmtest()
        {
            matematicka.Class1 NewObject = new matematicka.Class1();
            double result = NewObject.odmocneni(3, 8);
            Assert.AreEqual(2, result);
        }
    }
}
