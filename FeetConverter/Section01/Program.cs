﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        public delegate bool Judgement(int value);
        static void Main(string[] args)
        {
            Console.Write("整数：");
            int inputNum = int.Parse(Console.ReadLine());
            var numbers = new[] { 5, 3, 9, 6, 7, 5, 8, 1, 0, 5, 10, 4 };
            Judgement judge = IsEven;
            int count = Count(numbers, judge);
            Console.WriteLine(inputNum + "の個数:" + count);
        }

        public static bool IsEven(int n)
        {
            return n % 2 == 1;
        }

        public static int Count(int[] numbers,Judgement judge)
        {
            int count = 0;
            foreach (var n in numbers)
            {
                if (judge(n) == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
