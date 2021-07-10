using System;

namespace Mat_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.WriteLine("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] Arr = new int[100, 100];

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
                    if (j > i)
                    {
                        Arr[i,j] = 0;
                    }
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

        }
    }
}
