using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class Program {
        static void Main(string[] args)
        {

            TextProcessor.Run<Text>(@"C:\Users\infosys\source\repos\OOP2022\Chapter12\Section02\Program.cs");
        }
    }
    
}
