using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Templates_net5_0.SqlDb.WebApp.Data;
using Templates_net5_0.SqlDb.WebApp.Models;

namespace Templates_net5_0.SqlDb.WebApp.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Templates_net5_0.SqlDb.WebApp.Data.MainContext _context;

        public DetailsModel(Templates_net5_0.SqlDb.WebApp.Data.MainContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students
                .Include(s => s.Enrollments)
                .ThenInclude(e => e.Course)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
