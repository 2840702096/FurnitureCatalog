using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;

namespace FurnitureCatalog.Application.Services.Categories.Command.AddDescriptionTitle
{
    public interface IAddDescriptionTitleService
    {
        void Execute(SpecificationTitlesDto input);
    }
}
