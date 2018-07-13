using System;
using ConsoleApp3.product;
using ConsoleApp3.utity;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {   
            Product[] products = new Product[5];
            var productname = "";
            for (int i = 0; i < 5; i++)
            {
                if (i < 3)
                {
                    products[i] = new Book();
                    productname = string.Format("Product {0}", i + 1);
                    products[i].Name = productname;
                    products[i].Id = i;
                    products[i].Price = 2500;
                    Console.WriteLine("Product {0} -Book: (id={1},name={2},price={3}) - computeTax = {4}", i,
                        products[i].Id, products[i].Name, products[i].Price, products[i].computeTax());
                }
                else
                {
                    products[i] = new Phone();
                    productname = string.Format("Product {0}", i + 1);
                    products[i].Name = productname;
                    products[i].Id = i;
                    products[i].Price = 5000;
                    Console.WriteLine("Product {0} -Phone: (id={1},name={2},price={3}) - computeTax = {4}", i,
                        products[i].Id, products[i].Name, products[i].Price, products[i].computeTax());
                }
            }
        }
    }
}