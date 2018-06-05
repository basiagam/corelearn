using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IntroToRazorPages.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace IntroToRazorPages.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly IntroToRazorPages.Models.MovieContext _context;
        private string searchString;

        public IndexModel(IntroToRazorPages.Models.MovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }


        public async Task OnGetAsync(string movieGenre, string searchString)
        {
            //uzywamy LINQ by dostac listê gatunków
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            var movies = from m in _context.Movie
                         select m;
            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(a => a.Title.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }
            Genres = new SelectList(await genreQuery.Distinct().ToListAsync());
            Movie = await movies.ToListAsync();
        }
    }
}
