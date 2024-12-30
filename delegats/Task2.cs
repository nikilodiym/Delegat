using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegats
{
    public class Task2
    {
        public static void DisplayCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current Time: " + currentTime.ToString("HH:mm:ss"));
        }

        public static void DisplayCurrentDate()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("Current Date: " + currentDate.ToString("MM/dd/yyyy"));
        }

        public static void DisplayCurrentDayOfWeek()
        {
            DateTime currentDay = DateTime.Now;
            Console.WriteLine("Current Day of Week: " + currentDay.ToString("dddd"));
        }

        public static double CalculateTriangleArea(double baseLength, double height)
        {
            return 0.5 * baseLength * height;
        }

        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }
    }
}
