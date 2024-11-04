using FurnitureCatalog.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Command.DeleteSpecificationTitle
{
    public interface IDeleteSpecificationTitleService
    {
        ResultDto Execute(int id);
    }
}
