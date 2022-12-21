using Entities.entities;
using Repositories.Contracts;
using System.Reflection.Metadata;

using (var db = new RepositorieContext())
{
    var pdc = new Product(1,"Elma",10);
    db.Products.Add(pdc);
    db.SaveChanges();

    var products = db.Products
        .Where(pdc => pdc.Price < 1000)
        .OrderBy(pdc => pdc.Price)
        .ToList();
    foreach(Product prd in products)
    {
        Console.WriteLine(prd);
    }
}