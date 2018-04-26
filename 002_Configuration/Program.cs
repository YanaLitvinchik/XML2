using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            var allAppSettings = ConfigurationManager.AppSettings;
            Int32 counter = 0;
            IEnumerator settingEnumerator = allAppSettings.Keys.GetEnumerator();


            while (settingEnumerator.MoveNext())
            {
                Console.WriteLine("Item: {0} Value: {1}", allAppSettings.Keys[counter], allAppSettings[counter]);
                counter++;
            }


        }
    }
}
