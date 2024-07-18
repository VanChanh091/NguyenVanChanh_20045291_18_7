using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using cau3;

namespace cau3_test
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
            int value = int.Parse(TestContext.DataRow[0].ToString());
            int coSo = int.Parse(TestContext.DataRow[1].ToString());
            string exp = TestContext.DataRow[2].ToString();

            ClassCau3 cau3 = new ClassCau3();
            string result = cau3.Convert(value, coSo);

            Assert.AreEqual(exp, result);
        }
    }
}
