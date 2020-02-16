using System;

namespace Lab3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[9, 9];
            Random randomize = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = randomize.Next(9);
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    if (i == j)
                    {
                        int sum = 0;
                        for (int k = 0; k < 9; k++)
                        {
                            if (k != i)
                            {
                                sum += array[i, k];
                                array[i, j] = sum;
                            }
                        }
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
