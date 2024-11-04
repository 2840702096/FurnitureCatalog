﻿// <auto-generated />
using System;
using FurnitureCatalog.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FurnitureCatalog.Persistence.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int?>("ParentId")
                        .HasColumnType("int");

                    b.Property<int>("STitileId")
                        .HasColumnType("int");

                    b.HasIndex("ParentId");

                    b.HasDiscriminator().HasValue("Categories");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.DescriptionTitle", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("DescriptionTitle_CategoryId");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DescriptionTitle_Name");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("DescriptionTitle");
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

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.FurnitureDescription", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<int>("FurnitureId")
                        .HasColumnType("int");

                    b.Property<int>("TitleId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("FurnitureId");

                    b.HasIndex("TitleId");

                    b.HasDiscriminator().HasValue("FurnitureDescription");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("Furnitures_CategoryId");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Furnitures_Name");

                    b.HasIndex("CategoryId");

                    b.HasDiscriminator().HasValue("Furnitures");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Specifications", b =>
                {
                    b.HasBaseType("FurnitureCatalog.Domain.Entities.Common.BaseEntity");

                    b.Property<int>("FurnitureId")
                        .HasColumnType("int")
                        .HasColumnName("Specifications_FurnitureId");

                    b.Property<int>("STitleId")
                        .HasColumnType("int");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Specifications_Value");

                    b.HasIndex("FurnitureId");

                    b.HasIndex("STitleId");

                    b.HasDiscriminator().HasValue("Specifications");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.Categories", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.Categories", "ParentCategory")
                        .WithMany("SubCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.DescriptionTitle", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.Categories", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
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

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.FurnitureDescription", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", "Furniture")
                        .WithMany("FurnitureDescriptions")
                        .HasForeignKey("FurnitureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.DescriptionTitle", "Title")
                        .WithMany("FurnitureDescriptions")
                        .HasForeignKey("TitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Furniture");

                    b.Navigation("Title");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.Categories", "Categories")
                        .WithMany("Furnitures")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Specifications", b =>
                {
                    b.HasOne("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", "Furnitures")
                        .WithMany("Specifications")
                        .HasForeignKey("FurnitureId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("FurnitureCatalog.Domain.Entities.Categories.SpecificationTitles", "SpecificationTitles")
                        .WithMany("Specifications")
                        .HasForeignKey("STitleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Furnitures");

                    b.Navigation("SpecificationTitles");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.Categories", b =>
                {
                    b.Navigation("Furnitures");

                    b.Navigation("SpecificationTitles");

                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.DescriptionTitle", b =>
                {
                    b.Navigation("FurnitureDescriptions");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Categories.SpecificationTitles", b =>
                {
                    b.Navigation("Specifications");
                });

            modelBuilder.Entity("FurnitureCatalog.Domain.Entities.Furniture.Furnitures", b =>
                {
                    b.Navigation("FurnitureDescriptions");

                    b.Navigation("Specifications");
                });
#pragma warning restore 612, 618
        }
    }
}
