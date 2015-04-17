using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test2
{
    class Item
    {
        string name; //{get;set;}
        decimal price; //{get;set;}
        int quantity; //{ get; set; }

        public Item(string n, decimal p, int q)
        {
            name = n;
            price = p;
            quantity = q;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price;}
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public decimal GetCostItem()
        {
            return Price * Quantity;
        }
    }
}
