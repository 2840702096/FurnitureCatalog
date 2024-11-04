using FurnitureCatalog.Application.Interfaces.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptions
{
    public partial class GetDescriptionsService : IGetDescriptionsService
    {
        private readonly IDataBaseContext _context;

        public GetDescriptionsService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<GetDescriptionsServiceResultDto> Execute(int id)
        {
            return _context.FurnitureDescriptions.Include(d=>d.Title).Where(d => d.FurnitureId == id).Select(d => new GetDescriptionsServiceResultDto
            {
                Id = d.Id,
                Value = d.Value,
                STitleId = d.TitleId,
                FurnitureId = d.FurnitureId,
                DescriptionTitle = d.Title
            }).ToList();
        }
    }
}
