﻿// <auto-generated />
using System;
using DepartmentalStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DepartmentalStore.Data.Migrations
{
    [DbContext(typeof(DepartmentStoreContext))]
    [Migration("20210520133019_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("DepartmentalStore.Domain.Address", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("AddressLine2")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("City")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<string>("Pincode")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("State")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Category", b =>
                {
                    b.Property<long>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(64)
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CategoryName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Inventory", b =>
                {
                    b.Property<long>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<bool>("Instock")
                        .HasMaxLength(128)
                        .HasColumnType("boolean");

                    b.Property<long>("ProductId")
                        .HasMaxLength(128)
                        .HasColumnType("bigint");

                    b.Property<int>("Quantity")
                        .HasMaxLength(32)
                        .HasColumnType("integer");

                    b.HasKey("InventoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Product", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(128)
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<decimal>("CostPrice")
                        .HasMaxLength(512)
                        .HasColumnType("numeric");

                    b.Property<string>("Manufacturer")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<decimal>("SellingPrice")
                        .HasMaxLength(512)
                        .HasColumnType("numeric");

                    b.Property<string>("ShortCode")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.ProductCategory", b =>
                {
                    b.Property<long>("ProductId")
                        .HasMaxLength(128)
                        .HasColumnType("bigint");

                    b.Property<long>("CategoryID")
                        .HasMaxLength(128)
                        .HasColumnType("bigint");

                    b.HasKey("ProductId", "CategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.PurchaseOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasMaxLength(512)
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ProductId")
                        .HasMaxLength(128)
                        .HasColumnType("integer");

                    b.Property<long?>("ProductId1")
                        .HasColumnType("bigint");

                    b.Property<int>("QuantityRequired")
                        .HasMaxLength(512)
                        .HasColumnType("integer");

                    b.Property<int>("SupplierId")
                        .HasMaxLength(128)
                        .HasColumnType("integer");

                    b.HasKey("OrderId");

                    b.HasIndex("ProductId1");

                    b.HasIndex("SupplierId");

                    b.ToTable("PurchaseOrder");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(512)
                        .HasColumnType("character varying(512)");

                    b.Property<string>("RoleName")
                        .HasMaxLength(64)
                        .HasColumnType("character varying(64)");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Supplier", b =>
                {
                    b.Property<int>("SupplierId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("City")
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)");

                    b.Property<string>("Email")
                        .HasMaxLength(32)
                        .HasColumnType("character varying(32)");

                    b.Property<char>("Gender")
                        .HasMaxLength(32)
                        .HasColumnType("character(1)");

                    b.Property<string>("SupplierName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("SupplierPhoneNumber")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.HasKey("SupplierId");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.SupplierProduct", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<long>("SupplierId")
                        .HasMaxLength(128)
                        .HasColumnType("bigint");

                    b.Property<int?>("SupplierId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("SupplierId1");

                    b.ToTable("SupplierProduct");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.staff", b =>
                {
                    b.Property<long>("staffId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(32)
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("AddressId")
                        .HasMaxLength(32)
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("FirstName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<string>("LastName")
                        .HasMaxLength(128)
                        .HasColumnType("character varying(128)");

                    b.Property<long>("RoleId")
                        .HasMaxLength(32)
                        .HasColumnType("bigint");

                    b.Property<int?>("RoleId1")
                        .HasColumnType("integer");

                    b.HasKey("staffId");

                    b.HasIndex("AddressId");

                    b.HasIndex("RoleId1");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Inventory", b =>
                {
                    b.HasOne("DepartmentalStore.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.ProductCategory", b =>
                {
                    b.HasOne("DepartmentalStore.Domain.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepartmentalStore.Domain.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.PurchaseOrder", b =>
                {
                    b.HasOne("DepartmentalStore.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId1");

                    b.HasOne("DepartmentalStore.Domain.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.SupplierProduct", b =>
                {
                    b.HasOne("DepartmentalStore.Domain.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");

                    b.HasOne("DepartmentalStore.Domain.Supplier", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId1");

                    b.Navigation("Product");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.staff", b =>
                {
                    b.HasOne("DepartmentalStore.Domain.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DepartmentalStore.Domain.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId1");

                    b.Navigation("Address");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Category", b =>
                {
                    b.Navigation("ProductCategories");
                });

            modelBuilder.Entity("DepartmentalStore.Domain.Product", b =>
                {
                    b.Navigation("ProductCategories");
                });
#pragma warning restore 612, 618
        }
    }
}