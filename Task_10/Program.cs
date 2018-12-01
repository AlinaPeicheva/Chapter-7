using System;

namespace Task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира най-често срещания елемент в
            масив. Пример: {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3} → 4 (среща се 5 пъти).*/

            int counter = 0, tempCoun = 1, foundNum = 0;

            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведите {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr);

            for (int i = 0; i < length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCoun++;
                else tempCoun = 1;

                if (counter < tempCoun)
                {
                    counter = tempCoun;
                    foundNum = arr[i];
                }
            }
             Console.WriteLine("{0} се среща {1} пъти.", foundNum, counter);
        }
    }
}
