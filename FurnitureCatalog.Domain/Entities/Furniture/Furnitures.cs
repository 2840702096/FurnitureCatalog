using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Domain.Entities.Furniture
{
    public class Furnitures : BaseEntity
    {
        public Furnitures()
        {
            
        }

        public string Name { get; set; }
        public string Image { get; set; }
        public bool IsActive { get; set; }
        public int CategoryId { get; set; }

        #region Relations

        public ICollection<Specifications> Specifications { get; set; }

        public ICollection<FurnitureDescription> FurnitureDescriptions { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Categories.Categories Categories { get; set; }

        #endregion
    }
}
