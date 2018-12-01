using System;

namespace Task_20
{
    class Program
    {
        static int wantedSum;
        static bool solution = false;

        static void GenerateSubset(int[] arr, int[] subset, int index, int current, int elementsInSubset)
        {
            /* Напишете програма, която по дадени N числа и число S, проверява дали може да се получи сума, равна на S с използване на подмасив от
             N числа(не непременно последователни).Числата N, S и стойностите на масива се четат от конзолата. 
             Пример: {2, 1, 2, 4, 3, 5, 2, 6}, S = 14 → yes (1 + 2 + 5 + 6 = 14)*/
             
            // программа выводит из данного массива сумму, которую ты хочешь найти, выведутся числа сумма которых равна твоей желанной сумме
            if (index == elementsInSubset)
            {
                CheckSubsets(subset, elementsInSubset);
                return;
            }

            for (int i = current; i < arr.Length; i++)
            {
                subset[index] = arr[i];
                GenerateSubset(arr, subset, index + 1, i + 1, elementsInSubset);
            }
        }

        static void CheckSubsets(int[] subset, int elementsInSubset)
        {
            int sum = 0;

            for (int i = 0; i < elementsInSubset; i++) sum += subset[i];

            if (sum == wantedSum)
            {
                for (int i = 0; i < elementsInSubset; i++) Console.Write("{0} ", subset[i]);

                Console.WriteLine();
                solution = true;
            }
        }

        static void Main()
        {
            Console.Write("Въведите дължината на масива: ");
            int length = int.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведите {0} eлемент: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Въведите S: ");
            wantedSum = int.Parse(Console.ReadLine());

            int[] subset = new int[length];

            for (int i = 1; i <= length; i++) GenerateSubset(arr, subset, 0, 0, i);

            if (!solution) Console.WriteLine("Не се намери подмножество с сума {0}.", wantedSum);
        }
    }
}
