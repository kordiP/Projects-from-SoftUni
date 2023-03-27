using MusicSite.Data;
using MusicSite.Data.Models;
using MusicSite.Services.Contracts;
using MusicSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSite.Services
{
    public class SongsService : ISongsService
    {
        private MusicSiteDbContext context;
        public SongsService(MusicSiteDbContext context)
        {
            this.context = context;
        }
        public int CreateSong(string name, string description, string link, string category)
        {
            var categoryObj = this.context.Categories.FirstOrDefault(c => c.Name == category);
            var song = new Song()
            {
                Name = name,
                Description = description,
                Link = link,
                CategoryId = categoryObj.Id,
                Views = 1
            };
            
            this.context.Songs.Add(song);
            categoryObj.Songs.Add(song);
            this.context.SaveChanges();
             
            return song.Id;

        }

        public IndexAllSongsViewModel GetAllSongs()
        {
            var songs = context.Songs.Where(x => x.DeletedOn == null).Select(s => new IndexSingleSongModel()
            {
                Name = s.Name,
                Description = s.Description,
                Link = s.Link,
                Category = s.Category.Name,
                Id = s.Id
            });
            var model = new IndexAllSongsViewModel() { Songs = songs };
            return model;
        }
    }
}
