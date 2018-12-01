using System;

namespace Task_16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Да се реализира двоично търсене (binary search) в сортиран целочислен
              масив, за да открие конкретен елемент.*/
            Console.Write("Въведите дължината на масива: ");
            int length = Int32.Parse(Console.ReadLine());

            int[] arr = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.Write("Въведите {0} eлемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Console.Write("Въведите търсяното число: ");
            int number = Int32.Parse(Console.ReadLine());

            int index = Array.BinarySearch(arr, number);

            if (index >= 0) Console.Write("Числото {0} е с индекс {1}.", number, index);
            else Console.Write("Числото не е намеряно.");
        }
    }
}
