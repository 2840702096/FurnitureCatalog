using FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecifications;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using static FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptions.GetDescriptionsService;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptions
{
    public interface IGetDescriptionsService
    {
        List<GetDescriptionsServiceResultDto> Execute(int id);
    }
}
