namespace favorite_songs.Models
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumName { get; set; }
        public int ReleaseYear { get; set; }
        public int ArtistID { get; set; }

        public Artist Artist { get; set; }
    }
}