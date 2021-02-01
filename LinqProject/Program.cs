using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, ProductName="Acer Laptop", QuantityPerUnit="32GB RAM", UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=1, ProductName="Asus Laptop", QuantityPerUnit="16GB RAM", UnitPrice=8000,UnitsInStock=3},
                new Product{ProductId=1, ProductName="HP Laptop", QuantityPerUnit="8GB RAM", UnitPrice=6000,UnitsInStock=2},
                new Product{ProductId=1, ProductName="Samsung Telefon", QuantityPerUnit="32GB RAM", UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=1, ProductName="Apple Telefon", QuantityPerUnit="32GB RAM", UnitPrice=8000,UnitsInStock=0}
            };

            //Algorithmic:

            //foreach (var product in products)
            //{
            //if (product.UnitPrice>5000 && product.UnitsInStock>3)
            //{
            //Console.WriteLine(product.ProductName);
            //}               
            //}           

            var result = products.Where(p => p.UnitPrice > 5000 && p.UnitsInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }


        }
    }
}
