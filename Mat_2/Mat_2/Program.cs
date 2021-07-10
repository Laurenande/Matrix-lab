using System;

namespace Mat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M, K;
            int count = 0;
            string[] str;
            Console.WriteLine("Введите N M: ");
            str = Console.ReadLine().Split(' ');
            Console.WriteLine("Введите K: ");
            K = Convert.ToInt32(Console.ReadLine());

            N = Convert.ToInt32(str[0]);
            M = Convert.ToInt32(str[1]);

            int[,] Arr = new int[100, 100];

            Console.WriteLine("Array: " + '\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Arr[i,j] == K)
                    {
                        count++;
                    }
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(Arr[i,j] + ' ');
                }
                Console.WriteLine('\n');
            }

            Console.WriteLine('\n' + "K кол-во: " + count);
        }
    }
}
