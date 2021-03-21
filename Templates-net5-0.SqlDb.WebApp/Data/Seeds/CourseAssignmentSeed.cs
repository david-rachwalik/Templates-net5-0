using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Templates_net5_0.SqlDb.WebApp.Data;
using Templates_net5_0.SqlDb.WebApp.Models;
using System;
using System.Linq;

namespace Templates_net5_0.SqlDb.WebApp.Data.Seeds
{
    public static class CourseAssignmentSeed
    {
        public static void Initialize(MainContext context)
        {
            // Look for any course assignments
            if (context.CourseAssignments.Any())
            {
                return;   // DB has been seeded
            }

            var courseInstructors = new CourseAssignment[]
            {
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Kapoor").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Chemistry" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Microeconomics" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Macroeconomics" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Zheng").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Calculus" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Fakhouri").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Trigonometry" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Harui").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Composition" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
                },
                new CourseAssignment {
                    CourseID = context.Courses.Single(c => c.Title == "Literature" ).CourseID,
                    InstructorID = context.Instructors.Single(i => i.LastName == "Abercrombie").ID
                },
            };

            context.CourseAssignments.AddRange(courseInstructors);
            context.SaveChanges();
        }
    }
}