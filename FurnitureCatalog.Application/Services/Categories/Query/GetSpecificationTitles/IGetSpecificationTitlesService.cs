using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles
{
    public interface IGetSpecificationTitlesService
    {
        List<SpecificationTitlesDto> Execute(int catgegoryId);
    }
}
