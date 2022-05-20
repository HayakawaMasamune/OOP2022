﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {
                var names = new List<string>
        {
            "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","HongKong",
        };
            Exercise2_1(names);
            Console.WriteLine();
            Exercise2_2(names);
            Console.WriteLine();
            Exercise2_3(names);
            Console.WriteLine();
            Exercise2_4(names);
            Console.WriteLine();
        }
        private static void Exercise2_1(List<string> names)
        {
            Console.WriteLine("都市名を入力。空行で終了");
            do
            {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                    break;
                var index = names.FindIndex(s=> s== line);
                Console.WriteLine(index);
            } while (true); //無限ループ
        }
        private static void Exercise2_2(List<string> names)
        {
            var name = names.Count(n => n.Contains("o"));
            Console.WriteLine(name);
        }
        private static void Exercise2_3(List<string> names)
        {
            var selected = names.Where(s => s.Contains("o")).ToArray();

            foreach(var name in selected)
            {
                Console.WriteLine(name);
            }
                    }
        private static void Exercise2_4(List<string> names)
        {
            var selected = names.Where(s => s.StartsWith("B")).Select(s =>new { s.Length, s });

            foreach (var name in selected) 
            {
                Console.WriteLine(name.Length + name.s);
            }
        }
    }    
}
