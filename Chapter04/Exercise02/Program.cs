﻿using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args)
        {//4.2.1
            var ymCollection = new YearMonth[] {

                new YearMonth (1980,2),
                new YearMonth (1990,4),
                new YearMonth (2000,6),
                new YearMonth (2010,2),
                new YearMonth (2020,10),
            };

            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("----");

            //4.2.4
            Exercise2_4(ymCollection);
            Console.WriteLine("----");

            Exercise2_5(ymCollection);
            Console.WriteLine("----");

            Exercise2_6(ymCollection);

        }
        private static void Exercise2_6(YearMonth[] ymCollection)
        {
            foreach (var ym in ymCollection.Where(ym => DateTime.IsLeapYear(ym.Year))) {
                Console.WriteLine(ym);
            }

            var date = ymCollection.Max(ym => ym.Month);
            Console.WriteLine(date);
        }
        //4.2.3 
        static YearMonth FindFirst21C(YearMonth[] yms)
        {
            foreach (var y in yms) {
                if (y.Is21Century) {
                    return y;
                }
            }

            return null;
        }
        private static void Exercise2_2(YearMonth[] ymCollection)
        {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);

            }
        }
        private static void Exercise2_4(YearMonth[] ymCollection)
        {
            var yearmonth = FindFirst21C(ymCollection);
            if (yearmonth != null) {
                Console.WriteLine(yearmonth);
            } else {
                Console.WriteLine("21世紀のデータはありません");
            }
        }
        private static void Exercise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth());
            foreach(var ym in array) {
                Console.WriteLine(ym);
            }
        }
       
            //var ym = new YearMonth(2002, 12);

            // var check = ym.Is21Century;
            // var test = ym.AddOneMonth();

            // Console.WriteLine(ym);

        }
    }

