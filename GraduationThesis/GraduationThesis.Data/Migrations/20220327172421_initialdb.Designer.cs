﻿// <auto-generated />
using System;
using GraduationThesis.Data.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GraduationThesis.Data.Migrations
{
    [DbContext(typeof(GraduationThesisDbContext))]
    [Migration("20220327172421_initialdb")]
    partial class initialdb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("GraduationThesis.Data.Entities.Admin", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Admin");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Brand", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("brand_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("brand_slug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("delete_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Brand");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("cate_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("cate_slug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("delete_at")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<int?>("parent_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Contact", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("company_name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("hotline")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("social_fb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("social_instagram")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("social_twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("social_youtube")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Contact");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Coupon", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("code")
                        .IsRequired()
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("end_at")
                        .HasColumnType("Date");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<double?>("max_price")
                        .HasColumnType("float");

                    b.Property<double?>("min_order_value")
                        .HasColumnType("float");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("quantity")
                        .HasColumnType("int");

                    b.Property<DateTime>("start_at")
                        .HasColumnType("Date");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("value")
                        .HasColumnType("float");

                    b.HasKey("id");

                    b.ToTable("Coupon");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Customer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("delete_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .IsUnicode(false)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn(100000);

                    b.Property<string>("address_receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("cancel_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("cancel_reason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("confirm_at")
                        .HasColumnType("datetime2");

                    b.Property<int?>("coupon_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("cus_id")
                        .HasColumnType("int");

                    b.Property<decimal>("discount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("isPay")
                        .HasColumnType("bit");

                    b.Property<string>("name_receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("pay_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("payment_id")
                        .HasColumnType("int");

                    b.Property<string>("phone_receiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<decimal>("total")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("transport_fee")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("coupon_id");

                    b.HasIndex("cus_id");

                    b.HasIndex("payment_id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<decimal?>("promotion_price")
                        .IsRequired()
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("unit_price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("order_id", "product_id");

                    b.HasIndex("product_id");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.PaymentMethod", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("delete_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("PaymentMethod");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("best_seller")
                        .HasColumnType("bit");

                    b.Property<int>("brand_id")
                        .HasColumnType("int");

                    b.Property<string>("code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("delete_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("featured")
                        .HasColumnType("bit");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("instock")
                        .HasColumnType("int");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("meta_descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meta_keywords")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("meta_tittle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("more_images")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<decimal>("promotion_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("short_desc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slug")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("specifications")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("unit_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.Property<int>("view_count")
                        .HasColumnType("int");

                    b.Property<int>("warranty")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("brand_id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("cate_id")
                        .HasColumnType("int");

                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.HasKey("cate_id", "product_id");

                    b.HasIndex("product_id");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Rating", b =>
                {
                    b.Property<int>("product_id")
                        .HasColumnType("int");

                    b.Property<int>("cus_id")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("date_rating")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("product_id", "cus_id");

                    b.HasIndex("cus_id");

                    b.ToTable("Rating");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Transport", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn(100000);

                    b.Property<DateTime?>("cancel_at")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("cod_price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("done_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("from_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lading_code")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<int>("order_id")
                        .HasColumnType("int");

                    b.Property<int>("ship_status")
                        .HasColumnType("int");

                    b.Property<string>("to_address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("transporter_id")
                        .HasColumnType("int");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasAlternateKey("order_id");

                    b.HasIndex("transporter_id");

                    b.ToTable("Transport");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Transporter", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("create_at")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GetDate()");

                    b.Property<DateTime?>("delete_at")
                        .HasColumnType("datetime2");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<bool>("isDelete")
                        .HasColumnType("bit");

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("update_at")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("Transporter");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Order", b =>
                {
                    b.HasOne("GraduationThesis.Data.Entities.Coupon", "Coupon")
                        .WithMany("Orders")
                        .HasForeignKey("coupon_id");

                    b.HasOne("GraduationThesis.Data.Entities.Customer", "Customers")
                        .WithMany("Order")
                        .HasForeignKey("cus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationThesis.Data.Entities.PaymentMethod", "PaymentMethod")
                        .WithMany("Orders")
                        .HasForeignKey("payment_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coupon");

                    b.Navigation("Customers");

                    b.Navigation("PaymentMethod");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("GraduationThesis.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationThesis.Data.Entities.Product", "Product")
                        .WithMany("OrderDetails")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Product", b =>
                {
                    b.HasOne("GraduationThesis.Data.Entities.Brand", "Brand")
                        .WithMany("Products")
                        .HasForeignKey("brand_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Brand");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.ProductCategory", b =>
                {
                    b.HasOne("GraduationThesis.Data.Entities.Category", "Category")
                        .WithMany("ProductInCategory")
                        .HasForeignKey("cate_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationThesis.Data.Entities.Product", "Product")
                        .WithMany("ProductInCategory")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Rating", b =>
                {
                    b.HasOne("GraduationThesis.Data.Entities.Customer", "Customer")
                        .WithMany("Ratings")
                        .HasForeignKey("cus_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationThesis.Data.Entities.Product", "Product")
                        .WithMany("Ratings")
                        .HasForeignKey("product_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Transport", b =>
                {
                    b.HasOne("GraduationThesis.Data.Entities.Order", "Order")
                        .WithOne("Transport")
                        .HasForeignKey("GraduationThesis.Data.Entities.Transport", "order_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GraduationThesis.Data.Entities.Transporter", "Transporter")
                        .WithMany("Transports")
                        .HasForeignKey("transporter_id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Transporter");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Brand", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Category", b =>
                {
                    b.Navigation("ProductInCategory");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Coupon", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Customer", b =>
                {
                    b.Navigation("Order");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("Transport");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.PaymentMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Product", b =>
                {
                    b.Navigation("OrderDetails");

                    b.Navigation("ProductInCategory");

                    b.Navigation("Ratings");
                });

            modelBuilder.Entity("GraduationThesis.Data.Entities.Transporter", b =>
                {
                    b.Navigation("Transports");
                });
#pragma warning restore 612, 618
        }
    }
}
