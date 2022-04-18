using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MatrizMN
{
    internal class MatrizMxN
    {
        public int m { get; set; }
        public int n { get; set; }
        public int[,] matriz { get; set; }

        public MatrizMxN(int m, int n)
        {
            this.m = m;
            this.n = n;
            this.matriz = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Insira o valor do elemento [{i}][{j}] : ");
                    int elemento = int.Parse(Console.ReadLine());
                    matriz[i, j] = elemento;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"-----Matriz {m}x{n}-----");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{matriz[i, j]} ");
                }
                Console.WriteLine();
            }
        }

        public int Elemento(int i, int j)
        {
            return matriz[i, j];
        }
    }
}