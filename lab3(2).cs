using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3Slovnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> countries = new Dictionary<int, string>(5);
            countries.Add(11, "Russia");
            countries.Add(3, "Great Britain");
            countries.Add(2, "USA");
            countries.Add(14, "France");
            countries.Add(5, "China");
            countries.Add(6, "Ukraine");
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }

            // получение элемента по ключу
            string country = countries[14];
            // изменение объекта
            countries[4] = "Spain";
            Console.WriteLine("\nNew Dictionary");
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            // удаление по ключу
            //countries.Remove(2);
            Console.WriteLine("\nNew Dictionary");
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine(countries[11]);
            
            int max = 0;
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                if(max<keyValue.Key)
                {
                    max = keyValue.Key;
                }           
            }
            Console.WriteLine("max=" + max);
            int min = 200000000;
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                if (min > keyValue.Key)
                {
                    min = keyValue.Key;
                }
            }
            Console.WriteLine("min=" + min);
            countries.Remove(min);
            countries.Remove(max);
            Console.WriteLine("\nNew Dictionary");
            foreach (KeyValuePair<int, string> keyValue in countries)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            var list = countries.Keys.ToList();
            list.Sort();
            Dictionary<int, string> items = new Dictionary<int, string>();
            List<KeyValuePair<int, string>> values = new List<KeyValuePair<int, string>>(countries);
            //values.Sort(new myCompared());

            foreach (KeyValuePair<int, string> item in values)
            {
                // Add to collection.
                items.Add(item.Key, item.Value);
            }

            // Loop through keys.
            Console.WriteLine("\nSort 1 Dictionary");
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, countries[key]);
            }
            // ... Use LINQ to specify sorting by value.
            //var items = from pair in countries
            //            orderby pair.Key ascending
            //            select pair;
            //Console.WriteLine("\nSort Dictionary");
            //foreach (KeyValuePair<int, string> keyValue in items)
            //{
            //    Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            //}
        }
    }
}
