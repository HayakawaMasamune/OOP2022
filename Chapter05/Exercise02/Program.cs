﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var line = Console.ReadLine();
            int number;

            if (int.TryParse(line, out number)) {
                Console.WriteLine("{0:#,#}", number);
            } else {
                Console.WriteLine("変換できませんでした");
            }
        }
    }
}
