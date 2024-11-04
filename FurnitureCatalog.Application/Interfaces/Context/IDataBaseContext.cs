using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Common;
using FurnitureCatalog.Domain.Entities.Furniture;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Interfaces.Context
{
    public interface IDataBaseContext
    {
        DbSet<Categories> Categories { get; set; }
        DbSet<SpecificationTitles> SpecificationTitles { get; set; }
        DbSet<Furnitures> Furnitures { get; set; }
        DbSet<Specifications> Specifications { get; set; }
        DbSet<BaseEntity> BaseEntities { get; set; }
        DbSet<DescriptionTitle> DescriptionTitles { get; set; }
        DbSet<FurnitureDescription> FurnitureDescriptions { get; set; }

        int SaveChanges(bool acceptAllChangesOnSuccess);
        int SaveChanges();
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = new CancellationToken());
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken());
    }
}
