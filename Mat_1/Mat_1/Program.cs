using System;

namespace Mat_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            int sum = 0;
            string[] str;
            Console.WriteLine("Введите N M: ");
            str = Console.ReadLine().Split(' ');

            N = Convert.ToInt32(str[0]);
            M = Convert.ToInt32(str[1]);

            int[,] Arr = new int [100,100];

            Console.WriteLine("Ns" + N + "Ms" + M);
            Console.WriteLine("Array: " + '\n');

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += Arr[i, j];
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Arr[i,j] + " ");
                }

                Console.Write('\n');
            }
            Console.WriteLine('\n' + "Sum = " + sum);
        }
    }
}
