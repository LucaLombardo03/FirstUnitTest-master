using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextExample_1;

namespace ExampleMethodTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod] 
        public void TestCalcolo1()
        {
            {
                bool resp = Method.Calcolo1();
                Assert.AreEqual(true, resp);
            }
        }
        public void TestCalcolo2()
        {
            {
                bool resp = Method.Calcolo2();
                Assert.AreEqual(false, resp);
            }
        }
        public void TestCalcolo3()
        {
            {
                bool resp = Method.Calcolo3();
                Assert.AreEqual(true, resp);
            }
        }
        public void TestCalcolo4()
        {
            {
                bool resp = Method.Calcolo4();
                Assert.AreEqual(false, resp);
            }
        }
    }
}