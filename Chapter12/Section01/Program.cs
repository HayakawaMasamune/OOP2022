﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Section01 {
    class Program {
        static void Main(string[] args)
        {
        }
        //List 12-2
        //シリアル化
        public static void Serialize()
        {
            var novel = new Novel {
                Author = "ジェイムズ・P・ホーガン",
                Title = "星を継ぐもの",
                Published = 1977,
            };

            //var novels = new Novel[] {
            //   new Novel {
            //      Author = "ジェイムズ・P・ホーガン",
            //      Title = "星を継ぐもの",
            //      Published = 1977,
            //   },
            //   new Novel {
            //      Author = "H・G・ウェルズ",
            //      Title = "タイム・マシン",
            //      Published = 1895,
            //   },
            //};

            var settings = new XmlWriterSettings {
                Encoding = new System.Text.UTF8Encoding(false),
                Indent = true,
                IndentChars = "  ",
            };
            using (var writer = XmlWriter.Create("novel.xml", settings)) {
                var serializer = new DataContractSerializer(novel.GetType());
                serializer.WriteObject(writer, novel);
            }

            Display("novel.xml");
        }

        //List 12-3
        //逆シリアル化
        public static void Deserialize()
        {
            using (var reader = XmlReader.Create("novel.xml")) {
                var serializer = new DataContractSerializer(typeof(Novel));
                var novel = serializer.ReadObject(reader) as Novel;
                Console.WriteLine(novel);
            }
        }

        //XMLファイルの中身表示用
        private static void Display(string filename)
        {
            var lines = File.ReadLines(filename);
            foreach (var line in lines)
                Console.WriteLine(line);

        }


    }
}
