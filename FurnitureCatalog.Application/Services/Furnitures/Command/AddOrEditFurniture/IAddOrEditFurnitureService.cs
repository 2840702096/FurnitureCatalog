using FurnitureCatalog.Common.DTOs;
using FurnitureCatalog.Domain.Entities.Categories;
using FurnitureCatalog.Domain.Entities.Furniture;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture
{
    public interface IAddOrEditFurnitureService
    {
        ResultDto Execute(AddOrEditFurnitureServiceInputDto input);
    }
}
