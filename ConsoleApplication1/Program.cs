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
        static void One(XmlTextReader reader)
        {
            bool wnd = false;
            bool wth = false;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (!wth && reader.Name.Equals("symbol"))
                    {
                        Console.Write("Current Weather: ");
                        Console.WriteLine($"{reader.GetAttribute("desc")}");
                        wth = true;
                    }
                    if (reader.Name.Equals("tempmin"))
                    {
                        Console.Write("tempmin: ");
                        Console.WriteLine($"{reader.GetAttribute("value")}{reader.GetAttribute("unit")}");
                    }
                    if (!wnd && reader.Name.Equals("wind"))
                    {
                        Console.Write("wind: ");
                        Console.WriteLine($"{reader.GetAttribute("value")}{reader.GetAttribute("unit")}");
                        wnd = true;
                    }
                }
            }

        }
        static void Three(XmlTextReader reader)
        {
            bool wnd = false;
            bool wth = false;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element)
                {
                    if (!wth && reader.Name.Equals("symbol"))
                    {
                        Console.Write("Current Weather: ");
                        Console.WriteLine($"{reader.GetAttribute("desc")}");
                        wth = true;
                    }
                    if (reader.Name.Equals("tempmin"))
                    {
                        Console.Write("tempmin: ");
                        Console.WriteLine($"{reader.GetAttribute("value")}{reader.GetAttribute("unit")}");
                    }
                    if (!wnd && reader.Name.Equals("wind"))
                    {
                        Console.Write("wind: ");
                        Console.WriteLine($"{reader.GetAttribute("value")}{reader.GetAttribute("unit")}");
                        wnd = true;
                    }
                }
            }
        }
        static void TomW(XmlTextReader reader)
        {
            //;
            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Element &&
                    reader.Name == "name")
                {
                    reader.Read();
                    switch (reader.Value)
                    {
                        case "Мин. температура":
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "forecast")
                                {
                                    Console.WriteLine(reader.GetAttribute("value"));
                                    break;
                                }
                            }
                            break;
                        case "Макс. температура":
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "forecast")
                                {
                                    Console.WriteLine(reader.GetAttribute("value"));
                                    break;
                                }
                            }
                            break;
                        case "Ветер":
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "forecast")
                                {
                                    Console.WriteLine(reader.GetAttribute("value"));
                                    break;
                                }
                            }
                            break;
                        case "Метеорологический знак":
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "forecast")
                                {
                                    Console.WriteLine(reader.GetAttribute("value"));
                                    break;
                                }
                            }
                            break;
                        case "День":
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "forecast")
                                {
                                    Console.WriteLine(reader.GetAttribute("value"));
                                    break;
                                }
                            }
                            break;
                        case "Состояние атмосферы":
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element &&
                                    reader.Name == "forecast")
                                {
                                    Console.WriteLine(reader.GetAttribute("value"));
                                    break;
                                }
                            }
                            break;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            var reader = new XmlTextReader("http://api.pogoda.com/index.php?api_lang=ru&localidad=13088&affiliate_id=4v7j6at7rkya&v=2&h=1");
            One(reader);
            Console.WriteLine("<------------------------>");
            var reader_2 = new XmlTextReader("http://api.pogoda.com/index.php?api_lang=ru&localidad=13088&affiliate_id=4v7j6at7rkya&v=2");
            Three(reader_2);
            Console.WriteLine("<------------------------>");
            var reader_3 = new XmlTextReader("http://api.pogoda.com/index.php?api_lang=ru&localidad=13088&affiliate_id=4v7j6at7rkya");
            TomW(reader_3);
        }
    }
}

//weather now: temp, speed of wind, weath
//weather after 3 h 
//tomorrow weather