using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Common;
using FurnitureCatalog.Domain.Entities.Furniture;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Persistence.Context
{
    public class DataBaseContext : DbContext, IDataBaseContext
    {
        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<SpecificationTitles> SpecificationTitles { get; set; }
        public DbSet<Furnitures> Furnitures { get; set; }
        public DbSet<Specifications> Specifications { get; set; }
        public DbSet<BaseEntity> BaseEntities { get; set; }
        public DbSet<DescriptionTitle> DescriptionTitles { get; set; }
        public DbSet<FurnitureDescription> FurnitureDescriptions { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cascadeFKs = modelBuilder.Model.GetEntityTypes()
                .SelectMany(t => t.GetForeignKeys())
                .Where(fk => !fk.IsOwnership && fk.DeleteBehavior == DeleteBehavior.Cascade);

            foreach (var fk in cascadeFKs)
                fk.DeleteBehavior = DeleteBehavior.Restrict;



            #region QueryFilters

            modelBuilder.Entity<BaseEntity>().HasQueryFilter(b => !b.IsDeleted);

            #endregion
        }
    }
}
