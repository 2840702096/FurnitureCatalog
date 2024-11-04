using FurnitureCatalog.Domain.Entities.Common;
using FurnitureCatalog.Domain.Entities.Furniture;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Domain.Entities.Categories
{
    public class SpecificationTitles : BaseEntity
    {
        public SpecificationTitles()
        {
            
        }

        public string Name { get; set; }
        public int CategoryId { get; set; }

        #region Relations

        [ForeignKey("CategoryId")]
        public virtual Categories Categories { get; set; }

        public ICollection<Specifications> Specifications { get; set; }

        #endregion
    }
}
