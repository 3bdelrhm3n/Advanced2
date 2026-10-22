using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced2
{
    public  class Method
    {
        // use delegate Func<Product, bool> to filter products based on a condition
        //public static List<Product>SearchProducts(List<Product> products, Func<Product, bool> filter)
        //{
        //    List<Product> result = new List<Product>();
        //    foreach (var p in products)
        //    {
        //        if (filter(p))
        //        {
        //            result.Add(p);
        //        }
        //    }
        //    return result;
        //}
        //// use delegate Action<Product> to perform an action on each product
        //public static void PrintProducts(string tittle, List<Product> list)
        //{
        //    Console.WriteLine($"--- {tittle} ---");
        //    foreach (var p in list )
        //    {
        //        Console.WriteLine($"Id: {p.Id}, Name: {p.Name}, Category: {p.Category}, Price: {p.Price}, Stock: {p.Stock}");
        //    }
        //}
        //// use delegate Action<Product> to perform an action on each product
        //public static void PrintReport(List<Product> products ,Action<Product >action)
        //{
        //    foreach (var p in products)
        //    {
        //        action(p);
        //    }
        //}
        //// use delegate Func<Product, TResult> to transform products into a different type
        //public static List<TResult> TransformProducts <TResult>(List<Product>products , Func<Product ,TResult> transform)
        //{
        //    List<TResult> result = new List<TResult>();
        //    foreach (var p in products)
        //        result.Add(transform(p));
        //    return result;
        //}
        //// use delegate Predicate<Product> to filter products based on a condition
        //public static List<Product> FilterProducts (List <Product> products , Predicate<Product> condition)
        //{
        //    List<Product> result = new List<Product>();
        //    foreach (var p in products)
        //        if (condition(p)) result.Add(p);
        //    return result;
        //}


    }
}
