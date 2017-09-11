using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace SecondExample
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //2.На основании задания 1, сериализовать лист полученных объектов в XML и записать в файл.
            string path = @"C:\Games\ItemXml.xml";

            XmlDocument document = new XmlDocument();

            List<Item> items = new List<Item>();

            document.Load("https://habrahabr.ru/rss/interesting/");

            
            XmlNode node = document.DocumentElement;

            XmlNode channel = node["channel"];

            if (channel.HasChildNodes)
            {
                foreach (XmlNode otherNode in channel.ChildNodes)
                {
                    if (otherNode.Name == "item")
                    {
                        Item item = new Item();
                        item.Title = otherNode["title"].InnerText;
                        item.Link = otherNode["link"].InnerText;
                        item.Description = otherNode["description"].InnerText;
                        item.PubDate = otherNode["pubDate"].InnerText;
                        items.Add(item);
                    }
                }
            }
            document.Save(path);
               // простите за такой подход просто пробывал создать файл , но он ругалься что файл используется в другом процессе вот и пришлось в ручную создовать

            Console.ReadLine();
        }
    }
}
