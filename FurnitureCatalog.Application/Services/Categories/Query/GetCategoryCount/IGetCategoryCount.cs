using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Query.GetCategoryCount
{
    public interface IGetCategoryCount
    {
        int Execute(int? parentId);
    }
}
