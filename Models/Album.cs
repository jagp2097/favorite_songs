using System;
using System.Collections.Generic;

namespace favorite_songs.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int? ReleaseYear { get; set; }
        // Foreign key
        public int ArtistID { get; set; }

        // Navigaton property 
        public Artist Artist { get; set; }

        public List<Song> Songs { get; set; }
    }
}