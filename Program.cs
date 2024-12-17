using System;

namespace Delegat
{
    delegate double MyDelegate(double a);

    class Program
    {
        static double Step1(double a)
        {
            a = 2 + 3 - 4;
            Console.WriteLine($"Step1 (2 + 3 - 4): {a}");
            return a;
        }

        static double Step2(double a)
        {
            a *= a;
            Console.WriteLine($"Step2 (a^2): {a}");
            return a;
        }

        static double Step3(double a)
        {
            a += 3;
            Console.WriteLine($"Step3 (a + 3): {a}");
            return a;
        }

        static void Main(string[] args)
        {
            MyDelegate calc = Step1;
            calc += Step2;
            calc += Step3;

            double result = 0.0;

            foreach (MyDelegate step in calc.GetInvocationList())
            {
                result = step(result);
            }

            Console.WriteLine($"Final Result: {result}");
        }
    }
}
