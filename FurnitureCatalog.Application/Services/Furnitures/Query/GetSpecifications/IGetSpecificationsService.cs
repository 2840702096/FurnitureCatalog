using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using System.Collections.Generic;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecifications
{
    public interface IGetSpecificationsService
    {
        List<GetSpecificationsServiceResultDto> Execute(int id);
    }
}
