using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetDescriptionTitles
{
    public interface IGetDescriptionTitlesService
    {
        List<SpecificationTitlesDto> Execute(int catgegoryId);
    }
}
