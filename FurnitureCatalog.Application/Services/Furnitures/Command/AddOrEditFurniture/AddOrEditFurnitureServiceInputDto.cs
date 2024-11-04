using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture
{
    public class AddOrEditFurnitureServiceInputDto
    {
        public int? Id { get; set; }
        public int? EditId { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }
        public int CategoryId { get; set; }

        [Display(Name = "عکس")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public IFormFile Image { get; set; }
    }
}
