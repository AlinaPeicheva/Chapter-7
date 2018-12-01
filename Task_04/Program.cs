using System;

namespace Task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира максимална редица от последователни
              еднакви елементи в масив. Пример: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1} → {2, 2, 2}.*/

            int count = 1, tempCount = 1, number = 0;

            Console.Write("Въведете дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Въведете {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1]) tempCount++;
                else tempCount = 1;

                if (tempCount > count)
                {
                    count = tempCount;
                    number = arr[i];
                }
            }

            for (int i = 0; i < count; i++) Console.Write("{0}, ", number);
            Console.WriteLine();
        }
    }
}
