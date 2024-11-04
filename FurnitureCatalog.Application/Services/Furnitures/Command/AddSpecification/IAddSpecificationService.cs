using FurnitureCatalog.Common.DTOs;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification
{
    public interface IAddSpecificationService
    {
        void Execute(AddSpecificationServiceInputDto input);
    }
}
