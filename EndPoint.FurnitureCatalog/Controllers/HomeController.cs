using EndPoint.FurnitureCatalog.Models;
using FurnitureCatalog.Application.Interfaces.FacadPatern;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EndPoint.FurnitureCatalog.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFurnitureFacadPatern _furnitureFacadPatern;

        public HomeController(ILogger<HomeController> logger, IFurnitureFacadPatern furnitureFacadPatern)
        {
            _logger = logger;
            _furnitureFacadPatern = furnitureFacadPatern;
        }

        public IActionResult Index(int pageId = 1, string filter = "")
        {
            ViewBag.Furniture = _furnitureFacadPatern.GetFurnituresService.Execute(pageId, filter).Furnitures;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
