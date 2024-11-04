using FurnitureCatalog.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategories
{
    public interface IGetCategoriesService
    {
        ResultDto<List<CategoryDto>> Execute(int pageId, int? parentId);
    }
}
