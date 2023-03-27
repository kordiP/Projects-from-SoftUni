using Microsoft.AspNetCore.Mvc;
using MusicSite.Services.Contracts;

namespace MusicSite.Controllers
{
    public class SongsController : Controller
    {
        private ISongsService service;
        public SongsController(ISongsService service)
        {
            this.service = service;
        }
        public IActionResult Create()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Create(string name, string description, string link, string category) 
        {
            this.service.CreateSong(name, description, link, category);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
