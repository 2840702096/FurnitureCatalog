using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetDescriptionTitles
{
    public class GetDescriptionTitlesService : IGetDescriptionTitlesService
    {
        private IDataBaseContext _context;

        public GetDescriptionTitlesService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<SpecificationTitlesDto> Execute(int catgegoryId)
        {
            return _context.DescriptionTitles.Where(s => s.CategoryId == catgegoryId).Select(s => new SpecificationTitlesDto
            {
                Id = s.Id,
                Name = s.Name,
                CategoryId = s.CategoryId
            }).ToList();
        }
    }
}
