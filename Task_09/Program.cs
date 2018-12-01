using System;

namespace Task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира последователност от числа,
            чиято сума е максимална. Пример: {2, 3, -6, -1,.. 2, -1, 6, 4.., -8, 8} → 11
            1. Задаём массив
            2. Вибирает последовательные числа(в разном порядке могут быть), чья сумма наибольшая*/

            int sum = 0, tempSum;

            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i);
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

            Console.WriteLine("Резултата е {0}. ", sum);
        }
    }
}
