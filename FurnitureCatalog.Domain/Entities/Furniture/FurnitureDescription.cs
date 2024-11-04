using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Domain.Entities.Furniture
{
    public class FurnitureDescription : BaseEntity
    {
        public FurnitureDescription()
        {
            
        }

        public string Value { get; set; }
        public int TitleId { get; set; }
        public int FurnitureId { get; set; }

        #region Relations

        [ForeignKey("TitleId")]
        public virtual DescriptionTitle Title { get; set; }

        [ForeignKey("FurnitureId")]
        public virtual Furnitures Furniture { get; set; }

        #endregion
    }
}
