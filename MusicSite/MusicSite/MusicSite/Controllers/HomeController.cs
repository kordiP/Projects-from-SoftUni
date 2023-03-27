using Microsoft.AspNetCore.Mvc;
using MusicSite.Models;
using MusicSite.Services.Contracts;
using System.Diagnostics;

namespace MusicSite.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}
        private ISongsService service;
        public HomeController(ISongsService service)
        {
            this.service = service;
        }
        public IActionResult Test()
        {
            return View();
        }

        public IActionResult Index()
        {
            var model = service.GetAllSongs();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}