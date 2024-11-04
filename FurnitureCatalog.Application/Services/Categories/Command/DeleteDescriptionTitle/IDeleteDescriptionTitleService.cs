using FurnitureCatalog.Application.Services.Categories.Command.DeleteSpecificationTitle;
using FurnitureCatalog.Common.DTOs;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Command.DeleteDescriptionTitle
{
    public interface IDeleteDescriptionTitleService
    {
        ResultDto Execute(int id);
    }
}
