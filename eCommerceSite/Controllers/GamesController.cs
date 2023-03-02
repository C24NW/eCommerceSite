using eCommerceSite.Data;
using eCommerceSite.Models;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceSite.Controllers
{
    public class GamesController : Controller
    {

        private readonly VideoGameContext _context;

        public GamesController(VideoGameContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Game g)
        {
            if (ModelState.IsValid)
            {

                //Adds game object g to database
                _context.Games.Add(g); //prepares insert
                _context.SaveChanges(); //runs insert

                //Show success message on page
                ViewData["Message"] = $"{g.Title} was added successfully!";

                return View();
            }
            return View(g);
        }
    }
}
