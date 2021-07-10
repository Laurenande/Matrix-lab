using System;

namespace Mat_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool sim = false;
            Console.WriteLine("Введите N: ");
            N = Convert.ToInt32(Console.ReadLine());

            int[,] Arr = new int[100, 100];

            Console.WriteLine("Array: " + '\n');
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Arr[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (Arr[i, j] != Arr[j, i])
                    {
                        sim = false;
                    }
                    else
                    {
                        sim = true;
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
            if (sim)
            {
                Console.WriteLine("Симметрична");
            }
            else
            {
                Console.WriteLine("Не симметрична");
            }
        }
    }
}
