using System;
using ArrayElements;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void EmptyArray()
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

        [TestMethod]
        public void OneElementInArray()
        {
            var array = new double[] { 1 };
            var result = MinElements.SummMinimumElementOfArray(array);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void OversizeArray()
        {
            var array = new double[1000];
            var rand = new Random();
            for (int i=0;i<1000;i++)
                array[i] = rand.NextDouble() * i;
            array[20] = -1;
            array[400] = -5;
            Assert.AreEqual(array[20] + array[400], MinElements.SummMinimumElementOfArray(array));
        }
    }
}
