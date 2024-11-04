using FurnitureCatalog.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Command.DeleteCategory
{
    public interface IDeleteCategoryService
    {
        ResultDto<int> Execute(int id);
    }
}
