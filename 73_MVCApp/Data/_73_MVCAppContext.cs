using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _73_MVCApp.Models;

namespace _73_MVCApp.Data
{
    public class _73_MVCAppContext : DbContext
    {
        public _73_MVCAppContext (DbContextOptions<_73_MVCAppContext> options)
            : base(options)
        {
        }

        public DbSet<_73_MVCApp.Models.Movie> Movie { get; set; } = default!;
    }
}
