using Microsoft.AspNetCore.Mvc;

namespace EndPoint.FurnitureCatalog.Controllers
{
    public class FurnitureController : Controller
    {
        [Route("/SingleFurniture")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
