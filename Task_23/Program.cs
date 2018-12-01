using System;

namespace Task_23
{
    class Program
    {
         /* Напишете програма, която прочита две цели числа N и K от конзолата
            и отпечатва всички вариации на K елементите на числата от интервала [1…N].
            Пример: N = 3, К = 2 → {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3} 
            
             1. N - количество цифр из которых будут состояться числа
             2. К - количество цифр в числе */
        public static int n;

        static void Main(string[] args)
        {
            Console.Write("Въведете N: ");
            n = Int32.Parse(Console.ReadLine());

            Console.Write("Въведете K: ");
            int k = Int32.Parse(Console.ReadLine());

            int[] arr = new int[k];

            recSol(arr, 0);
        }

        static void recSol(int[] array, int index)
        {
            if (index != array.Length)
                for (int i = 1; i <= n; i++)
                {
                    array[index] = i;
                    recSol(array, index + 1);
                }
            else
            {
                for (int i = 0; i < array.Length; i++) Console.Write(array[i] + " ");
                Console.WriteLine();
            }
        }
    }
}
