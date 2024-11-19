using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MovieExample.Data;
using MovieExample.Models;

namespace MovieExample.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly MovieExample.Data.MovieExampleContext _context;

        public CreateModel(MovieExample.Data.MovieExampleContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            Movie.Id = Guid.NewGuid().ToString();

            //if (!ModelState.IsValid)
            //{
            //    return Page();
            //}

            if (Movie.Title == "" || Movie.Title == null)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
