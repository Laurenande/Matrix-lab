using System;

namespace MatEkz
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            int pro = 1;
            Console.WriteLine("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] Arr = new int[N, N];

            Console.WriteLine("Array: " + '\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (j == N - 1 - i)
                    {
                        pro *= Arr[i, j];
                    }
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = N - i; j < N; j++)
                {
                    Arr[i, j] = 0;
                }
            }

            Console.Write('\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(Arr[i, j] + " ");
                }
                Console.Write('\n');
            }
            Console.Write("Произведени: " + pro);
        }
    }
}
