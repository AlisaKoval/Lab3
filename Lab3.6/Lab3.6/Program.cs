using System;

namespace Lab3._6
{
    class Program
    {
        
        
            static int sumIterative(int[] array)
            {
                int sum = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
            static int sumRecursive(int[] array, int n)
            {
                if (n == 0)
                {
                    return 0;
                }
                return array[n - 1] + sumRecursive(array, n - 1);
            }
            static int minIterative(int[] array)
            {
                int min = array[0];
                for (int i = 0; i < array.Length; i++)
                {

                    if (min > array[i])
                    {
                        min = array[i];
                    }
                }
                return min;
            }
            static int minRecursive(int[] array, int n, int min, int i)
            {

                if (i < n)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                    }
                    i++;
                    return minRecursive(array, n, min, i);

                }

                else
                {
                    return min;
                }
            }
        static void Main(string[] args)
        {
                int n = int.Parse(Console.ReadLine());
                int[] array = new int[n];
                Random randomize = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = randomize.Next(n);
                    Console.Write(array[i] + " ");
                }
                Console.WriteLine();
                int sum = sumIterative(array);
                Console.WriteLine("sum=" + sum);
                int sumr = sumRecursive(array, n);
                Console.WriteLine("sumr=" + sumr);
                int min = minIterative(array);
                Console.WriteLine("min=" + min);
                int minr = minRecursive(array, n, array[0], 0);
                Console.WriteLine("minr=" + minr);
            }
        }
    }

