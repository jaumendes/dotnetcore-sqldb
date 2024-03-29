﻿// <auto-generated />
using System;
using DotNetCoreSqlDb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DotNetCoreSqlDb.Migrations
{
    [DbContext(typeof(MyDatabaseContext))]
    partial class MyDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("DotNetCoreSqlDb.Models.Food", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");


                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Calories")
                 .HasColumnType("TEXT");

                 b.Property<double>("Proteins")
                    .HasColumnType("FLOAT");

                    b.Property<double>("Fats")
                    .HasColumnType("FLOAT");

                    b.Property<double>("SatFats")
                    .HasColumnType("FLOAT");

                 b.Property<double>("Carbs")
                    .HasColumnType("FLOAT");       

                    b.Property<double>("Sugars")
                    .HasColumnType("FLOAT");
                    b.Property<double>("Fibers")
                    .HasColumnType("FLOAT");
                    

                    b.Property<string>("Vitamins")
                        .HasColumnType("TEXT");

                    b.Property<string>("Minerals")
                        .HasColumnType("TEXT");

                    b.Property<string>("Source")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                          .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Food");
                });
#pragma warning restore 612, 618
        }
    }
}
