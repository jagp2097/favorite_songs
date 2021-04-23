using System;

namespace favorite_songs.Models 
{
    public class Song
    {
        public int SongId { get; set; }
        public string SongName { get; set; }
        public string? Genre { get; set; }
        public int? ReleaseYear { get; set; }
        public int AlbumID { get; set; }
        public string? Lyrics { get; set; }

        public Album Album { get; set; }
    }
}