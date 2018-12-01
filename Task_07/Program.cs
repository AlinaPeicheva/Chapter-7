using System;

namespace Task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Да се напише програма, която чете от конзолата две цели числа N и K (K < N), както и 
            масив от N елемента. Да се намерят тези K поредни елемента, които имат максимална сума. 
            ........................................................................................
            1. Вводим N (будет длинной массива)
            2. Вводим K (будет количеством наибольших чисел, которые проссумируются)*/
            int sum = 0;

            Console.Write("Въведете N: ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Въведете K (K < N): ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведете {0} елемент: ", i);
                arr[i] = Int32.Parse(Console.ReadLine());
            }

            Array.Sort(arr, (a, b) => b.CompareTo(a));

            for (int i = 0; i < k; i++) sum += arr[i];

            Console.WriteLine("Сумата на най-големите числа е {0}", sum);
        }
    }
}
