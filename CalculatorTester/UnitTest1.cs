using CALCULATOR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculatorTester
{
    [TestClass]
    public class UnitTest1
    {
        private Class1 cal;
        [TestInitialize]
        public void SetUp()
        {
            this.cal = new Class1(10, 5);
        }
        [TestMethod]
        public void TestAddOperator()
        {
            //testcase 
            /* int put 10.5
             * out put 15
             */
            Class1 cal = new Class1(10, 5);
            Assert.AreEqual(15, cal.Execute("+"));
        }

        [TestMethod]
        public void TestSubOperator()
        {
            Assert.AreEqual(5, cal.Execute("-"));
        }
        [TestMethod]
        public void TestMulOperator()
        {
            Assert.AreEqual(50, cal.Execute("*"));
        }
        [TestMethod]
        public void TestDivOperator()
        {
            Assert.AreEqual(2, cal.Execute("/"));
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByZero()
        {
            Class1 c = new Class1(2, 0);
            c.Execute("/");
        }
    }
}
