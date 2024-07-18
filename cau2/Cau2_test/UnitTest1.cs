using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using cau2;

namespace Cau2_test
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
            int n = int.Parse(TestContext.DataRow[0].ToString());
            int expResult = int.Parse(TestContext.DataRow[1].ToString());

            ClassCau2 cau2 = new ClassCau2();
            int result = cau2.Tong(n);

            Assert.AreEqual(expResult, result);
        }
    }
}
