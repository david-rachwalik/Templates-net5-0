using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Templates_net5_0.SqlDb.WebApp.Data;
using Templates_net5_0.SqlDb.WebApp.Models;

namespace Templates_net5_0.SqlDb.WebApp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Templates_net5_0.SqlDb.WebApp.Data.MainContext _context;

        public CreateModel(Templates_net5_0.SqlDb.WebApp.Data.MainContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
