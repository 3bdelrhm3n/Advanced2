using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Advanced2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 01:Smart Product Search
            //List<Product> electronics = Method.SearchProducts(Catalog.catalog, p => p.Category == "Electronics");
            //List<Product> clothing = Method.SearchProducts(Catalog.catalog, p => p.Category == "Clothing" && p.Price < 100);
            //List<Product> inStok = Method.SearchProducts(Catalog.catalog, p => p.Stock > 0);
            //List<Product> cheaper = Method.SearchProducts(Catalog.catalog, p => p.Price < 50);

            //Method.PrintProducts ("Electronics", electronics);
            //Method.PrintProducts("Clothing", clothing);
            //Method.PrintProducts("In Stock", inStok);
            //Method.PrintProducts("Cheaper than 50", cheaper); 
            #endregion

            #region Task 03:Custom Report Generator
            //Console.WriteLine("-------Short Report-------");
            //Method.PrintReport(Catalog.catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));
            //Console.WriteLine("-------Detailed Report-------");
            //Method.PrintReport(Catalog.catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | price: ${p.Price} | Stock: {p.Stock}")); 
            #endregion

            #region 3.2.Transform Products 
            //Console.WriteLine("------- Summary List -------");
            //List<string> summary = Method.TransformProducts(Catalog.catalog, p => $"{p.Name} (${p.Price})");
            //foreach (var i in summary)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("------- Price Labels -------");
            //List<string> priceLabels = Method.TransformProducts(Catalog.catalog,p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}");
            //foreach (var i in priceLabels)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region 3.3.Filter Products 
            //Console.WriteLine("--------Low-Stock Alert--------");
            //List<Product> lowStock = Method.FilterProducts(Catalog.catalog, p => p.Stock < 20);
            //foreach (var p in lowStock)
            //    Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");  
            #endregion

        }
    }
}

