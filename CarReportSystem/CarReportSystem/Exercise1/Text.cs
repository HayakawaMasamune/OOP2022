using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFileProcessor;

namespace Exercise1 {
    class Text : TextProcessor {

       private static Dictionary<char, char> conv = new Dictionary<char,char>() {
             {'１','1'},{'２','2'},{'３','3'},{'４','4'},{'５','5'},
    {'６','6'},{'７','7'},{'８','8'},{'９','9'},{'０','0'},
        };
        protected override void Execute(string line)
        {
            string s = new string(line.Select(n => (conv.ContainsKey(n) ? conv[n] : n)).ToArray());

        }
        //string s = new string(text.Select(n => (conv.ContainsKey(n) ? conv[n] : n)).ToArray());

    }
}
