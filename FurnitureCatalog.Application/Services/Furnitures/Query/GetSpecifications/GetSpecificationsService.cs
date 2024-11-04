using FurnitureCatalog.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecifications
{
    public class GetSpecificationsService : IGetSpecificationsService
    {
        private readonly IDataBaseContext _context;

        public GetSpecificationsService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetSpecificationsServiceResultDto> Execute(int id)
        {
            return _context.Specifications.Include(s => s.SpecificationTitles).Where(s => s.FurnitureId == id).Select(s => new GetSpecificationsServiceResultDto
            {
                Id = s.Id,
                Value = s.Value,
                STitleId = s.STitleId,
                FurnitureId = s.FurnitureId,
                SpecificationTitles = s.SpecificationTitles
            }).ToList();
        }
    }
}
