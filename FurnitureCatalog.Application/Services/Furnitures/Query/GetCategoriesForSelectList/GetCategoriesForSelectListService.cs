using FurnitureCatalog.Application.Interfaces.Context;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetCategoriesForSelectList
{
    public class GetCategoriesForSelectListService : IGetCategoriesForSelectListService
    {
        private readonly IDataBaseContext _context;

        public GetCategoriesForSelectListService(IDataBaseContext context)
        {
            _context = context;
        }

        public List<SelectListItem> Execute()
        {
            return _context.Categories.Where(c => c.ParentId != null).Select(c => new SelectListItem
            {
                Text = c.Name,
                Value = c.Id.ToString()
            }).ToList();
        }
    }
}
