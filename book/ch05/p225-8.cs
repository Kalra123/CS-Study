using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.ch05
{
    class User
    {
        public string name;
        public string password;
        public string addr;
        public string phoneNumber;
        public DateTime regDate;
    }
    class Program
    {
        class Product
        {
            public string name;
            public int price;

        }
        static void Main1(string[] args)
        {
            Product product = new Product();
        }
        static void Main2(string[] args)
        {
            //인스턴스를 생성합니다.
            Product product = new Product();

            //인스턴스 변수를 변경합니다.
            product.name = "감자";
            product.price = 2000;

            // 인스턴스 변수를 출력합니다.
            Console.WriteLine(product.name + " : " + product.price + "원");

        }
        class Product1
        {
            public string name = "default";
            public int price = 1000;
        }
        class Program2
        {
            public string name;
            public int price;

        }

        static void Main(string[] args)
        {
            Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };
        }
    }

}