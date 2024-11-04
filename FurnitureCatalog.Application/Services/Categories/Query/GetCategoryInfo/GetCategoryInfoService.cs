using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Categories.Command.AddCategory;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategoryInfo
{
    public class GetCategoryInfoService : IGetCategoryInfoService
    {
        private readonly IDataBaseContext _context;

        public GetCategoryInfoService(IDataBaseContext context)
        {
            _context = context;
        }

        public AddCategoryServiceInputDto Execute(int? id)
        {
            return _context.Categories.Where(c => c.Id == id).Select(c => new AddCategoryServiceInputDto
            {
                Name = c.Name
            }).SingleOrDefault();
        }
    }


}
