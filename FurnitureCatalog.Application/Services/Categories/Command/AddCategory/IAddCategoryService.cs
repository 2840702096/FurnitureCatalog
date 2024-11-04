using FurnitureCatalog.Common.DTOs;
using FurnitureCatalog.Domain.Entities.Categories;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddCategory
{
    public interface IAddCategoryService
    {
        ResultDto<int> Execute(AddCategoryServiceInputDto input);
    }
}
