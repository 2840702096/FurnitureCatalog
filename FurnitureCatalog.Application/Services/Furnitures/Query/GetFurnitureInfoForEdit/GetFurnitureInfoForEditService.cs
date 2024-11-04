using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetFurnitureInfoForEdit
{
    public class GetFurnitureInfoForEditService : IGetFurnitureInfoForEditService
    {
        private readonly IDataBaseContext _context;

        public GetFurnitureInfoForEditService(IDataBaseContext context)
        {
            _context = context;
        }
        public AddOrEditFurnitureServiceInputDto Execute(int? id)
        {
            return _context.Furnitures.Where(f => f.Id == id).Select(f => new AddOrEditFurnitureServiceInputDto
            {
                Id = f.Id,
                Name = f.Name,
                CategoryId = f.CategoryId,
            }).SingleOrDefault();
        }
    }
}
