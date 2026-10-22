using System;
using System.Collections.Generic;
using System.Text;
namespace Advanced2
{
    internal class Catalog
    {
       public static List<Product> catalog = new List<Product>
        {
            new Product (1, "Laptop", "Electronics", 1200, 10),
            new Product (2, "Smartphone", "Electronics", 800, 25),
            new Product (7, "T-shirt", "Clothing", 30, 100),
            new Product (8, "Jeans", "Clothing", 60, 50),
            new Product (5, "Chocolate", "Food", 5, 200),
            new Product (4, "Coffee Beans", "Food", 15, 80),
            new Product (3, "C# Book", "Books", 45, 30),
            new Product (6, "Novel", "Books", 20, 60),
            new Product (10, "HeadPhones", "Electronics", 150, 40),
            new Product (9, "Jacket", "Clothing", 120, 15),
        };
    }
}

