using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieExample.Models;

namespace MovieExample.Data
{
    public class MovieExampleContext : DbContext
    {
        public MovieExampleContext (DbContextOptions<MovieExampleContext> options)
            : base(options)
        {
        }

        public DbSet<MovieExample.Models.Movie> Movie { get; set; } = default!;
    }
}
