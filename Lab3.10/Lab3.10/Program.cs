using System;

namespace Lab3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int n = 1;
            int max;
            for (int i = 0; i < N; i++)
            {
                array[i] = n;
                n++;
                Console.Write(array[i] + " ");
            }
            max = array[0];
            for (int i = 0; i < N; i += 2)
            {
                if (array[i] > max && array[i] % 2 != 0)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
