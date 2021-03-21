using Templates_net5_0.SqlDb.WebApp.Models.ViewModels;
using Templates_net5_0.SqlDb.WebApp.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Templates_net5_0.SqlDb.WebApp.Models;

namespace Templates_net5_0.SqlDb.WebApp.Pages
{
    public class AboutModel : PageModel
    {
        private readonly MainContext _context;

        public AboutModel(MainContext context)
        {
            _context = context;
        }

        public IList<EnrollmentDateGroup> Students { get; set; }

        public async Task OnGetAsync()
        {
            IQueryable<EnrollmentDateGroup> data =
                from student in _context.Students
                group student by student.EnrollmentDate into dateGroup
                select new EnrollmentDateGroup()
                {
                    EnrollmentDate = dateGroup.Key,
                    StudentCount = dateGroup.Count()
                };

            Students = await data.AsNoTracking().ToListAsync();
        }
    }
}