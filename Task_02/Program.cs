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

            bool massiv = true;

            Console.Write("Въведете дължината на първия масив: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr1 = new int[length];

            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Въведете елемент {0}: ", i);
                arr1[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("\nВъведете дължината на втория масив: ");

            if (length != Int32.Parse(Console.ReadLine())) Console.WriteLine("\nМасивите имат различна дължина.");
            else
            {
                int[] arr2 = new int[length];

                for (int i = 0; i < arr2.Length; i++)
                {
                    Console.Write("Въведете {0} елемент: ", i);
                    arr2[i] = Int32.Parse(Console.ReadLine());
                }

                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] != arr2[i])
                    {
                        Console.WriteLine("\nМасививите се различни.");
                        massiv = false;
                        break;
                    }
                }

                if (massiv) Console.WriteLine("\nМасивите се еднакви.");
            }

        }
    }
}
