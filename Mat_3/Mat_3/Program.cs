using System;

namespace Mat_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;
            int min, max;
            string[] str;
            Console.WriteLine("Введите N M: ");
            str = Console.ReadLine().Split(' ');

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

            min = Arr[0,0];
            max = Arr[0,0];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Arr[i,j] < min)
                    {
                        min = Arr[i,j];
                    }

                    if (Arr[i,j] > max)
                    {
                        max = Arr[i,j];
                    }
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

            Console.WriteLine("Min: " + min + '\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Arr[i,j] == min)
                    {
                        Console.Write("[" + (i + 1) + ", " + (j + 1) + "] = " + Arr[i,j]);
                        Console.Write('\n');
                    }
                }
            }

            Console.WriteLine('\n' + "Max: " + max + '\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    if (Arr[i,j] == max)
                    {
                        Console.Write("[" + (i + 1) + ", " + (j + 1) + "] = " + Arr[i,j]);
                        Console.Write('\n');
                    }
                }
            }

        }
    }
}
