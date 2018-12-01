using System;

namespace Task_21
{
    class Program
    {
        public static int[] findSolution(int[] a, bool[] filter, int index, int s, int size)
        {
            /* Напишете програма, която по дадени N, K и S намира К на брой елементи
            измежду N-те числа, чиято сума е точно S или показва, че това е
            невъзможно. Пример: {3, 1, 2, 4, 9, 6}, S = 14, K = 3 → yes (1 + 4 + 9 = 14)*/

            // нужно ввести количество чифр(N) - массив, потом задаёшь K(количество цифр котрые просуммируются, поставь 2, не ошибёшься),
            // среди них должна быть неторая сумма, которую ты введёшь.
            if (index < a.Length)
            {
                filter[index] = true;
                int[] x = findSolution(a, filter, index + 1, s, size);

                if (x.Length > 0) return x;
                else
                {
                    filter[index] = false;
                    return findSolution(a, filter, index + 1, s, size);
                }
            }
            else
            {
                int sum = 0, count = 0;

                for (int i = 0; i < a.Length; i++)
                {
                    if (filter[i])
                    {
                        sum += a[i];
                        count++;
                    }
                }

                int[] solution = new int[0];

                if (sum == s && count == size)
                {
                    solution = new int[count];
                    count = 0;

                    for (int i = 0; i < a.Length; i++) if (filter[i]) solution[count++] = a[i];
                }
                return solution;
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Въведете N = ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Въведете K = ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Сума на елементите, s = ");
            int s = int.Parse(Console.ReadLine());

            int[] solution = findSolution(arr, new bool[arr.Length], 0, s, size);

            Console.Write("Сумата {0} се образува от: ", s);
            for (int i = 0; i < solution.Length; i++) Console.Write(solution[i] + "; ");
            Console.ReadLine(); 
        } 
    }
}
