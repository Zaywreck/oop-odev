using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.entities
{
    public class CartItem
    {
        public int CartId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }

        public CartItem(int cartId, Product product, int quantity)
        {
            CartId = cartId;
            Product = product;
            Quantity = quantity;
        }

        public override string? ToString()
        {
            return $"Id: {CartId} Product: {Product} Quantity: {Quantity}";
        }
    }
}
