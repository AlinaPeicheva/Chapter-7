using System;
using System.Collections.Generic;

namespace Task_17
{
    class Program
    {
        static void Main(string[] args)
        {
            // Напишете програма, която сортира целочислен масив по алгоритъма "merge sort".
            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            MergeSortRecursive(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);
        }

        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, leftEnd, numElements, poss;

            leftEnd = (mid - 1);
            poss = left;
            numElements = (right - left + 1);

            while ((left <= leftEnd) && (mid <= right))
            {
                if (numbers[left] <= numbers[mid]) temp[poss++] = numbers[left++];
                else temp[poss++] = numbers[mid++];
            }

            while (left <= leftEnd) temp[poss++] = numbers[left++];

            while (mid <= right) temp[poss++] = numbers[mid++];

            for (i = 0; i < numElements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSortRecursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSortRecursive(numbers, left, mid);
                MergeSortRecursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }
    }
}
