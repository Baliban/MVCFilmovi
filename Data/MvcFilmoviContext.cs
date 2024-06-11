using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;

namespace MvcFilmovi.Data
{
    public class MvcFilmoviContext : DbContext
    {
        public MvcFilmoviContext (DbContextOptions<MvcFilmoviContext> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Movie> Movie { get; set; } = default!;
    }
}
