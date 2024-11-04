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
    public class Specifications : BaseEntity
    {
        public Specifications()
        {
            
        }

        public string Value { get; set; }
        public int STitleId { get; set; }
        public int FurnitureId { get; set; }

        #region Relations

        [ForeignKey("STitleId")]
        public virtual SpecificationTitles SpecificationTitles { get; set; }

        [ForeignKey("FurnitureId")]
        public virtual Furnitures Furnitures { get; set; }

        #endregion
    }
}
