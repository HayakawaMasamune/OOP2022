﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args)
        {
            //5.1
            var inputString1 = Console.ReadLine();
            var inputString2 = Console.ReadLine();

            if (String.Compare(inputString1, inputString2, ignoreCase:true) == 0) {
                Console.WriteLine("等しい");
            } else {
                Console.WriteLine("等しくない");
            }
            Console.WriteLine("-------");

        }
    }
}
