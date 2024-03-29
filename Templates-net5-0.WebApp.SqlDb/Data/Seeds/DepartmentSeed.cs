﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Templates_net5_0.SqlDb.WebApp.Data;
using Templates_net5_0.SqlDb.WebApp.Models;
using System;
using System.Linq;

namespace Templates_net5_0.SqlDb.WebApp.Data.Seeds
{
    public static class DepartmentSeed
    {
        public static void Initialize(MainContext context)
        {
            // Look for any departments
            if (context.Departments.Any())
            {
                return;   // DB has been seeded
            }

            var departments = new Department[]
            {
                new Department { Name = "English",     Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Abercrombie").ID },
                new Department { Name = "Mathematics", Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Fakhouri").ID },
                new Department { Name = "Engineering", Budget = 350000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Harui").ID },
                new Department { Name = "Economics",   Budget = 100000,
                    StartDate = DateTime.Parse("2007-09-01"),
                    InstructorID  = context.Instructors.Single( i => i.LastName == "Kapoor").ID }
            };

            context.Departments.AddRange(departments);
            context.SaveChanges();
        }
    }
}