using FurnitureCatalog.Domain.Entities.Categories;
using System.ComponentModel.DataAnnotations;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptions
{
    public class GetDescriptionsServiceResultDto
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int STitleId { get; set; }
        public int FurnitureId { get; set; }
        public DescriptionTitle DescriptionTitle { get; set; }
    }
}
