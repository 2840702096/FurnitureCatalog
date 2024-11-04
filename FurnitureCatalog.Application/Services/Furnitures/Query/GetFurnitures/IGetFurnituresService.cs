using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Furnitures.Query.GetFurnitures
{
    public interface IGetFurnituresService
    {
        GetFurnituresServiceResultDto Execute(int pageId, string filter);
    }
}