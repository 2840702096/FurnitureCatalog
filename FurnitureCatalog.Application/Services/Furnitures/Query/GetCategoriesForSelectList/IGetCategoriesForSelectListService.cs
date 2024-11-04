using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetCategoriesForSelectList
{
    public interface IGetCategoriesForSelectListService
    {
        List<SelectListItem> Execute();
    }
}
