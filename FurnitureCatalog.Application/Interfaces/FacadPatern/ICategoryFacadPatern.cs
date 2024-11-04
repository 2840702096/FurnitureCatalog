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

namespace FurnitureCatalog.Application.Interfaces.FacadPatern
{
    public interface ICategoryFacadPatern
    {
        public GetCategoriesService GetCategoriesService { get; }
        public GetCategoryCount GetCategoryCount { get; }
        public AddCategoryService AddCategoryService { get; }
        public GetCategoryInfoService GetCategoryInfoService { get; }
        public DeleteCategoryService DeleteCategoryService { get; }
        public GetSpecificationTitlesService GetSpecificationTitlesService { get; }
        public AddSpecificationTitlesService AddSpecificationTitlesService { get; }
        public DeleteSpecificationTitleService DeleteSpecificationTitleService { get; }
        public GetDescriptionTitlesService GetDescriptionTitlesService { get; }
        public AddDescriptionTitleService AddDescriptionTitleService { get; }
        public DeleteDescriptionTitleService DeleteDescriptionTitleService { get; }

    }
}
