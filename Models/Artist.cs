using System.Collections.Generic;

namespace favorite_songs.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public int YearFundation { get; set; }
        public int YearRetirement { get; set; }
        public bool IsActive { get; set; }

        List<Album> Albums { get; set; }
        List<Song> Songs { get; set; } 
    }
}