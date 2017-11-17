using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = ArrayGenerator(10);
            ShowArray(array);
            Console.WriteLine();
            QuickSort(array);
            ShowArray(array);
            Console.ReadLine();
        }

        static int[] ArrayGenerator(int n)
        {
            int[] array = new int[n];
            Random rand = new Random();
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }
            return array;
        }
        static void ShowArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write("{0} ", element);
            }
        }
        static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }
        static void QuickSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int num = arr[start];

            int i = start, j = end;

            while (i < j)
            {
                while (i < j && arr[j] > num)
                {
                    j--;
                }

                arr[i] = arr[j];

                while (i < j && arr[i] < num)
                {
                    i++;
                }

                arr[j] = arr[i];
            }

            arr[i] = num;
            QuickSort(arr, start, i - 1);
            QuickSort(arr, i + 1, end);
        }
    }
}
