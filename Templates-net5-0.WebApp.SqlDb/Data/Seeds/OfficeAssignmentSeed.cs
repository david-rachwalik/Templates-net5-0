﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Templates_net5_0.SqlDb.WebApp.Data;
using Templates_net5_0.SqlDb.WebApp.Models;
using System;
using System.Linq;

namespace Templates_net5_0.SqlDb.WebApp.Data.Seeds
{
    public static class OfficeAssignmentSeed
    {
        public static void Initialize(MainContext context)
        {
            // Look for any office assignments
            if (context.OfficeAssignments.Any())
            {
                return;   // DB has been seeded
            }

            var officeAssignments = new OfficeAssignment[]
            {
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Fakhouri").ID,
                    Location = "Smith 17" },
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Harui").ID,
                    Location = "Gowan 27" },
                new OfficeAssignment {
                    InstructorID = context.Instructors.Single( i => i.LastName == "Kapoor").ID,
                    Location = "Thompson 304" },
            };

            context.OfficeAssignments.AddRange(officeAssignments);
            context.SaveChanges();
        }
    }
}