using Templates_net5_0.SqlDb.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Templates_net5_0.SqlDb.WebApp.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly Templates_net5_0.SqlDb.WebApp.Data.MainContext _context;

        public DetailsModel(Templates_net5_0.SqlDb.WebApp.Data.MainContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Courses
                 .AsNoTracking()
                 .Include(c => c.Department)
                 .FirstOrDefaultAsync(m => m.CourseID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}