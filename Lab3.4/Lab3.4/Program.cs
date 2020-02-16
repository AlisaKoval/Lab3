using System;

namespace Lab3._4
{
    class Program
    {
        
        
            static int[,] sum(int[,] array1, int[,] array2, out int average)
            {
                int s = 0;
                int[,] sumarray = new int[3, 3];
                for (int i = 0; i < sumarray.GetLength(0); i++)
                {
                    for (int j = 0; j < sumarray.GetLength(1); j++)
                    {
                        sumarray[i, j] = array1[i, j] + array2[i, j];
                        Console.Write(sumarray[i, j] + " ");
                        s += sumarray[i, j];
                    }
                    Console.WriteLine();
                }
                average= s / 9;
            Console.WriteLine(average);

            return sumarray ;

            }
            static int[,] dif(int[,] array1, int[,] array2, out int average)
            {
                int s = 0;
                int[,] difarray = new int[3, 3];
                for (int i = 0; i < difarray.GetLength(0); i++)
                {
                    for (int j = 0; j < difarray.GetLength(1); j++)
                    {
                        difarray[i, j] = array1[i, j] - array2[i, j];
                        Console.Write(difarray[i, j] + " ");
                        s += difarray[i, j];
                    }
                    Console.WriteLine();
                }
                average=s / 9;
            Console.WriteLine(average);
            return difarray;
            }

        static void Main(string[] args)
        {
            int average;
                int[,] array1 = new int[3, 3];
                int[,] array2 = new int[3, 3];
                Random randomize = new Random();
                for (int i = 0; i < array1.GetLength(0); i++)
                {
                    for (int j = 0; j < array1.GetLength(1); j++)
                    {
                        array1[i, j] = randomize.Next(9);
                        Console.Write(array1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                for (int i = 0; i < array2.GetLength(0); i++)
                {
                    for (int j = 0; j < array2.GetLength(1); j++)
                    {
                        array2[i, j] = randomize.Next(9);
                        Console.Write(array2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                sum(array1, array2,out average);
                Console.WriteLine();
                dif(array1, array2, out average);
                Console.ReadKey();
            }
    }
}
