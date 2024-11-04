﻿// <auto-generated />
using System;
using FurnitureCatalog.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FurnitureCatalog.Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20240124212254_mig_InitialDatabase")]
    partial class mig_InitialDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Common.BaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("InsertTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifyTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("BaseEntities");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BaseEntity");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.Categories", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Categories_Name");

                    b.Property<int>("STitileId")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Categories");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.SpecificationTitles", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("SpecificationTitles");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Furnitures_Name");

                    b.Property<int>("SpecificationId")
                        .HasColumnType("int");

                    b.HasIndex("SpecificationId");

                    b.HasDiscriminator().HasValue("Furnitures");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Specifications", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<int>("STitleId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("STitleId");

                    b.HasDiscriminator().HasValue("Specifications");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.SpecificationTitles", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.Categories", "Categories")
                        .WithMany("SpecificationTitles")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Furniture.Specifications", "Specifications")
                        .WithMany("Furnitures")
                        .HasForeignKey("SpecificationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Specifications", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.SpecificationTitles", "SpecificationTitles")
                        .WithMany("Specifications")
                        .HasForeignKey("STitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("SpecificationTitles");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.Categories", b =>
                {
                    b.Navigation("SpecificationTitles");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.SpecificationTitles", b =>
                {
                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Specifications", b =>
                {
                    b.Navigation("Furnitures");
                });
#pragma warning restore 612, 618
        }
    }
}
