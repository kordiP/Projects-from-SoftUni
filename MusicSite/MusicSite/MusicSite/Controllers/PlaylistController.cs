using Microsoft.AspNetCore.Mvc;
using MusicSite.Services.Contracts;

namespace MusicSite.Controllers
{
    public class PlaylistController : Controller
    {
        private IPlaylistService service;
        public PlaylistController(IPlaylistService service)
        {
            this.service = service;
        }
        public IActionResult PlaylistAll()
        {
            var model = service.GetSongs();
            return View(model);
        }
        public IActionResult AddToPlaylist(int id)
        {
            service.Add(id);
            return this.RedirectToAction("PlaylistAll","Playlist");
        }
    }
}
