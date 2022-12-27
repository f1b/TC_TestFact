using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using static Factorial.FactorialFunction;

namespace FactorialUnitTest
{
    [TestClass]
    public class FactorialFunctionUnitTest
    {
        private const double delta = 0.0001;

        [TestMethod]
        public void TestFact0()
        {
            int a = 0;
            double factorial = ComputeFactorial(a);
            Assert.AreEqual(1.0, factorial, delta);
        }

        [TestMethod]
        public void TestFact1()
        {
            int a = 1;
            double factorial = ComputeFactorial(a);
            Assert.AreEqual(1.0, factorial, delta);
        }

        [TestMethod]
        public void TestFact4()
        {
            int a = 4;
            double factorial = ComputeFactorial(a);
            Assert.AreEqual(24.0, factorial, delta);
        }

        [TestMethod]
        public void TestFactExceptionCatch()
        {
            int a = -99999;
            Assert.ThrowsException<ArgumentException>(() => ComputeFactorial(a));
        }
    }
}
