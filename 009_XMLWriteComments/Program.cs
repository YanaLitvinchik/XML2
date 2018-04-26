using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _009_XMLWriteComments
{
    class Program
    {
        static void Main(string[] args)
        {
            var xmlWriter = new XmlTextWriter("books.xml", Encoding.GetEncoding(1251));

            xmlWriter.WriteStartDocument();                  // <?xml version="1.0"?>
            xmlWriter.WriteStartElement("ListOfBooks");      // <ListOfBooks>
            xmlWriter.WriteComment("Строка комментария.");
            xmlWriter.WriteEndElement();                     // </ListOfBooks>

            xmlWriter.Close();

        }
    }
}
