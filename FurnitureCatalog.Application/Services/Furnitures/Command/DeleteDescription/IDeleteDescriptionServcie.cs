using FurnitureCatalog.Application.Services.Furnitures.Command.DeleteSpecification;
using FurnitureCatalog.Common.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.DeleteDescription
{
    public interface IDeleteDescriptionServcie
    {
        ResultDto Execute(int id);
    }
}
