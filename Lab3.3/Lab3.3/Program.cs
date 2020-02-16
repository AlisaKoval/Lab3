using System;

namespace Lab3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[number];
            int[] arraynew = new int[number];
            Random randomize = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomize.Next(number);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < arraynew.Length; i++)
            {


                if (i >= arraynew.Length - k)
                {
                    arraynew[i] = array[i + k - arraynew.Length];
                }
                else
                {
                    arraynew[i] = array[i + k];
                }
                Console.Write(arraynew[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
