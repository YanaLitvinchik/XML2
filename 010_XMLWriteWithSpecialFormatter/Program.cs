using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _010_XMLWriteWithSpecialFormatter
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", null)
            {
                Formatting = Formatting.Indented,
                IndentChar = '\t',
                Indentation = 1,
                QuoteChar = '\''
            };

            // Включить форматирование документа (с отступом).

            // Для выделения уровня элемента использовать табуляцию.
            // использовать один символ табуляции.

            // Аналогично можно указать выравнивание с помощью четырех пробелов.
            xmlWriter.IndentChar = ' ';
            xmlWriter.Indentation = 4;

            // По умолчанию строки в XML файл записываются с помощью двойных кавычек.
            // Использование одиночных кавычек производится так:

            xmlWriter.WriteStartDocument();

            xmlWriter.WriteStartElement("ListOfBooks");
            xmlWriter.WriteStartElement("ListOfBooks", "http://localhost/test");
            xmlWriter.WriteStartElement("prefix", "ListOfBooks", "http://localhost/test");

            xmlWriter.Close();

        }
    }
}
