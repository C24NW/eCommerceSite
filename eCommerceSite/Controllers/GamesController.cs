using Microsoft.AspNetCore.Mvc;

namespace eCommerceSite.Controllers
{
    public class GamesController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
