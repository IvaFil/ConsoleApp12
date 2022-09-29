using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void FillArray(int[] arr, int i = 0)
        {
            if (i < arr.Length)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                FillArray(arr, i + 1);
            }
        }


        static void PrintArray(int[] arr, int i = 0)
        {
            int sum = 0;
            if (i < arr.Length)
            {
                if (arr[i] > 0)
                {
                    sum++;
                }
                PrintArray(arr, i + 1);
                Console.WriteLine(sum);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Введи число элементов: ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[M];
            Console.WriteLine("Введи элементы массива: ");
            FillArray(arr);

            Console.WriteLine("Массив: ");
            int sum = 0;
            PrintArray(arr, sum);

        }
    }
}
