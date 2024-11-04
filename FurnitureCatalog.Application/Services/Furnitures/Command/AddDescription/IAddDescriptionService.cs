using FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification;

namespace FurnitureCatalog.Application.Services.Furnitures.Command.AddDescription
{
    public interface IAddDescriptionService
    {
        void Execute(AddSpecificationServiceInputDto input);
    }
}
