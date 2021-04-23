using System;
using System.Threading.Tasks;
using favorite_songs.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using favorite_songs.Models;

namespace favorite_songs.Controllers
{
    public class ArtistsController : Controller
    {
        private readonly SongsContext _context;

        public ArtistsController(SongsContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Artists.ToListAsync());   
        }

        [HttpGet]
        public IActionResult CreateArtist() => View();

        [HttpPost]
        public IActionResult StoreArtist([Bind] Artist artist) 
        {
            _context.Artists.Add(artist);

            _context.SaveChanges();

            return Content($"{artist.ArtistName}");
        }
    }
}
