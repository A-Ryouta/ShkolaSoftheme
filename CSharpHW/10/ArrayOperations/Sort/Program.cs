using System;

namespace Sort
{
    internal class Program
    {
        internal static void Main()
        {
            var array = ArrayGenerator(10);
            ShowArray(array);
            Console.WriteLine();
            QuickSort(array);
            ShowArray(array);
            Console.ReadLine();
        }

        internal static int[] ArrayGenerator(int n)
        {
            var array = new int[n];
            var rand = new Random();

            for(var i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-100, 100);
            }

            return array;
        }

        internal static void ShowArray(int[] array)
        {
            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }
        }

        internal static void QuickSort(int[] arr)
        {
            QuickSort(arr, 0, arr.Length - 1);
        }

        internal static void QuickSort(int[] array, int start, int end)
        {
            while (true)
            {
                if (start >= end)
                {
                    return;
                }

                var num = array[start];

                int i = start, j = end;

                while (i < j)
                {
                    while (i < j && array[j] > num)
                    {
                        j--;
                    }

                    array[i] = array[j];

                    while (i < j && array[i] < num)
                    {
                        i++;
                    }

                    array[j] = array[i];
                }

                array[i] = num;
                QuickSort(array, start, i - 1);
                start = i + 1;
            }
        }
    }
}
