using System;

namespace Lab3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[7, 7];
            int num = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    num++;
                    array[i, j] = num;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("90 degree rotetion");
           int tmp;
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        tmp = array[i, j];
                        array[i, j] = array[j, i];
                        array[j, i] = tmp;
                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j <= array.GetLength(1) / 2)
                    {

                        tmp = array[i, j];
                        array[i, j] = array[i, array.GetLength(1) - 1 - j];
                        array[i, array.GetLength(1) - 1 - j] = tmp;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}

