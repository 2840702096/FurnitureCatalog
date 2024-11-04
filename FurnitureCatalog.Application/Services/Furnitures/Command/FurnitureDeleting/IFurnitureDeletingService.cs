using FurnitureCatalog.Common.DTOs;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.FurnitureDeleting
{
    public interface IFurnitureDeletingService
    {
        ResultDto Execute(int id);
    }
}
