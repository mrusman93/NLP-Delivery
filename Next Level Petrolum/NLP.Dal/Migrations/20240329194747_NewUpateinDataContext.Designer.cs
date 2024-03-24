﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NLP.Dal;

#nullable disable

namespace NLP.Dal.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240329194747_NewUpateinDataContext")]
    partial class NewUpateinDataContext
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("NLP.Domain.Models.Addresses", b =>
                {
                    b.Property<int>("AddressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressID"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreID")
                        .HasColumnType("int");

                    b.Property<string>("StreetAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AddressID");

                    b.HasIndex("StoreID");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("NLP.Domain.Models.Brands", b =>
                {
                    b.Property<int>("BrandID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandID"));

                    b.Property<byte[]>("BrandImage")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoreID")
                        .HasColumnType("int");

                    b.HasKey("BrandID");

                    b.HasIndex("StoreID");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("NLP.Domain.Models.ProductReceivers", b =>
                {
                    b.Property<int>("ReceiverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReceiverID"));

                    b.Property<int>("AddressID")
                        .HasColumnType("int");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReceiverID");

                    b.HasIndex("AddressID");

                    b.ToTable("ProductReceiver");
                });

            modelBuilder.Entity("NLP.Domain.Models.ProductSizes", b =>
                {
                    b.Property<int>("SizeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SizeID"));

                    b.Property<int>("ProductID")
                        .HasColumnType("int");

                    b.Property<string>("SizeDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SizeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SizeID");

                    b.HasIndex("ProductID");

                    b.ToTable("ProductSize");
                });

            modelBuilder.Entity("NLP.Domain.Models.Products", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductID"));

                    b.Property<int>("BrandID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductID");

                    b.HasIndex("BrandID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("NLP.Domain.Models.Stores", b =>
                {
                    b.Property<int>("StoreID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreID"));

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StoreID");

                    b.ToTable("Store");
                });

            modelBuilder.Entity("NLP.Domain.Models.UserRoles", b =>
                {
                    b.Property<Guid>("RoleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.Property<int>("UsersUserID")
                        .HasColumnType("int");

                    b.HasKey("RoleID");

                    b.HasIndex("UsersUserID");

                    b.ToTable("UsersRole");
                });

            modelBuilder.Entity("NLP.Domain.Models.Users", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"));

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("NLP.Domain.Models.Addresses", b =>
                {
                    b.HasOne("NLP.Domain.Models.Stores", "Store")
                        .WithMany("Address")
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("NLP.Domain.Models.Brands", b =>
                {
                    b.HasOne("NLP.Domain.Models.Stores", "Store")
                        .WithMany("Brand")
                        .HasForeignKey("StoreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Store");
                });

            modelBuilder.Entity("NLP.Domain.Models.ProductReceivers", b =>
                {
                    b.HasOne("NLP.Domain.Models.Addresses", "ReceiverAddress")
                        .WithMany()
                        .HasForeignKey("AddressID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ReceiverAddress");
                });

            modelBuilder.Entity("NLP.Domain.Models.ProductSizes", b =>
                {
                    b.HasOne("NLP.Domain.Models.Products", "Product")
                        .WithMany("Size")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("NLP.Domain.Models.Products", b =>
                {
                    b.HasOne("NLP.Domain.Models.Brands", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("NLP.Domain.Models.UserRoles", b =>
                {
                    b.HasOne("NLP.Domain.Models.Users", "Users")
                        .WithMany("Role")
                        .HasForeignKey("UsersUserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("NLP.Domain.Models.Products", b =>
                {
                    b.Navigation("Size");
                });

            modelBuilder.Entity("NLP.Domain.Models.Stores", b =>
                {
                    b.Navigation("Address");

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("NLP.Domain.Models.Users", b =>
                {
                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
