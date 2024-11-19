using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieExample.Data;
using MovieExample.Models;

namespace MovieExample.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieExample.Data.MovieExampleContext _context;

        public IndexModel(MovieExample.Data.MovieExampleContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
