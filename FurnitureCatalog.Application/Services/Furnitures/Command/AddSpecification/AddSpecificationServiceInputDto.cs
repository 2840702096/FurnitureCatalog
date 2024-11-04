using System.ComponentModel.DataAnnotations;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification
{
    public class AddSpecificationServiceInputDto
    {
        [Display(Name = "مقدار")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Value { get; set; }
        public int STitleId { get; set; }
        public int FurnitureId { get; set; }
    }
}
