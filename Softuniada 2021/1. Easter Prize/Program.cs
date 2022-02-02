using System;
using System.Collections.Generic;

namespace _1._Easter_Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            List<int> primes = new List<int>();
            for (int i = n; i <= m; i++)
            {
                if (i < 2)
                {
                    continue;
                }
                if (IsItPrime(i))
                {
                    primes.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ",primes));
            Console.WriteLine($"The total number of prime numbers between {n} to {m} is {primes.Count}");
        }
        public static bool IsItPrime(int num)
        {
            bool result = false;
            int n, i, m = 0, flag = 0;
            n = num;
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                result = true;
            }
            return result;
        }
    }
}
