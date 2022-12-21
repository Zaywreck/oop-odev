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
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId); // We defined Primary key here!
            builder.Property(c=> c.CategoryName).IsRequired();
            builder.HasData(
                new Category(1, "Bilgisayar"),
                new Category(2, "Akıllı Telefon"),
                new Category(3, "Yiyecek"),
                new Category(4, "Giyecek"),
                new Category(5, "İçecek")
                );

        }
    }
}
