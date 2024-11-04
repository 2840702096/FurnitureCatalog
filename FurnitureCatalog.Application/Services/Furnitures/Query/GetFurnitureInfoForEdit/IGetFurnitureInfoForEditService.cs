using FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetFurnitureInfoForEdit
{
    public interface IGetFurnitureInfoForEditService
    {
        AddOrEditFurnitureServiceInputDto Execute(int? id);
    }
}
