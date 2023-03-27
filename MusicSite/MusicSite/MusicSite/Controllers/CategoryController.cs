using Microsoft.AspNetCore.Mvc;
using MusicSite.Services.Contracts;

namespace MusicSite.Controllers
{
    public class CategoryController : Controller
    {
        private ICategoriesService service;
        public CategoryController(ICategoriesService service)
        {
            this.service = service;
        }

        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(string name)
        {
            this.service.CreateCategory(name);
            return this.RedirectToAction("Index", "Home");
        }
    }
}
