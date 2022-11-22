using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_6_2
{
    public class Product : IProduct,IComparable<Product>, IFormattable
    {
        private int _productId;
        private string? _productName;
        private decimal _unitPrice;
        private Int16 _unitInStock;
        public int ProductId { get => _productId; set => _productId = value; }
        public string ProductName { get => _productName; set => _productName = value; }
        public decimal UnitPrice { get => _unitPrice; set => _unitPrice = value; }
        public Int16 UnitsInStocks { get => _unitInStock; set => _unitInStock = value; }

        public List<Product> _products;

        public Product()
        {
            _products = new List<Product>();
            Console.WriteLine("default ctor.");
        }
        public Product(List<Product> products)
        {
            _products = products;
        }

        public Product(int productId, string productName, decimal unitPrice, Int16 unitsInStocks)
        {
            ProductId = productId;
            ProductName = productName;
            UnitPrice = unitPrice;
            UnitsInStocks = unitsInStocks;
        }

        public void GetProduct()
        {
            _products.Sort();
            foreach (var item in _products)
            {
                Console.WriteLine(item);
            }
        }

        public override string? ToString()
        {
            return this.ToString(null,null);
        }

        public decimal GetUnitPrice(int id)
        {
            return 0;
        }

        //public int CompareTo(Product? other)
        //{
        //    return this.ProductId.CompareTo(other.ProductId);
        //}

        public int CompareTo(Product? other)
        {
            return this.UnitPrice.CompareTo(other.UnitPrice);
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            if (String.IsNullOrEmpty(format)) format = "ID";
            if (formatProvider == null) formatProvider = CultureInfo.CurrentCulture;
            switch (format)
            {
                case "ID":
                    return $" {ProductId} {ProductName} {UnitPrice} {UnitsInStocks} ";

                case "N":
                    return $"  {ProductName} {ProductId} {UnitPrice} {UnitsInStocks} ";
                case "P":
                    return $" {UnitPrice} {ProductName} {ProductId}  {UnitsInStocks} ";
                case "S":
                    return $" {UnitsInStocks} {ProductName} {ProductId} {UnitPrice}  ";
                default:
                    throw new Exception();
            }
        }
    }
}
