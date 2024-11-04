using System.ComponentModel.DataAnnotations;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddCategory
{
    public class AddCategoryServiceInputDto
    {
        public int? ParentId { get; set; }
        public int? CategoryIdForEdit { get; set; }

        [Display(Name = "نام گروه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(200, ErrorMessage = "{0} نمی تواند بیشتر از {1} کاراکتر باشد .")]
        public string Name { get; set; }
    }
}
