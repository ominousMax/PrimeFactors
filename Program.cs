using System;
using System.Collections.Generic;

namespace PrimeFactorsTask
{
    public static class PrimeFactors
    {
        public static void Main()
        {
            foreach (int num in GetFactors(60))
            {
                Console.Write(num + " ");
            }
        }

        public static int[] GetFactors(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Number can not be less or equal to 0", nameof(number));
            }

            int i = 2;
            List<int> result = new List<int>();
            while (number != 1)
            {
                while (number % i == 0)
                {
                    result.Add(i);
                    number /= i;
                }

                do
                {
                    i++;
                }
                while (!Isprime(i));
            }

            return result.ToArray();
        }

        public static bool Isprime(int j)
        {
            for (int i = 2; i <= j / i; i++)
            {
                if ((j % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
