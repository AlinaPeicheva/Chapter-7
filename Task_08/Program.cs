using System;

namespace Task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сортиране на масив означава да подредим елементите му в нарастващ
            ред. Напишете програма, която сортира масив. Да се
            използва алгоритъма "selection sort". */
             int i, j, iMin, temp;

             Console.Write("Въведете дължината на масив: ");
             int length = Int32.Parse(Console.ReadLine());

             int[] arr = new int[length];

             for (i = 0; i < length; i++)
             {
                 Console.Write("Въведете {0} елемент: ", i);
                 arr[i] = Int32.Parse(Console.ReadLine());
             }

             for (j = 0; j < length - 1; j++)
             {
                 iMin = j;

                 for (i = j + 1; i < length; i++) if (arr[i] < arr[iMin]) iMin = i;

                 if (iMin != j)
                 {
                     temp = arr[j];
                     arr[j] = arr[iMin];
                     arr[iMin] = temp;
                 }
             }

             for (i = 0; i < length; i++) Console.Write("{0} ", arr[i]);
           
        }
    }
}
