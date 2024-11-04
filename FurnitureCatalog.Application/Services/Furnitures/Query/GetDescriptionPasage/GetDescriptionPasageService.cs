using FurnitureCatalog.Application.Interfaces.Context;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptionPasage
{
    public class GetDescriptionPasageService : IGetDescriptionPasageService
    {
        private readonly IDataBaseContext _context;

        public GetDescriptionPasageService(IDataBaseContext context)
        {
            _context = context;
        }

        public string Execute(int id)
        {
            return _context.FurnitureDescriptions.Find(id).Value;
        }
    }
}
