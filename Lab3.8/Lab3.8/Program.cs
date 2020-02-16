using System;

namespace Lab3._8
{
    class Program
    {


        static int Det(int[,] A, int N)
        {
            int DetA = 0;
            if (N == 1)
            {
                return A[0, 0];
            }
            else if (N == 2)
            {
                return A[0, 0] * A[1, 1] - A[0, 1] * A[1, 0];
            }
            else
            {

                int[,] Minor = new int[N - 1, N - 1];
                int a = 0, b = 0;

                for (int j = 0; j < N; j++)
                {
                    a = 0;
                    for (int k = 1; k < N; k++)
                    {
                        b = 0;
                        for (int s = 0; s < N; s++)
                        {
                            if (s != j)
                            {

                                Minor[a, b] = A[k, s];
                                b++;
                            }
                        }
                        a++;
                    }
                    DetA += (int)Math.Pow(-1, 2 + j) * A[0, j] * Det(Minor, N - 1);

                }

                return DetA;
            }
        }


        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int[,] A = new int[N, N];
            Random randomize = new Random();
            for (int j = 0; j < A.GetLength(0); j++)
            {
                for (int i = 0; i < A.GetLength(1); i++)
                {
                    A[i, j] = randomize.Next(N * N);
                    Console.Write(A[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("DetA=" + Det(A, N));
            Console.ReadKey();

        }
    }
    
}
