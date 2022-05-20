using System;
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
          var query = list.Select(s =>s.Length);

            foreach(var s in query)
            {
                Console.WriteLine(s);
            }
            

            
            
        }
    }
}
