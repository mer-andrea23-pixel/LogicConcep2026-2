using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el orden de la matriz:");
            int num = Convert.ToInt32(Console.ReadLine());

            int[,] matriz = new int[num, num];
            int suma = 0;
            int mayor = matriz[0, 0];
            int menor = matriz[0, 0];

            for(int i = 0; i < num; i++)
            {
        
                for (int j=0;j < num; j++)
            {
                matriz[i,j] = (i+1)-j;
                suma += matriz[i,j];
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
            
            Console.WriteLine("La simatoria es: " + suma);

              for(int i = 0; i < num; i++)
            {
        
                for (int j=0;j < num; j++)
            {

                if(matriz[i,j] > mayor)
                    {
                        mayor = matriz[i,j];
                    }
                if(matriz[i,j] < menor)
                    {
                        menor = matriz[i,j];
                    }
            }
            }

            Console.WriteLine("El màximo es: " + mayor);
            Console.WriteLine("El menor es: " + menor);
        }
    }
}
