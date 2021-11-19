using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Введите число=");
            N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = 1 - (i + j) % 2; //проверка на четность, ищем остаток от деления на 2, Если число четное, результатом будет 0, если нечетное – 1.
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
