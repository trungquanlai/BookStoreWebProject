﻿// <auto-generated />
using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ContosoUniversity.Migrations
{
    [DbContext(typeof(BookStoreContext))]
    partial class BookStoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ContosoUniversity.Models.Account", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("PhoneNoHome");

                    b.Property<string>("PhoneNoMobile");

                    b.Property<string>("PhoneNoWork");

                    b.Property<int>("RoleID");

                    b.HasKey("ID");

                    b.HasIndex("RoleID");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Image")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<int?>("OrderID");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int?>("ShoppingCartID");

                    b.Property<int>("SupplierID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ShoppingCartID");

                    b.HasIndex("SupplierID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Order", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AccountID");

                    b.Property<double>("GST");

                    b.Property<double>("GrandTotal");

                    b.Property<int>("Quantity");

                    b.Property<DateTime>("ShippingDate");

                    b.Property<double>("SubTotal");

                    b.HasKey("ID");

                    b.HasIndex("AccountID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Role", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Code");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ContosoUniversity.Models.ShoppingCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CookieGUID");

                    b.Property<DateTime>("CreateDate");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Supplier", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("PhoneNoHome");

                    b.Property<string>("PhoneNoMobile");

                    b.Property<string>("PhoneNoWork");

                    b.HasKey("ID");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Account", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Role", "Role")
                        .WithMany("Accounts")
                        .HasForeignKey("RoleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContosoUniversity.Models.Book", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ContosoUniversity.Models.Order")
                        .WithMany("Books")
                        .HasForeignKey("OrderID");

                    b.HasOne("ContosoUniversity.Models.ShoppingCart")
                        .WithMany("Books")
                        .HasForeignKey("ShoppingCartID");

                    b.HasOne("ContosoUniversity.Models.Supplier", "Supplier")
                        .WithMany("Books")
                        .HasForeignKey("SupplierID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ContosoUniversity.Models.Order", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountID");
                });
#pragma warning restore 612, 618
        }
    }
}
