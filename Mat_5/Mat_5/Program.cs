using System;

namespace Mat_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            int min = 0;
            int minRow = 0;
            int maxInt;
            string[] str;
            Console.WriteLine("Введите N M: ");
            str = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите Max: ");
            maxInt = Convert.ToInt32(Console.ReadLine());

            N = Convert.ToInt32(str[0]);
            M = Convert.ToInt32(str[1]);

            int[,] Arr = new int[100, 100];

            Console.WriteLine("Array: " + '\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Arr[i, j] + " ");
                }
                Console.Write('\n');
            }

            for (int i = 0; i < N; i++)
            {
                min += Arr[i, 0];
            }

            for (int i = 0; i < N; i++)
            {
                int minSum = 0;
                for (int j = 0; j < M; j++)
                {
                    minSum += Arr[i, j];
                }
                if (minSum < min)
                {
                    minRow = i;
                    min = minSum;
                }
            }
            Console.Write("Min");
            for (int i = 0; i < N; i++)
            {
                Console.Write(Arr[minRow, i] + " ");
            }
        }
    }
}
