using System;
using System.Collections.Generic;

namespace Task_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която сортира целочислен масив по алгоритъмa "quick sort".
            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведите {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Quicksort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
        }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0) i++;

                while (elements[j].CompareTo(pivot) > 0) j--;

                if (i <= j)
                {
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;
                    i++;
                    j--;
                }
            }

            if (left < j) Quicksort(elements, left, j);

            if (i < right) Quicksort(elements, i, right);
        }
    }
}
