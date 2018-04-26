using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _011_XPath
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание XPath документа.
            var document = new XPathDocument("books.xml");
            XPathNavigator navigator = document.CreateNavigator();

            // Прямой запрос XPath.
            XPathNodeIterator iterator1 = navigator.Select("ListOfBooks/Book/Title");
            while (iterator1.MoveNext())
            {
                Console.WriteLine(iterator1.Current);
            }
            Console.WriteLine(new string('-', 20));
            // Скомпилированный запрос XPath
            XPathExpression expr = navigator.Compile("ListOfBooks/Book[2]/Price");
            XPathNodeIterator iterator2 = navigator.Select(expr);

            while (iterator2.MoveNext())
            {
                Console.WriteLine(iterator2.Current);
            }

        }
    }
}
