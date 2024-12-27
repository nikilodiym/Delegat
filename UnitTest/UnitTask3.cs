using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    internal class UnitTask3
    {
        private static int number;

        [TestMethod]
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int)
        {
            return number % 2 != 0;
        }

    }
}
