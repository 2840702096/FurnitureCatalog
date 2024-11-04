using FurnitureCatalog.Application.Services.Categories.Command.AddCategory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategoryInfo
{
    public interface IGetCategoryInfoService
    {
        AddCategoryServiceInputDto Execute(int? id);
    }


}
