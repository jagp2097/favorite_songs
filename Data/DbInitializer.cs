using System;
using System.Linq;
using favorite_songs.Data;
using favorite_songs.Models;

namespace favorite_songs
{
    public static class DbInitializer
    {
        public static void Initializer(SongsContext context)
        {
            context.Database.EnsureCreated();

            if (context.Artists.Any())
            {
                return; // DB has been seed
            }

            Artist[] artists = new Artist[]
            {
                new Artist{ ArtistName="Daft Punk", YearFundation=1993, YearRetirement=2021, IsActive=0 },
                new Artist{ ArtistName="David Guetta", YearFundation=1997, IsActive=1 }
            };  

            foreach (Artist artist in artists)
            {
                context.Artists.Add(artist);
            }
            
            context.SaveChanges();
        }
    }
}