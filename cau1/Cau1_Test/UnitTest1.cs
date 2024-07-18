using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using cau1;

namespace Cau1_Test
{
    [TestClass]
    public class UnitTest1
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data\\dataDriven.csv", "dataDriven#csv", DataAccessMethod.Sequential)]
        public void TestMethod1()
        {
            string s = TestContext.DataRow[0].ToString();
            int expResult = int.Parse(TestContext.DataRow[1].ToString());

            ClassCau1 cau1 = new ClassCau1();         
            int result = cau1.SIndex(s);

            Assert.AreEqual(expResult, result);
        }
    }
}
