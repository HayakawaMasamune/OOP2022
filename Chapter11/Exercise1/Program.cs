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

            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
        }

        private static void Exercise1_1(string file)
        {
            //匿名クラス　P284
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                             .Select(x => new {
                                 Name = x.Element("name").Value,
                                 Teammembers = x.Element("teammembers").Value
                             });
            foreach (var sport in sports) {
                Console.WriteLine("{0} {1}", sport.Name, sport.Teammembers);
            }

        }

        private static void Exercise1_2(string file)
        {
            var xdoc = XDocument.Load(file);
            var sports = xdoc.Root.Elements()
                .Select(x => new {
                    Firstplayed = x.Element("firsrplayed").Value,
                    Name = x.Element("name").Attribute("kanji").Value
                })
                .OrderBy(x => int.Parse(x.Firstplayed));
            foreach (var sport in sports) {
                Console.WriteLine("{0}({1})", sport.Name, sport.Firstplayed);
            }
        }

        private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load(file);
            var sport = xdoc.Root.Elements()
                .Select(x => new {
                    Name = x.Element("name").Value,
                    Teammembers = x.Element("teammembers").Value
                })
                .OrderByDescending(x => int.Parse(x.Teammembers)).FirstOrDefault();
            Console.WriteLine("{0}({1})人)", sport.Name, sport.Teammembers);
        }

        private static void Exercise1_4(string file, string newfile)
        {
            //要素の追加  P290
            var element = new XElement("balldport",
                new XElement("name", "サッカー"),
                new XElement("kanji", "蹴球"),
                new XElement("firstplayed", "1863"));

            var xdoc = XDocument.Load("balldport");
            xdoc.Root.Add(element);


                

        }
    }
}
