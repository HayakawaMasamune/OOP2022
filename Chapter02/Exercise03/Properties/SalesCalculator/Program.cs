using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {

            int select = 0;
            var sales = new SalesCounter("sales.csv");

            while (true) { 

            Console.WriteLine("売上高の表示選択");
            Console.WriteLine("1.店舗別");
            Console.WriteLine("２.商品カテゴリー別");
            Console.WriteLine("＞");

            select = int.Parse(Console.ReadLine());
         //   IDictionary<string, int> amountPerStore = null;
                switch (select)
                {
                    case 1:
                        OutPut(sales.GetPerStoreSales());
                        break;
                    case 2:
                        OutPut(sales.GetPerCategorySales());
                        break;

                    case 999:
                        return;
                            }
                
                }
            }
        public static void OutPut(IDictionary<string, int> amounttPerStore)
        {
            foreach (var obj in amounttPerStore)
            {
                Console.WriteLine("{0} {1}", obj.Key, obj.Value);
            }
        }
    }
}
