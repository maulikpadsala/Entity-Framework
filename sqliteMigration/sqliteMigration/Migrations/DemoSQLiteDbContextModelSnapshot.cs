﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sqliteMigration.Contexts;

namespace sqliteMigration.Migrations
{
    [DbContext(typeof(DemoSQLiteDbContext))]
    partial class DemoSQLiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.1");

            modelBuilder.Entity("sqliteMigration.Model.Product", b =>
                {
                    b.Property<int>("productId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(250);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("saleItemId")
                        .HasColumnType("INTEGER");

                    b.HasKey("productId");

                    b.HasIndex("saleItemId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("sqliteMigration.Model.SaleItem", b =>
                {
                    b.Property<int>("saleItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("endDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("saleName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<DateTime>("startDate")
                        .HasColumnType("TEXT");

                    b.HasKey("saleItemId");

                    b.ToTable("SaleItems");
                });

            modelBuilder.Entity("sqliteMigration.Model.Product", b =>
                {
                    b.HasOne("sqliteMigration.Model.SaleItem", null)
                        .WithMany("Products")
                        .HasForeignKey("saleItemId");
                });
#pragma warning restore 612, 618
        }
    }
}
