using System;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира максималната редица от последователни
              нарастващи елементи в масив. Пример: {3, 2, 3, 4, 2, 2, 4} → {2, 3, 4}.*/

            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int first = 1, second = 1, bestInt = 0, lastElement = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведите {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] + 1 == arr[i + 1])
                {
                    first++;
                    if (first > second)
                    {
                        second = first;
                        lastElement = i + 1;
                        bestInt = lastElement - second + 1;
                    }
                }
                else first = 1;
            }

            for (int i = bestInt; i < second + bestInt; i++) Console.WriteLine("Редица от нарастващи числа няма. Максималното число е {0} ", arr[i]);
        }
    }
}
