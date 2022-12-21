using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public Category(int categoryId, string? categoryName)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
        }
    }
}
