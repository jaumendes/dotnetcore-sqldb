﻿// <auto-generated />
using System;
using DotNetCoreSqlDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreSqlDb.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    [Migration("20200721211246_AddProductTable")]
    partial class AddProductTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("DotNetCoreSqlDb.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("CarboHidrate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Fat")
                        .HasColumnType("TEXT");

                    b.Property<int>("Kcals")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("LargePortionRatio")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MediumPortionRatio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Protein")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SaturatedFat")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("SmallPortionRatio")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Sugar")
                        .HasColumnType("TEXT");

                    b.Property<string>("Type")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DotNetCoreSqlDb.Models.Todo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Todo");
                });
#pragma warning restore 612, 618
        }
    }
}
