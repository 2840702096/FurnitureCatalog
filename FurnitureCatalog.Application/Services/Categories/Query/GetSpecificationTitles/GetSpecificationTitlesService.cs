using FurnitureCatalog.Application.Interfaces.Context;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles
{
    public class GetSpecificationTitlesService : IGetSpecificationTitlesService
    {
        private IDataBaseContext _context;

        public GetSpecificationTitlesService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<SpecificationTitlesDto> Execute(int catgegoryId)
        {
            return _context.SpecificationTitles.Where(s => s.CategoryId == catgegoryId).Select(s => new SpecificationTitlesDto
            {
                Id = s.Id,
                Name = s.Name,
                CategoryId = s.CategoryId
            }).ToList();
        }
    }
}
