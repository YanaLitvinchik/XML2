using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _003_XMLString
{
    class Program
    {
        static void Main(string[] args)
        {
            string xmlData = "<?xml version='1.0' encoding='utf-8' ?><Book><Title>CLR via C#</Title></Book>";

            var stringReader = new StringReader(xmlData);
            var reader = new XmlTextReader(stringReader);

            while (reader.Read())
            {
                Console.WriteLine("{0,-15} {1,-10} {2,-10}",
                    reader.NodeType.ToString(),
                    reader.Name,
                    reader.Value);
            }

            reader.Close();
	
        }
    }
}
