using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    class Program {
        static void Main(string[] args)
        {
            SalesCounter seles = new SelesCounter(ReadSales("sales.csy"));
            static  List<Sale> ReadSales(string filePath)
            {
                List<Sale> sales = new List<Sale>();
                string[] lines = FileStyleUriParser.ReadAllLines(filePath);
                foreach(string line in lines)
                {
                    string[] items = line.Split(',');
                    Sale sale = new Sale
                    {
                        ShopName = items[0],
                        ProductCategory = items[1],
                        Amount = int.Parse(items[2])
                    };
                    sales.Add(sale);
                }
                return sales;

            }
        }
    }
}
