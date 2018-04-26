using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _004_XMLAllElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new XmlDocument();
            document.Load("books.xml");

            XmlNode root = document.DocumentElement;

            // Напечатает "document.DocumentElement=ListOfBooks"
            Console.WriteLine("document.DocumentElement = {0}", root.LocalName);

            foreach (XmlNode books in root.ChildNodes)
            {
                Console.WriteLine("Found Book:");
                foreach (XmlNode book in books.ChildNodes)
                {
                    Console.WriteLine(book.Name + ": " + book.InnerText);
                    Console.WriteLine(book.Attributes);
                }
                Console.WriteLine(new string('-', 40));

                // Напечатает сначала строку Title-150, затем Title-2150.
                // Эти строки являются слиянием текста двух узлов корневого элемента.
                //    Console.WriteLine(books.InnerText);
            }
        }
    }
}
