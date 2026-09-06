using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = ConsoleExtensions.GetInt("Ingrese el nùmero a descomponer:");
            
            List<int> factors = GetFactors(num);
            Console.WriteLine($"{num}: {string.Join(" x ", factors)}");

        }

        static List<int> GetFactors(int num)
        {
            List<int> factors = new List<int>();

            while (num % 2 == 0)
            {
                factors.Add(2);
                num /= 2;
            }

            for (int divisor = 3; divisor*divisor <= num; divisor += 2)
            {
                while(num % divisor == 0)
                {
                    factors.Add(divisor);
                    num /= divisor;
                }
            }

            if (num > 1)
            {
                factors.Add(num);
            }

            return factors;
        }
    }
}