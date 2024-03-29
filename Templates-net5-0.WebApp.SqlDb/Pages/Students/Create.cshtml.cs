﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Templates_net5_0.SqlDb.WebApp.Data;
using Templates_net5_0.SqlDb.WebApp.Models;
using Templates_net5_0.SqlDb.WebApp.Models.ViewModels;

namespace Templates_net5_0.SqlDb.WebApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly MainContext _context;

        public CreateModel(MainContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        //public async Task<IActionResult> OnPostAsync()
        //{
        //    var emptyStudent = new Student();

        //    if (await TryUpdateModelAsync<Student>(
        //        emptyStudent,
        //        "student",   // Prefix for form value.
        //        s => s.FirstMidName, s => s.LastName, s => s.EnrollmentDate))
        //    {
        //        _context.Students.Add(emptyStudent);
        //        await _context.SaveChangesAsync();
        //        return RedirectToPage("./Index");
        //    }

        //    return Page();
        //}

        [BindProperty]
        public StudentVM StudentVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var entry = _context.Add(new Student());
            entry.CurrentValues.SetValues(StudentVM);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
    }
}
