using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
// Загрузка содержимого XML из файла.

// Примечание: В окне свойств для файла book.xml, свойству - Copy to Output Directory, присвойте значение - Copy always.
// Это необходимо чтобы файл book.xml копировался в папку рядом с *.exe файлом.

namespace _001_XML
{
    class Program
    {
        static void Main(string[] args)
        {
            // Загрузка XML из файла.
            var document = new XmlDocument();
            document.Load("books.xml");

            // Показ содержимого XML.
            Console.WriteLine(document.InnerText);

            Console.WriteLine(new string('-', 20));

            // Показ кода XML документа.
            Console.WriteLine(document.InnerXml);

        }
    }
}
