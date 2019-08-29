using System;
using ArrayElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var array = new double[0];
            var result = MinElements.SummMinimumElementOfArray(array);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void NotInicializeArray()
        {
            var array = new double[5];
            var result = MinElements.SummMinimumElementOfArray(array);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void InicializeArray()
        {
            var array = new double[] { 5, -1, 12, 7, 4 };
            var result = MinElements.SummMinimumElementOfArray(array);
            Assert.AreEqual(3, result);
        }
    }
}
