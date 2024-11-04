using FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptionTitles;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddDescription;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification;
using FurnitureCatalog.Application.Services.Furnitures.Command.DeleteSpecification;
using FurnitureCatalog.Application.Services.Furnitures.Command.FurnitureActivation;
using FurnitureCatalog.Application.Services.Furnitures.Command.FurnitureDeleting;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetCategoriesForSelectList;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetCountOfFurnitures;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptions;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetFurnitureInfoForEdit;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetFurnitures;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecifications;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetSpecificationTitles;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptionPasage;
using FurnitureCatalog.Application.Services.Furnitures.Command.DeleteDescription;

namespace FurnitureCatalog.Application.Interfaces.FacadPatern
{
    public interface IFurnitureFacadPatern
    {
        GetFurnituresService GetFurnituresService { get; }
        GetCountOfFurnituresService GetCountOfFurnituresService { get; }
        AddOrEditFurnitureService AddOrEditFurnitureService { get; }
        GetCategoriesForSelectListService GetCategoriesForSelectListService { get; }
        GetFurnitureInfoForEditService GetFurnitureInfoForEditService { get; }
        FurnitureActivationService FurnitureActivationService { get; }
        FurnitureDeletingService FurnitureDeletingService { get; }
        GetSpecificationsService GetSpecificationsService { get; }
        GetSpecificationTitlesForFurniturePartService GetSpecificationTitlesForFurniturePartService { get; }
        AddSpecificationService AddSpecificationService { get; }
        DeleteSpecificationService DeleteSpecificationService { get; }
        GetDescriptionTitlesService GetDescriptionTitlesService { get; }
        GetDescriptionsService GetDescriptionsService { get; }
        AddDescriptionService AddDescriptionService { get; }
        GetDescriptionPasageService GetDescriptionPasageService { get; }
        DeleteDescriptionServcie DeleteDescriptionServcie { get; }
    }
}
