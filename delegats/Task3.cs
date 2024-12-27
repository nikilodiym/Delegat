using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegats
{
    public class Task3
    {
        public static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        public static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        public static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        public static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;

            while (b < number)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return b == number;
        }
    }
}
