using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest2
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void ThVoSoNghiem()
        {
            SimpleEquation s = new SimpleEquation(0, 0);
            Assert.AreEqual("VSN", s.SingleEquation());

        }
        public void ThMotSoNghiem()
        {
            SimpleEquation s = new SimpleEquation(2, 1);
            Assert.AreEqual("-0.5", s.SingleEquation());

        }
        public void ThVoNghiem()
        {
            SimpleEquation s = new SimpleEquation(0, 1);
            Assert.AreEqual("VN", s.SingleEquation());

        }
    }
}
