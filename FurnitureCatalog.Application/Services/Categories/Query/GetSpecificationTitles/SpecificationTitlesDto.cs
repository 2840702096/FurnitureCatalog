using System.ComponentModel.DataAnnotations;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles
{
    public class SpecificationTitlesDto
    {
        public int Id { get; set; }
        [Display(Name = "عنوان")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }
}
