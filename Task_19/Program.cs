﻿using System;
using System.Collections.Generic;


namespace Task_19
{
    class Program
    {
        static void PrintList(List<int> nums, bool printZero = true)
        {
          //  Напишете програма, която намира всички прости числа в диапазона [1…10 000 000].
            foreach (int n in nums)
            {
                if (!printZero && n == 0) continue;
                Console.Write("{0}\t", n);
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            // 1 не е просто число
            // зададеното числото много е голямо, за да не забий намалите границите на 'i' 
            for (int i = 2; i <= 10000; ++i) nums.Add(i);

            int p = 2;
            int indexAt = 0;
            bool limitReached = false;

            while (!limitReached)
            {
                for (int i = 0; i < nums.Count; ++i)
                {
                    int v = nums[i];
                    if (v % p == 0 && v != p) nums[i] = 0;
                }
                do
                {
                    p = nums[++indexAt];
                    if (indexAt >= nums.Count - 1)
                    {
                        limitReached = true;
                        break;
                    }
                } while (p == 0);
            }

            PrintList(nums, false);
        }
    }
}
