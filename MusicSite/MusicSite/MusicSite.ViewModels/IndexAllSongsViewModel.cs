using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicSite.ViewModels
{
    public class IndexAllSongsViewModel
    {
        public IEnumerable<IndexSingleSongModel> Songs { get; set; }
    }
}
