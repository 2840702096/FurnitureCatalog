using FurnitureCatalog.Application.Interfaces.Context;
using System;
using System.Linq;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategoryCount
{
    public class GetCategoryCount : IGetCategoryCount
    {
        private readonly IDataBaseContext _context;

        public GetCategoryCount(IDataBaseContext context)
        {
            _context = context;
        }

        public int Execute(int? parentId)
        {
            try
            {
                return _context.Categories.Where(c => c.ParentId == parentId).Count();
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
