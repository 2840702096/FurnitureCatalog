using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Interfaces.FacadPatern;
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
using Microsoft.AspNetCore.Hosting;
using FurnitureCatalog.Application.Services.Furnitures.Query.GetDescriptionPasage;
using FurnitureCatalog.Application.Services.Furnitures.Command.DeleteDescription;

namespace FurnitureCatalog.Application.Services.Furnitures.FacadPatern
{
    public class FurnitureFacadPatern : IFurnitureFacadPatern
    {
        private readonly IDataBaseContext _context;
        private readonly IWebHostEnvironment _en;

        public FurnitureFacadPatern(IDataBaseContext context, IWebHostEnvironment en)
        {
            _context = context;
            _en = en;
        }


        private GetFurnituresService _getFurnituresService;
        public GetFurnituresService GetFurnituresService
        {
            get
            {
                return _getFurnituresService = _getFurnituresService == null ? new GetFurnituresService(_context) : _getFurnituresService;
            }
        }

        private GetCountOfFurnituresService _getCountOfFurnituresService;
        public GetCountOfFurnituresService GetCountOfFurnituresService
        {
            get
            {
                return _getCountOfFurnituresService = _getCountOfFurnituresService == null ? new GetCountOfFurnituresService(_context) : _getCountOfFurnituresService;
            }
        }

        private AddOrEditFurnitureService _addOrEditFurnitureService;
        public AddOrEditFurnitureService AddOrEditFurnitureService
        {
            get
            {
                return _addOrEditFurnitureService = _addOrEditFurnitureService == null ? new AddOrEditFurnitureService(_context, _en) : _addOrEditFurnitureService;
            }
        }

        private GetCategoriesForSelectListService _getCategoriesForSelectListService;
        public GetCategoriesForSelectListService GetCategoriesForSelectListService
        {
            get
            {
                return _getCategoriesForSelectListService = _getCategoriesForSelectListService == null ? new GetCategoriesForSelectListService(_context) : _getCategoriesForSelectListService;
            }
        }

        private GetFurnitureInfoForEditService _getFurnitureInfoForEditService;
        public GetFurnitureInfoForEditService GetFurnitureInfoForEditService
        {
            get
            {
                return _getFurnitureInfoForEditService = _getFurnitureInfoForEditService == null ? new GetFurnitureInfoForEditService(_context) : _getFurnitureInfoForEditService;
            }
        }

        private FurnitureActivationService _furnitureActivationService;
        public FurnitureActivationService FurnitureActivationService
        {
            get
            {
                return _furnitureActivationService = _furnitureActivationService == null ? new FurnitureActivationService(_context) : _furnitureActivationService;
            }
        }

        private FurnitureDeletingService _furnitureDeletingService;
        public FurnitureDeletingService FurnitureDeletingService
        {
            get
            {
                return _furnitureDeletingService = _furnitureDeletingService == null ? new FurnitureDeletingService(_context) : _furnitureDeletingService;
            }
        }

        private GetSpecificationsService _getSpecificationsService;
        public GetSpecificationsService GetSpecificationsService
        {
            get
            {
                return _getSpecificationsService = _getSpecificationsService == null ? new GetSpecificationsService(_context) : _getSpecificationsService;
            }
        }

        private GetSpecificationTitlesForFurniturePartService _getSpecificationTitlesForFurniturePartService;
        public GetSpecificationTitlesForFurniturePartService GetSpecificationTitlesForFurniturePartService
        {
            get
            {
                return _getSpecificationTitlesForFurniturePartService = _getSpecificationTitlesForFurniturePartService == null ? new GetSpecificationTitlesForFurniturePartService(_context) : _getSpecificationTitlesForFurniturePartService;
            }
        }

        private AddSpecificationService _addSpecificationService;
        public AddSpecificationService AddSpecificationService
        {
            get
            {
                return _addSpecificationService = _addSpecificationService == null ? new AddSpecificationService(_context) : _addSpecificationService;
            }
        }

        private DeleteSpecificationService _deleteSpecificationService;
        public DeleteSpecificationService DeleteSpecificationService
        {
            get
            {
                return _deleteSpecificationService = _deleteSpecificationService == null ? new DeleteSpecificationService(_context) : _deleteSpecificationService;
            }
        }

        private GetDescriptionTitlesService _getDescriptionTitlesService;
        public GetDescriptionTitlesService GetDescriptionTitlesService
        {
            get
            {
                return _getDescriptionTitlesService = _getDescriptionTitlesService == null ? new GetDescriptionTitlesService(_context) : _getDescriptionTitlesService;
            }
        }

        private GetDescriptionsService _getDescriptionsService;
        public GetDescriptionsService GetDescriptionsService
        {
            get
            {
                return _getDescriptionsService = _getDescriptionsService == null ? new GetDescriptionsService(_context) : _getDescriptionsService;
            }
        }

        private AddDescriptionService _addDescriptionService;
        public AddDescriptionService AddDescriptionService
        {
            get
            {
                return _addDescriptionService = _addDescriptionService == null ? new AddDescriptionService(_context) : _addDescriptionService;
            }
        }

        private GetDescriptionPasageService _getDescriptionPasageService;
        public GetDescriptionPasageService GetDescriptionPasageService
        {
            get
            {
                return _getDescriptionPasageService = _getDescriptionPasageService == null ? new GetDescriptionPasageService(_context) : _getDescriptionPasageService;
            }
        }

        private DeleteDescriptionServcie _deleteDescriptionServcie;
        public DeleteDescriptionServcie DeleteDescriptionServcie
        {
            get
            {
                return _deleteDescriptionServcie = _deleteDescriptionServcie == null ? new DeleteDescriptionServcie(_context) : _deleteDescriptionServcie;
            }
        }
    }
}
