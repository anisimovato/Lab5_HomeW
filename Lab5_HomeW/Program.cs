using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("Введите числа");
            array[0] = Convert.ToInt32(Console.ReadLine());
            array[1] = Convert.ToInt32(Console.ReadLine());
            array[2] = Convert.ToInt32(Console.ReadLine());
            array[3] = Convert.ToInt32(Console.ReadLine());
            array[4] = Convert.ToInt32(Console.ReadLine());
            array[5] = Convert.ToInt32(Console.ReadLine());
            array[6] = Convert.ToInt32(Console.ReadLine());
            {
                float S = 0;
                for (int i = 0; i < 7; i++)
                {
                    S += array[i];
                    Console.Write("{0} ", array[i]);
                }

                Console.Write("{0,7:f2} ", S / 7);
            }
            Console.ReadKey();
        }
    }
}