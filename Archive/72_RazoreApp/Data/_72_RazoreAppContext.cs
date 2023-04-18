using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _72_RazoreApp.Models;

namespace _72_RazoreApp.Data
{
    public class _72_RazoreAppContext : DbContext
    {
        public _72_RazoreAppContext (DbContextOptions<_72_RazoreAppContext> options)
            : base(options)
        {
        }

        public DbSet<_72_RazoreApp.Models.Movie> Movie { get; set; } = default!;
    }
}
