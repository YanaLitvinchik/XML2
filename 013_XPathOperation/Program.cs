using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace _013_XPathOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            // Создание XPath документа.
            var document = new XPathDocument("books.xml");
            var navigator = document.CreateNavigator();

            // Вычисляющий запрос с предварительной компиляцией.
            var expression = navigator.Compile("sum(ListOfBooks/Book/Price/text())");

            Console.WriteLine(expression.ReturnType);

            if (expression.ReturnType == XPathResultType.Number)
            {
                sum = (double)navigator.Evaluate(expression);
                Console.WriteLine(sum);
            }

            // Вычисляющий запрос без предварительной компиляции.
            // Кроме выборки производится арифметическое вычисление.
            sum = (double)navigator.Evaluate("sum(//Price/text())*10");
            Console.WriteLine(sum);

        }
    }
}
