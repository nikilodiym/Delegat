using delegats;
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
        public void TestDisplayCurrentTime()
        {
            Task2.DisplayCurrentTime();
        }

        [TestMethod]
        public void TestDisplayCurrentDate()
        {
            Task2.DisplayCurrentDate();
        }

        [TestMethod]
        public void TestDisplayCurrentDayOfWeek()
        {
            Task2.DisplayCurrentDayOfWeek();
        }

        [TestMethod]
        public void TestCalculateTriangleArea()
        {
            double baseLength = 10;
            double height = 5;
            double expected = 25;
            double actual = Task2.CalculateTriangleArea(baseLength, height);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestCalculateRectangleArea()
        {
            double length = 10;
            double width = 5;
            double expected = 50;
            double actual = Task2.CalculateRectangleArea(length, width);
            Assert.AreEqual(expected, actual);
        }
    }
}
