using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSite.ViewModels
{
    public class IndexPlaylistViewModel
    {
        public IEnumerable<PlaylistSingleVideoModel> Songs { get; set; }
    }
}
