using FurnitureCatalog.Domain.Entities.Common;
using FurnitureCatalog.Domain.Entities.Furniture;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Domain.Entities.Categories
{
    public class Categories : BaseEntity
    {
        public Categories()
        {
            
        }

        public string Name { get; set; }
        public int? ParentId { get; set; }
        public int STitileId { get; set; }

        #region Relations

        [ForeignKey("ParentId")]
        public virtual Categories ParentCategory { get; set; }

        public ICollection<Categories> SubCategories { get; set; }

        public ICollection<SpecificationTitles> SpecificationTitles { get; set; }

        public ICollection<Furnitures> Furnitures { get; set; }

        #endregion
    }
}
