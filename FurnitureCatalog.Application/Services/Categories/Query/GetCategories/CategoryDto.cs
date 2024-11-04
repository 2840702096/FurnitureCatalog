using FurnitureCatalog.Domain.Entities.Categories;
using System.Collections.Generic;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategories
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasChild { get; set; }
        public ParentCategoryDto ParentCategory { get; set; }
    }
}
