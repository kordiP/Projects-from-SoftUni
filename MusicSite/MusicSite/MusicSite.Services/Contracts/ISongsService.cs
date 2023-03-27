using MusicSite.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSite.Services.Contracts
{
    public interface ISongsService
    {
        int CreateSong(string name, string description, string link, string category);

        IndexAllSongsViewModel GetAllSongs();
    }
}
