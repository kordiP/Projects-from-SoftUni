﻿namespace MusicSite.Data.Models
{
    public class Playlist
    {
        public Playlist()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.Songs = new List<Song>();
        }
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public ICollection<Song> Songs { get; set; }

    }
}