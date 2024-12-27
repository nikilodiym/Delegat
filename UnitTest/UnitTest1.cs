namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = GetEvenNumbers(array);
            List<int> oddNumbers = GetOddNumbers(array);
            List<int> primeNumbers = GetPrimeNumbers(array);
            List<int> fibonacciNumbers = GetFibonacciNumbers(array);

            CollectionAssert.AreEqual(new int[] { 2, 4, 6, 8, 10 }, evenNumbers);
            CollectionAssert.AreEqual(new int[] { 1, 3, 5, 7, 9 }, oddNumbers);
            CollectionAssert.AreEqual(new int[] { 2, 3, 5, 7 }, primeNumbers);
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 5, 8 }, fibonacciNumbers);
        }

        public List<int> GetEvenNumbers(int[] array)
        {
            List<int> evenNumbers = new List<int>();
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    evenNumbers.Add(num);
                }
            }
            return evenNumbers;
        }

        public List<int> GetOddNumbers(int[] array)
        {
            List<int> oddNumbers = new List<int>();
            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    oddNumbers.Add(num);
                }
            }
            return oddNumbers;
        }

        public List<int> GetPrimeNumbers(int[] array)
        {
            List<int> primeNumbers = new List<int>();
            foreach (int num in array)
            {
                if (IsPrime(num))
                {
                    primeNumbers.Add(num);
                }
            }
            return primeNumbers;
        }

        public List<int> GetFibonacciNumbers(int[] array)
        {
            List<int> fibonacciNumbers = new List<int>();
            foreach (int num in array)
            {
                if (IsFibonacci(num))
                {
                    fibonacciNumbers.Add(num);
                }
            }
            return fibonacciNumbers;
        }

        public bool IsPrime(int num)
        {
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public bool IsFibonacci(int num)
        {
            int a = 0;
            int b = 1;
            while (b < num)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return b == num;
        }
    }
}