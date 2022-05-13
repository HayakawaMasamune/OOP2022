﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {
            if (args.Length >= 1 && args[0] == "-tom")
            {
                PrintInchToMeterList(1, 10);
            }
            else
            {
                PrintMeterToInchList(1, 10);
            }
        }
        //フィートからメートルへの対応表を出力
        private static void PrintMeterToInchList(int start, int stop)
        {
         //   InchConverter fc = new InchConverter();
            for (int inch = 1; inch <= 10; inch++)
            {
                double meter = fc.ToMeter(inch);
                Console.WriteLine("{0}inch = {1:0.0000} m", inch, meter);
            }
        }



        private static void PrintInchToMeterList(int start, int stop)
        {
            InchConverter fc = new InchConverter();
            for (int meter = 1; meter <= 10; meter++)
            {
                double inch = fc.ToMeter(meter);
                Console.WriteLine("{0} ft = {1:0.0000} m", meter, inch);

            }
        }


    }
}

