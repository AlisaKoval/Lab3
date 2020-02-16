using System;

namespace Lab3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array1 = new int[5, 5];
            int[,] array2 = new int[5, 5];
            int[,] array3 = new int[5, 5];
            Random randomize = new Random();
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    array1[i, j] = randomize.Next(5);
                    Console.Write(array1[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array2.GetLength(0); i++)
            {
                for (int j = 0; j < array2.GetLength(1); j++)
                {
                    array2[i, j] = randomize.Next(7);
                    Console.Write(array2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array3.GetLength(0); i++)
            {
                for (int j = 0; j < array3.GetLength(1); j++)
                {
                    for (int k = 0; k < array2.GetLength(0); k++)
                    {
                        array3[i, j] += array1[i, k] * array2[k, j];
                    }
                    Console.Write(array3[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
