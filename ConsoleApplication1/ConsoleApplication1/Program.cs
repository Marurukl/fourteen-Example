using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Прочитать содержимое XML файла со списком последних новостей по ссылке https://habrahabr.ru/rss/interesting/
            //Создать класс Item со свойствами: Title, Link, Description, PubDate.
            //Создать коллекцию типа List< Item > и записать в нее данные из файла.
            //2.На основании задания 1, сериализовать лист полученных объектов в XML и записать в файл.
            XmlDocument document = new XmlDocument();
            List<Item> items = new List<Item>();
            document.Load("https://habrahabr.ru/rss/interesting/");


        }
    }
}
