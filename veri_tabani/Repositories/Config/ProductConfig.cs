using Entities.entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductName).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.HasData(
                new Product(1,"Mac",18_000),
                new Product(2,"AirPods",5_000),
                new Product(3,"Iphone",20_000),
                new Product(4,"Huawei",10_000),
                new Product(5,"Samsun",14_000)
                );
        }
    }
}
