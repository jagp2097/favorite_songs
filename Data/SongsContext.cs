using favorite_songs.Models;
using Microsoft.EntityFrameworkCore;

namespace favorite_songs.Data 
{
    public class SongsContext : DbContext
    {
        public SongsContext(DbContextOptions<SongsContext> options) : base(options)
        {
        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().ToTable("Artist");
            modelBuilder.Entity<Album>().ToTable("Album");
            modelBuilder.Entity<Song>().ToTable("Song");
        }

    }
}