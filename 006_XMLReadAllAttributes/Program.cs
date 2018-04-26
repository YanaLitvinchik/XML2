using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _006_XMLReadAllAttributes
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new XmlTextReader("books.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (reader.HasAttributes)
                    {
                        while (reader.MoveToNextAttribute())
                        {
                            Console.WriteLine("{0} = {1}", reader.Name, reader.Value);
                        }
                    }
                }
            }
        }
    }
}
