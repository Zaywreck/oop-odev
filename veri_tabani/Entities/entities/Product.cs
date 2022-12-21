using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } 
        public float Price { get; set; }
        public Product(int id, string productName, float price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }

        public override string? ToString()
        {
            return $"{ProductName} {Price}";
        }
    }
}
