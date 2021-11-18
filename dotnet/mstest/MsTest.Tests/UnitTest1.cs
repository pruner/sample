using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MsTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(4, Calculator.Add(2, 2));
        }
        
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, Calculator.Add(2, 2));
        }
    }
}
