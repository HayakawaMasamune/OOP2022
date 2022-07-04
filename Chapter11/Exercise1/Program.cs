using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args)
        {
            var file = "sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);


        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load("sports.xml");
            var sports = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = x.Element("name").Value,
                                    Teammembers = x.Element("teammembers").Value
                                }) ;
            foreach (var sport in sports) {
                Console.WriteLine("{0} ({1}",
                                   sport.Name, sport.Teammembers);
            }


        }

        private static void Exercise1_2(string file)
        {
            throw new NotImplementedException();
        }

        private static void Exercise1_3(string file)
        {
            throw new NotImplementedException();
        }

        private static void Exercise1_4(string file, string newfile)
        {
            throw new NotImplementedException();
        }
    }
}
