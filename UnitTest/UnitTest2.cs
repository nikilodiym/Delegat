using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Add_ShouldReturnCorrectResult()
        {
            int a = 5;
            int b = 3;

            int result = Add(a, b);

            Assert.AreEqual(8, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnCorrectResult()
        {
            int a = 10;
            int b = 4;

            int result = Subtract(a, b);

            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnCorrectResult()
        {
            int a = 7;
            int b = 2;

            int result = Multiply(a, b);

            Assert.AreEqual(14, result);
        }

        private int Add(int a, int b)
        {
            return a + b;
        }

        private int Subtract(int a, int b)
        {
            return a - b;
        }

        private int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
