using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира последователност от числа,
            чиято сума е максимална. Пример: {2, 3, -6, -1, 2, -1, 6, 4, -8, 8} → 11 */

            int sum = 0, tempSum;

            Console.Write("Enter array length: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter {0} element: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length - 1; i++)
            {
                tempSum = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    tempSum += arr[j];
                    if (tempSum > sum) sum = tempSum;
                }
            }

            Console.WriteLine("Result is {0}. ", sum);
        }
    }
}
