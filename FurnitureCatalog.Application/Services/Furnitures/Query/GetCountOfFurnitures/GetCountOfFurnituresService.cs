using FurnitureCatalog.Application.Interfaces.Context;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetCountOfFurnitures
{
    public class GetCountOfFurnituresService : IGetCountOfFurnituresService
    {
        private readonly IDataBaseContext _context;

        public GetCountOfFurnituresService(IDataBaseContext context)
        {
            _context = context;
        }
        public int Execute()
        {
            return _context.Furnitures.Count();
        }
    }
}
