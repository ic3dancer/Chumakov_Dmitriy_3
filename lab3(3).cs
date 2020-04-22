using System;
using System.Collections.Generic;
using System.Linq;
namespace laba3_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int x,y;
            Dictionary<string, int> eda = new Dictionary<string, int>();
            Console.WriteLine("\t\tСоздание словаря продуктов");
            do
            {
                Console.WriteLine("Введите товар: ");
                s = Console.ReadLine();
                Console.WriteLine("Введите цену: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("товар: " + s + " цена: " + x);
                eda.Add(s, x);
                Console.WriteLine("\tпродолжить? 0-да, 1-нет");
                y = Convert.ToInt32(Console.ReadLine());
            } while (y == 0);
            Console.WriteLine("\tСписок товаров");
            foreach (KeyValuePair<string, int> keyValue in eda)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            var eda100 = from n in eda
                          where n.Value > 100
                          select n;
            Console.WriteLine("\tТовары дороже 100 грн: "); // Выполнить запрос и отобразить его результаты. 
            foreach (KeyValuePair<string, int> keyValue in eda100)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();
            var eda99 = from n in eda
                         where n.Value < 100
                         select n;
            Console.WriteLine("\tТовары дешевле 100 грн: "); // Выполнить запрос и отобразить его результаты. 
            foreach (KeyValuePair<string, int> keyValue in eda99)
            {
                Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
            }
            Console.WriteLine();
      }
    }
}
