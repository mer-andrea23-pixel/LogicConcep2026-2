using System;
using System.Collections.Generic;
using System.Linq;
using Shared;

namespace FactorPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = ConsoleExtensions.GetInt("Ingrese el nùmero a descomponer:");
            
            List<int> factores = GetFactors(num);
            Console.WriteLine($"{num}: {string.Join(" x ", factores)}");

        }

        static List<int> GetFactors(int num)
        {
            List<int> factores = new List<int>();

            while (num % 2 == 0)
            {
                factores.Add(2);
                num /= 2;
            }

            for (int divisor = 3; divisor*divisor <= num; divisor += 2)
            {
                while(num % divisor == 0)
                {
                    factores.Add(divisor);
                    num /= divisor;
                }
            }

            if (num > 1)
            {
                factores.Add(num);
            }

            return factores;
        }
    }
}