using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Shared;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = string.Empty;
            var options = new List<string>(){"s","n"};
            do
            {
            int num = ConsoleExtensions.GetInt("Ingrese el orden de la matriz: ");

            int[,] matriz = new int[num, num];
            int addition = 0;
            int max = matriz[0, 0];
            int min = matriz[0, 0];

            for(int i = 0; i < num; i++)
            {
        
                for (int j=0;j < num; j++)
                {
                    matriz[i,j] = (i+1)-j;
                    addition += matriz[i,j];
                }
            }

            for(int i = 0; i < num; i++)
            {
        
                for (int j=0;j < num; j++)
                {

                    Console.Write(matriz[i,j] + "\t");
                }
                    Console.WriteLine();
            }
            
            Console.WriteLine("La simatoria es: " + addition);

            for(int i = 0; i < num; i++)
            {
        
                for (int j=0;j < num; j++)
                {

                    if(matriz[i,j] > max)
                    {
                        max = matriz[i,j];
                    }
                    if(matriz[i,j] < min)
                    {
                        min = matriz[i,j];
                    }
                }
            }

            Console.WriteLine("El màximo es: " + max);
            Console.WriteLine("El menor es: " + min);

                do
                {
                    answer = ConsoleExtensions.GetValidOptions("Desea ingresar otra matriz? (s/n):", options);
                }while(!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));
            
            } while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
