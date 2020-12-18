using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint5.Level1.Taks2
{
    class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public static void TotalPrice(ILookup<string, Product> lookup)
        {
            foreach (IGrouping<string, Product> elem in lookup)
            {
                decimal totalSum = 0;
                foreach (var str in elem)
                {
                    Console.WriteLine(str.Name + " " + str.Price);
                    totalSum += str.Price;
                }
                Console.WriteLine(elem.Key + " " + totalSum);
            }
        }
        //static void Main()
        //{
        //    var products = new List<Product>();
        //    products.Add(new Product { Name = "SmartTV", Price = 400, Category = "Electronics" });
        //    products.Add(new Product { Name = "Lenovo ThinkPad", Price = 1000, Category = "Electronics" });
        //    products.Add(new Product { Name = "Iphone", Price = 700, Category = "Electronics" });
        //    products.Add(new Product { Name = "Orange", Price = 2, Category = "Fruits" });
        //    products.Add(new Product { Name = "Banana", Price = 3, Category = "Fruits" });
        //    ILookup<string, Product> lookup = products.ToLookup(prod => prod.Category);
        //    TotalPrice(lookup);
        //    Console.ReadKey();
        //}
    }
}
