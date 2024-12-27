namespace delegats
{
    public class Task1
    {
        public delegate bool NumberFilter(int number);

        public static List<int> GetEvenNumbers(int[] array)
        {
            return GetNumbers(array, IsEven);
        }

        public static List<int> GetOddNumbers(int[] array)
        {
            return GetNumbers(array, IsOdd);
        }

        public static List<int> GetPrimeNumbers(int[] array)
        {
            return GetNumbers(array, IsPrime);
        }

        public static List<int> GetFibonacciNumbers(int[] array)
        {
            return GetNumbers(array, IsFibonacci);
        }

        private static List<int> GetNumbers(int[] array, NumberFilter filter)
        {
            List<int> numbers = new List<int>();

            foreach (int number in array)
            {
                if (filter(number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        private static bool IsEven(int number)
        {
            return number % 2 == 0;
        }

        private static bool IsOdd(int number)
        {
            return number % 2 != 0;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsFibonacci(int number)
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
