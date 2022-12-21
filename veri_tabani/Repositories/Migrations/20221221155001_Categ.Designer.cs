﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repositories.Contracts;

#nullable disable

namespace Repositories.Migrations
{
    [DbContext(typeof(RepositorieContext))]
    [Migration("20221221155001_Categ")]
    partial class Categ
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Entities.entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Bilgisayar"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Akıllı Telefon"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Yiyecek"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Giyecek"
                        });
                });

            modelBuilder.Entity("Entities.entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Price = 18000f,
                            ProductName = "Mac"
                        },
                        new
                        {
                            Id = 2,
                            Price = 5000f,
                            ProductName = "AirPods"
                        },
                        new
                        {
                            Id = 3,
                            Price = 20000f,
                            ProductName = "Iphone"
                        },
                        new
                        {
                            Id = 4,
                            Price = 10000f,
                            ProductName = "Huawei"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
