using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //var a = 1;
            //var b = 2;
            //Assert.AreEqual(a + b, 3);

            int result = ClassLibraryPractice.Class1.Addition(10, 5);
            Assert.AreEqual(result, 15);
        }
    }
}
