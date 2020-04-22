using System;
using System.Collections.Generic;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            List<int> my_list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите целое число");               
                x = Convert.ToInt32(Console.ReadLine());
                if ((x % 2) != 0)
                {
                    my_list.Add(x);
                }
                else
                {
                    my_list.Insert(0, x);

                }
                foreach (int y in my_list)
                {
                    Console.Write(y+" ");
                    
                }
                Console.WriteLine();
            }
                // Random rand = new Random();
                // for (int i = 0; i < 10; i++)
                // {
                //     my_list.Add(rand.Next(110));

                // }
                // foreach (int x in my_list)
                // {
                //     Console.WriteLine(x);
                // }
                // Console.WriteLine("SORT");
                // my_list.Sort();
                // foreach (int x in my_list)
                // {
                //     Console.WriteLine(x);
                // }
                // Console.WriteLine("REVERSE SORT");
                // my_list.Reverse();
                // foreach (int x in my_list)
                // {
                //     Console.WriteLine(x);
                // }
                // Console.WriteLine("Max");
                // int max = my_list[0];

                //     Console.WriteLine(max);

                // Console.WriteLine("Min");
                //int min = my_list[my_list.Count-1];

                //     Console.WriteLine(min);


        }
    }
}
