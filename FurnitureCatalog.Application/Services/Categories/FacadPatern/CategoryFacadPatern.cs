using FurnitureCatalog.Application.Interfaces.Context;
using FurnitureCatalog.Application.Interfaces.FacadPatern;
using FurnitureCatalog.Application.Services.Categories.Command.AddCategory;
using FurnitureCatalog.Application.Services.Categories.Command.AddDescriptionTitle;
using FurnitureCatalog.Application.Services.Categories.Command.AddSpecificationTitles;
using FurnitureCatalog.Application.Services.Categories.Command.DeleteCategory;
using FurnitureCatalog.Application.Services.Categories.Command.DeleteDescriptionTitle;
using FurnitureCatalog.Application.Services.Categories.Command.DeleteSpecificationTitle;
using FurnitureCatalog.Application.Services.Categories.Query.GetCategories;
using FurnitureCatalog.Application.Services.Categories.Query.GetCategoryCount;
using FurnitureCatalog.Application.Services.Categories.Query.GetCategoryInfo;
using FurnitureCatalog.Application.Services.Categories.Query.GetDescriptionTitles;
using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureCatalog.Application.Services.Categories.FacadPatern
{
    public class CategoryFacadPatern : ICategoryFacadPatern
    {
        private readonly IDataBaseContext _context;

        public CategoryFacadPatern(IDataBaseContext context)
        {
            _context = context;
        }

        private GetCategoriesService _getCategoriesService;
        public GetCategoriesService GetCategoriesService
        {
            get
            {
                return _getCategoriesService = _getCategoriesService == null ? new GetCategoriesService(_context) : _getCategoriesService;
            }
        }

        private GetCategoryCount _getCategoryCount;
        public GetCategoryCount GetCategoryCount
        {
            get
            {
                return _getCategoryCount = _getCategoryCount == null ? new GetCategoryCount(_context) : _getCategoryCount;
            }
        }


        private AddCategoryService _addCategoryService;
        public AddCategoryService AddCategoryService
        {
            get
            {
                return _addCategoryService = _addCategoryService == null ? new AddCategoryService(_context) : _addCategoryService;
            }
        }

        private GetCategoryInfoService _getCategoryInfoService;
        public GetCategoryInfoService GetCategoryInfoService
        {
            get
            {
                return _getCategoryInfoService = _getCategoryInfoService == null ? new GetCategoryInfoService(_context) : _getCategoryInfoService;
            }
        }

        private DeleteCategoryService _deleteCategoryService;
        public DeleteCategoryService DeleteCategoryService
        {
            get
            {
                return _deleteCategoryService = _deleteCategoryService == null ? new DeleteCategoryService(_context) : _deleteCategoryService;
            }
        }

        private GetSpecificationTitlesService _getSpecificationTitlesService;
        public GetSpecificationTitlesService GetSpecificationTitlesService
        {
            get
            {
                return _getSpecificationTitlesService = _getSpecificationTitlesService == null ? new GetSpecificationTitlesService(_context) : _getSpecificationTitlesService;
            }
        }

        private AddSpecificationTitlesService _addSpecificationTitlesService;
        public AddSpecificationTitlesService AddSpecificationTitlesService
        {
            get
            {
                return _addSpecificationTitlesService = _addSpecificationTitlesService == null ? new AddSpecificationTitlesService(_context) : _addSpecificationTitlesService;
            }
        }

        private DeleteSpecificationTitleService _deleteSpecificationTitleService;
        public DeleteSpecificationTitleService DeleteSpecificationTitleService
        {
            get
            {
                return _deleteSpecificationTitleService = _deleteSpecificationTitleService == null ? new DeleteSpecificationTitleService(_context) : _deleteSpecificationTitleService;
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

        private AddDescriptionTitleService _addDescriptionTitleService;
        public AddDescriptionTitleService AddDescriptionTitleService
        {
            get
            {
                return _addDescriptionTitleService = _addDescriptionTitleService == null ? new AddDescriptionTitleService(_context) : _addDescriptionTitleService;
            }
        }

        private DeleteDescriptionTitleService _deleteDescriptionTitleService;
        public DeleteDescriptionTitleService DeleteDescriptionTitleService
        {
            get
            {
                return _deleteDescriptionTitleService = _addDescriptionTitleService == null ? new DeleteDescriptionTitleService(_context) : _deleteDescriptionTitleService;
            }
        }
    }
}
