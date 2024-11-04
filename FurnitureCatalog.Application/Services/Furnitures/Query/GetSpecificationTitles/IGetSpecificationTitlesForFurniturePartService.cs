using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecificationTitles
{
    public interface IGetSpecificationTitlesForFurniturePartService
    {
        List<SelectListItem> Execute(int id);
    }
}
