using Microsoft.EntityFrameworkCore;
using MusicSite.Data;
using MusicSite.Data.Models;
using MusicSite.Services.Contracts;
using MusicSite.ViewModels;

namespace MusicSite.Services
{
    public class PlaylistService : IPlaylistService
    {
        private MusicSiteDbContext context;

        public PlaylistService(MusicSiteDbContext context)
        {
            this.context = context;
        }
        public int Add(int id)
        {
            var song = this.context.Songs.FirstOrDefault(s => s.Id == id);
            if (context.Playlists.Count() == 0)
            {
                var newPlaylist = new Playlist();
                context.Playlists.Add(newPlaylist);
                context.SaveChanges();
            }

            Playlist playlist = context.Playlists.FirstOrDefault(s => s.Id == context.Playlists.Count());
            song.PlaylistId = playlist.Id;
            playlist.Songs.Add(song);
            context.SaveChanges();

            return playlist.Id;
        }

        public IndexPlaylistViewModel GetSongs()
        {
            var playlist = this.context.Playlists.Include(p => p.Songs).FirstOrDefault();
            var all = playlist.Songs.Select(s => new PlaylistSingleVideoModel()
            {
                Link = s.Link,
                Id = s.Id
            });

            var model = new IndexPlaylistViewModel() { Songs = all };

            return model;
        }
    }
}
