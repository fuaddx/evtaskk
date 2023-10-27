
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal class Product
    {
        public int _count;
        public decimal _price;

        public int Count { get => _count; set {; } }
        public decimal Price { get => _price; set {; } }


        public Product(int count, decimal price)
        {
            Count = count;
            Price = price;
        }
    }
}
