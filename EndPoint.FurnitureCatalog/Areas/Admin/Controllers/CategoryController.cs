using FurnitureCatalog.Application.Interfaces.FacadPatern;
using FurnitureCatalog.Application.Services.Categories.Command.AddCategory;
using FurnitureCatalog.Application.Services.Categories.FacadPatern;
using FurnitureCatalog.Application.Services.Categories.Query.GetSpecificationTitles;
using FurnitureCatalog.Common;
using Microsoft.AspNetCore.Mvc;

namespace EndPoint.FurnitureCatalog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryFacadPatern _categoryFacadPatern;

        public CategoryController(ICategoryFacadPatern categoryFacadPatern)
        {
            _categoryFacadPatern = categoryFacadPatern;
        }

        [Route("Admin/Categories")]
        public IActionResult Index(int? parentId, int pageId = 1)
        {
            ViewBag.PageId = pageId;
            ViewBag.ParentId = parentId;
            ViewBag.PageCount = SetPageCountForPagination.PageCount(_categoryFacadPatern.GetCategoryCount.Execute(parentId), 2);
            return View(_categoryFacadPatern.GetCategoriesService.Execute(pageId, parentId).Data);
        }

        #region AddOrEditCategoryOrSubCategory

        [Route("Admin/AddCategory/{id?}")]
        public IActionResult AddCategory(int? id, int? editId)
        {
            ViewBag.Id = id;
            ViewBag.EditId = editId;
            return PartialView(_categoryFacadPatern.GetCategoryInfoService.Execute(editId));
        }

        [HttpPost]
        [Route("Admin/AddCategory/{id?}")]
        public IActionResult AddCategory(AddCategoryServiceInputDto input)
        {
            var Result = _categoryFacadPatern.AddCategoryService.Execute(input);
            return Json(Result);
        }

        #endregion

        #region DeleteCategory

        [HttpPost]
        [Route("Admin/DeleteCategory")]
        public IActionResult DeleteCategory(int id)
        {
            var Result = _categoryFacadPatern.DeleteCategoryService.Execute(id);
            return Json(Result);
        }

        #endregion

        #region SpecificationTitles

        [Route("Admin/SpecificationTitles/{id}")]
        public IActionResult SpecificationTitles(int id)
        {
            ViewBag.CategoryId = id;
            ViewBag.Titles = _categoryFacadPatern.GetSpecificationTitlesService.Execute(id);
            return View();
        }

        #region AddSpecificationTitles

        [HttpPost]
        [Route("Admin/AddSpecificationTitles")]
        public IActionResult AddSpecificationTitles(SpecificationTitlesDto input)
        {
            _categoryFacadPatern.AddSpecificationTitlesService.Execute(input);
            return Redirect($"/Admin/SpecificationTitles/{input.CategoryId}");
        }

        #endregion

        #region DeleteSpecificationTitle

        [HttpPost]
        [Route("Admin/DeleteSpecificationTitle")]
        public IActionResult DeleteSpecificationTitle(int id)
        {
            var Result = _categoryFacadPatern.DeleteSpecificationTitleService.Execute(id);
            return Json(Result);
        }

        #endregion

        #endregion

        #region DescriptionTitles

        [Route("Admin/DescriptionTitles/{id}")]
        public IActionResult DescriptionTitles(int id)
        {
            ViewBag.CategoryId = id;
            ViewBag.Titles = _categoryFacadPatern.GetDescriptionTitlesService.Execute(id);
            return View();
        }

        #region AddSpecificationTitles

        [HttpPost]
        [Route("Admin/AddDescriptionTitles")]
        public IActionResult AddDescriptionTitles(SpecificationTitlesDto input)
        {
            _categoryFacadPatern.AddDescriptionTitleService.Execute(input);
            return Redirect($"/Admin/DescriptionTitles/{input.CategoryId}");
        }

        #endregion

        #region DeleteDescriptionTitle

        [HttpPost]
        [Route("Admin/DeleteDescriptionTitle")]
        public IActionResult DeleteDescriptionTitle(int id)
        {
            var Result = _categoryFacadPatern.DeleteDescriptionTitleService.Execute(id);
            return Json(Result);
        }

        #endregion

        #endregion
    }
}
