using System;

namespace Lab3._7
{
    class Program
    {
        static int fib (int N)
        {
            if (N==1)
            {
                return (N);
            }
            else if (N==0)
            {
                return (N);
            }
            else
            {
                return fib(N - 1) + fib(N - 2);
            }
        }
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(fib(N));
            Console.ReadKey();
        }
    }
}
