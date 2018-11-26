using System;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се напише програма, която чете два масива от конзолата и проверява
            дали са еднакви(два масива са еднакви, когато имат еднаква
            дължина и елементите им, записани под едни и същи индекси, са еднакви).*/

            bool arraysEqual = true;

            Console.Write("Въведите дължината на първия масив: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arrA = new int[length];

            for (int i = 0; i < arrA.Length; i++)
            {
                Console.Write("Enter element {0}: ", i);
                arrA[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nВъведите дължината на втория масив: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nArrays have different lengths.");
            else
            {
                int[] arrB = new int[length];

                for (int i = 0; i < arrB.Length; i++)
                {
                    Console.Write("Въведите елемент {0}: ", i);
                    arrB[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arrA.Length; i++)
                {
                    if (arrA[i] != arrB[i])
                    {
                        Console.WriteLine("\nМасививите се различни.");
                        arraysEqual = false;
                        break;
                    }
                }

                if (arraysEqual) Console.WriteLine("\nМасивите се еднакви.");
            }

        }
    }
}
