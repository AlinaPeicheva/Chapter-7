using System;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Напишете програма, която намира максималната подредица от нарастващи елементи в масив arr[n].
              Елементите може и да не са последователни.Ако има няколко такива подредици, намерете найлявата от тях.
              Пример: { 9, 6, 2, 7, 4, 7, 6, 5, 8, 4} → { 2, 4, 7, 8}.*/

            int counter = 0, tempIndex, tempCounter;

            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведите {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < length; i++)
            {
                int[] tempResult = new int[length];
                tempIndex = tempCounter = 1;
                tempResult[0] = arr[i];

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] > tempResult[tempIndex - 1])
                    {
                        tempResult[tempIndex] = arr[j];
                        tempIndex++;
                        tempCounter++;
                    }
                    else if (tempIndex > 1 && arr[j] > tempResult[tempIndex - 2] && arr[j] < tempResult[tempIndex - 1]) tempResult[tempIndex - 1] = arr[j];
                }

                if (counter < tempCounter)
                {
                    counter = tempCounter;
                    result = tempResult;
                }
            }

            for (int i = 0; i < counter; i++) Console.Write("{0}, ", result[i]);
        }

    }
}

