﻿// <auto-generated />
using System;
using ASP.NET_CORE_6_REST_API_Shop_Example.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP.NET_CORE_6_REST_API_Shop_Example.Migrations
{
    [DbContext(typeof(ShopDBContext))]
    [Migration("20220504155236_Shop_Example_DBSet")]
    partial class Shop_Example_DBSet
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ASP.NET_CORE_6_REST_API_Shop_Example.Models.ShopProduct", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("ProductCreationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("DateTimeOffset")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("ProductDescription")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTimeOffset>("ProductModificationDate")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("DateTimeOffset")
                        .HasDefaultValueSql("GETUTCDATE()");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(150)");

                    b.Property<decimal>("ProductPrice")
                        .HasColumnType("Smallmoney");

                    b.HasKey("Id");

                    b.ToTable("ShopProducts");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f874d74f-c215-441f-87de-e1c8aa037d6f"),
                            ProductCreationDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ProductDescription = "Very Good and Quckly Phone, for alldays use.",
                            ProductModificationDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ProductName = "Mobile Phone X",
                            ProductPrice = 988.99m
                        },
                        new
                        {
                            Id = new Guid("ea755709-32ce-4c35-96e6-dd27ca631deb"),
                            ProductCreationDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ProductDescription = "Very Good and Comfortable Chair, for alldays use.",
                            ProductModificationDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ProductName = "Chair Y",
                            ProductPrice = 189.99m
                        },
                        new
                        {
                            Id = new Guid("652a0584-2d73-4a47-83cb-378f3e60984a"),
                            ProductCreationDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ProductDescription = "Very Good and Quckly Printer, for alldays use.",
                            ProductModificationDate = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ProductName = "Printer Z",
                            ProductPrice = 85.99m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
