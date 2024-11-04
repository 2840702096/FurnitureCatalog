using FurnitureCatalog.Application.Interfaces.FacadPatern;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddOrEditFurniture;
using FurnitureCatalog.Application.Services.Furnitures.Command.AddSpecification;
using FurnitureCatalog.Common;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EndPoint.FurnitureCatalog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class FurnitureController : Controller
    {
        private readonly IFurnitureFacadPatern _furnitureFacadPatern;

        public FurnitureController(IFurnitureFacadPatern furnitureFacadPatern)
        {
            _furnitureFacadPatern = furnitureFacadPatern;
        }

        [Route("Admin/Furnitures")]
        public IActionResult Index(int pageId = 1, string filter = "")
        {
            ViewBag.PageId = pageId;
            ViewBag.SearchText = filter;
            ViewBag.PageCount = SetPageCountForPagination.PageCount(_furnitureFacadPatern.GetCountOfFurnituresService.Execute(), 10);
            return View(_furnitureFacadPatern.GetFurnituresService.Execute(pageId, filter).Furnitures);
        }

        #region AddOrEditFurniture

        [Route("Admin/AddOrEditFurniture")]
        public IActionResult AddOrEditFurniture(int? id)
        {
            ViewBag.Id = id;
            var Categories = _furnitureFacadPatern.GetCategoriesForSelectListService.Execute();
            ViewBag.Categories = new SelectList(Categories, "Value", "Text");
            return PartialView(_furnitureFacadPatern.GetFurnitureInfoForEditService.Execute(id));
        }

        [HttpPost]
        [Route("Admin/AddOrEditFurniture")]
        public IActionResult AddOrEditFurniture(AddOrEditFurnitureServiceInputDto input)
        {
            var Result = _furnitureFacadPatern.AddOrEditFurnitureService.Execute(input);
            return new JsonResult(Result);
        }

        #endregion

        #region FurnitureSpecifications

        [Route("Admin/FurnitureSpecifications/{id}")]
        public IActionResult FurnitureSpecifications(int id)
        {
            ViewBag.FurnitureId = id;
            var SpecificationTitles = _furnitureFacadPatern.GetSpecificationTitlesForFurniturePartService.Execute(id);
            ViewBag.SpecificationTitles = new SelectList(SpecificationTitles, "Value", "Text");
            ViewBag.Specifications = _furnitureFacadPatern.GetSpecificationsService.Execute(id);
            return View();
        }

        #region AddSpecification

        [HttpPost]
        [Route("Admin/AddSpecification")]
        public IActionResult AddSpecification(AddSpecificationServiceInputDto input)
        {
            _furnitureFacadPatern.AddSpecificationService.Execute(input);
            return Redirect($"/Admin/FurnitureSpecifications/{input.FurnitureId}");
        }

        #endregion

        #region DeleteSpecification

        [Route("Admin/DeleteSpecification")]
        public IActionResult DeleteSpecification(int id)
        {
            var Result = _furnitureFacadPatern.DeleteSpecificationService.Execute(id);
            return Json(Result);
        }

        #endregion

        #endregion

        #region FurnitureDescriptions

        [Route("Admin/FurnitureDescriptions/{id}")]
        public IActionResult FurnitureDescriptions(int id)
        {
            ViewBag.FurnitureId = id;
            var DescriptionsTitles = _furnitureFacadPatern.GetDescriptionTitlesService.Execute(id);
            ViewBag.DescriptionTitles = new SelectList(DescriptionsTitles, "Value", "Text");
            var s = _furnitureFacadPatern.GetDescriptionsService.Execute(id);
            ViewBag.Descriptions = _furnitureFacadPatern.GetDescriptionsService.Execute(id);
            return View();
        }

        #region ShowDescription

        [Route("Admin/ShowDescription")]
        public IActionResult ShowDescription(int id)
        {
            ViewBag.Pasage = _furnitureFacadPatern.GetDescriptionPasageService.Execute(id);
            return PartialView();
        }

        #endregion

        #region AddDescriptions

        [HttpPost]
        [Route("Admin/AddDescriptions")]
        public IActionResult AddDescriptions(AddSpecificationServiceInputDto input)
        {
            _furnitureFacadPatern.AddDescriptionService.Execute(input);
            return Redirect($"/Admin/FurnitureDescriptions/{input.FurnitureId}");
        }

        #endregion

        #region DeleteDescription

        [Route("Admin/DeleteDescription")]
        public IActionResult DeleteDescription(int id)
        {
            var Result = _furnitureFacadPatern.DeleteDescriptionServcie.Execute(id);
            return Json(Result);
        }

        #endregion

        #endregion

        #region FurnitureActivation

        [Route("Admin/FurnitureActivation")]
        public IActionResult FurnitureActivation(int id)
        {
            var Result = _furnitureFacadPatern.FurnitureActivationService.Execute(id);
            return Json(Result);
        }

        #endregion

        #region FurnitureDeleting

        [Route("Admin/FurnitureDeleting")]
        public IActionResult FurnitureDeleting(int id)
        {
            var Result = _furnitureFacadPatern.FurnitureDeletingService.Execute(id);
            return Json(Result);
        }

        #endregion
    }
}
