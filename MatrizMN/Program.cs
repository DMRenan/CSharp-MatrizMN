using System;

namespace MatrizMN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Digite o número de colunas da matriz: ");
            int n = int.Parse(Console.ReadLine());


            MatrizMxN matriz = new MatrizMxN(m, n);
            Console.WriteLine();

            Console.Write("Digite um número para ser procurado na tabela: ");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz.Elemento(i, j) == numero)
                    {
                        Console.WriteLine($"Posição: [{i}][{j}]");

                        if (j > 0) Console.WriteLine($"Esquerda: {matriz.Elemento(i, j - 1)}");

                        if (i > 0) Console.WriteLine($"Acima: {matriz.Elemento(i-1, j)}");

                        if (i< n - 1) Console.WriteLine($"Direita: {matriz.Elemento(i, j+1)}");  
                        
                        if (j< m - 1) Console.WriteLine($"Abaixo: {matriz.Elemento(i+1, j)}");

                        Console.WriteLine();
                    }
                }
            }
        }
    }
}