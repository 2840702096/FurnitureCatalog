using FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecificationTitles;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptionTitles
{
    public interface IGetDescriptionTitlesService
    {
        List<SelectListItem> Execute(int id);
    }
}
