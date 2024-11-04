using FurnitureCatalog.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetFurnitures
{
    public class GetFurnituresService : IGetFurnituresService
    {
        private readonly IDataBaseContext _context;

        public GetFurnituresService(IDataBaseContext context)
        {
            _context = context;
        }

        public GetFurnituresServiceResultDto Execute(int pageId, string filter)
        {
            int Take = 10;
            int Skip = (pageId - 1) * Take;

            var Furniture = _context.Furnitures.Include(f=>f.Categories).Include(f=>f.Specifications).AsQueryable();

            if(!string.IsNullOrEmpty(filter))
            {
                Furniture = Furniture.OrderByDescending(f=>f.InsertTime).Where(f=>f.Name.Contains(filter));
            }

            var FurnitureForDto = Furniture.Skip(Skip).Take(Take).Select(f => new GetFurnituresServiceFurnitureDto
            {
                Id = f.Id,
                Name = f.Name,
                Image = f.Image,
                IsActive = f.IsActive,
                InsertTime = f.InsertTime.Value,
                Category = new GetFurnituresServiceCategoryDto
                {
                    Id = f.Categories.Id,
                    Name = f.Categories.Name,
                }
            }).ToList();

            return new GetFurnituresServiceResultDto
            {
                Furnitures = FurnitureForDto
            };
        }
    }
}