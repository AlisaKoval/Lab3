using System;

namespace Lab3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number of array elements");
            int number = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            Random randomizer = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine();
                }
                array[i] = randomizer.Next(-35, 40);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = number - 1; i >= 0; i--)
            {
                if (array[i] >= 0)
                {
                    Console.Write(array[i] + " ");
                }
            }
            Console.ReadKey();
        }
    }
}
