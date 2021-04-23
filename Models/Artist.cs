using System.Collections.Generic;

namespace favorite_songs.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public int YearFundation { get; set; }
        public int? YearRetirement { get; set; }
        public int IsActive { get; set; }

        // Variables that holds the relation 1:M
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; } 
    }
}