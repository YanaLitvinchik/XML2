using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 (Устарел)
            string value = ConfigurationSettings.AppSettings["Foo"];
            Console.WriteLine(value);

            Console.WriteLine(new string('-', 12));

            // 2
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;

            Console.WriteLine(allAppSettings["Foo"]);
            Console.WriteLine(allAppSettings[0]);

            Console.WriteLine(new string('-', 12));

            // 3
            for (int i = 0; i < allAppSettings.Count; i++)
            {
                Console.WriteLine(allAppSettings[i]);
            }

            Console.WriteLine(new string('-', 12));

            // 4
            foreach (string item in allAppSettings)
            {
                Console.WriteLine(allAppSettings[item]);
            }
        }
    }
}
