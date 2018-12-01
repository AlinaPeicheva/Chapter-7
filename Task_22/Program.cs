using System;

namespace Task_22
{
    class Program
    {
        static void Main(string[] args)
        {   /* Напишете програма, която прочита от конзолата масив от цели числа и премахва минимален брой числа, така че останалите числа да са
            сортирани в нарастващ ред. Отпечатайте резултата. Пример: {6, 1, 4, 3, 0, 3, 6, 4, 5} → {1, 3, 3, 4, 5}
            
             1. Задай размер массива
             2. Введите числа, они отсортируются так, что остануться числа которые повтаряються чаще и в восходящем образе*/

            int subset = 0, longestLength = 0;

            Console.Write("Въведете дължината на массива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведете {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            int m = (1 << length);
            int[,] subsets = new int[m, length];

            for (int i = 0; i < m; i++)
                for (int j = 0; j < length; j++) subsets[i, j] = i / (m / 2 / (1 << j)) % 2;

            for (int i = 0; i < m; i++)
            {
                int max = -1000, count = 0;

                for (int j = 0; j < length; j++)
                {
                    if (subsets[i, j] > 0)
                    {
                        if (arr[j] >= max)
                        {
                            count++;
                            max = arr[j];
                        }
                        else
                        {
                            count = 0;
                            break;
                        }
                    }
                }

                if (longestLength < count)
                {
                    longestLength = count;
                    subset = i;
                }
            }

            Console.WriteLine("Резултат:");
            for (int i = 0; i < length; i++) if (subsets[subset, i] > 0) Console.Write(arr[i] + "; ");
        }
    }
}
