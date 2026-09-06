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
            Console.Write("Ingrese el nùmero a descomponer:");
            int num = Convert.ToInt32(Console.ReadLine());

            

            /*List<int> divisors = GetDivisors(num);
            Console.WriteLine($"{num}: {string.Join(", ", divisors)}");*/
        }

        /*static List<int> GetDivisors(int num)
        {
            List<int> divisors = new List<int>();

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }*/
    }
}