﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program {
    class Program {
        static void Main(string[] args)
        {
            var list = new List<string>
        {
            "Tokyo","New Delhi","Bangkok","London","Paris","Berlin","Canberra","HongKong",

        };
            var names = list.FindAll(s => s.Length <= 5);
            names.ForEach(s => Console.WriteLine(s));

           // foreach(var s in names)
            //{
             //   Console.WriteLine(s);
            //}
        }
    }
}
