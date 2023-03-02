using Microsoft.AspNetCore.Mvc;

namespace eCommerceSite.Controllers
{
    public class GamesController1 : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
