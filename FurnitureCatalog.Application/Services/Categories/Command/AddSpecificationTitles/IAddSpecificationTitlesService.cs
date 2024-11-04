using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddSpecificationTitles
{
    public interface IAddSpecificationTitlesService
    {
        void Execute(SpecificationTitlesDto input);
    }
}
