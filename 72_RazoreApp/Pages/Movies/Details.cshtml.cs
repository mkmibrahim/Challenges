using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _72_RazoreApp.Data;
using _72_RazoreApp.Models;

namespace _72_RazoreApp.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly _72_RazoreApp.Data._72_RazoreAppContext _context;

        public DetailsModel(_72_RazoreApp.Data._72_RazoreAppContext context)
        {
            _context = context;
        }

      public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Movie == null)
            {
                return NotFound();
            }

            var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }
            else 
            {
                Movie = movie;
            }
            return Page();
        }
    }
}
