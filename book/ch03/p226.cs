using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch03
{
    internal class p226
    {
        class Product
        {
            public string Name;
            public int price;

        }
        static void Main(string[] args)
        {
            Product product = new Product();

            product.Name = "감자";
            product.price = 2000;

            Console.WriteLine(product.Name +" : "+product.price + "원");
        }
    }
}
