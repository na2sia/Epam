﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Sum = 0;
            List<Item> ArrayList = new List<Item>();
            Random r = new Random();
            string[] name = new string[] { "1", "2", "3", "4" };
            decimal[] price = new decimal[] { 1000, 2500, 3600 };
            int[] quantity = new int[] { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < 100000; i++)
                ArrayList.Add(new Item(
                    name[r.Next(0, name.Length)],
                    price[r.Next(0, price.Length)],
                    quantity[r.Next(0, quantity.Length)]
                    ));

           /* for (int i = 0; i < 100000; i++)
            {
                Console.WriteLine("Name - {0}, Price - {1}, Quantity - {2}", ArrayList[i].Name, ArrayList[i].Price, ArrayList[i].Quantity);
            }*/
            for (int i = 0; i < 100000; i++)
            {
                Sum = Sum + ArrayList[i].GetCostItem();
            }
              Console.Write("Sum - {0}",Sum);
              Console.ReadKey();

        }
    }
}
