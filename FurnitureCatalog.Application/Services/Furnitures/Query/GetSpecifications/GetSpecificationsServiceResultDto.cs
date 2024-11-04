using FurnitureCatalog.Domain.Entities.Categories;
using System.ComponentModel.DataAnnotations;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecifications
{
    public class GetSpecificationsServiceResultDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int STitleId { get; set; }
        public int FurnitureId { get; set; }
        public SpecificationTitles SpecificationTitles { get; set; }
    }
}
