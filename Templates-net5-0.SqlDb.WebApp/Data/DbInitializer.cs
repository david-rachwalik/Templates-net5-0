using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Templates_net5_0.SqlDb.WebApp.Data.Seeds;
using Templates_net5_0.SqlDb.WebApp.Models;

namespace Templates_net5_0.SqlDb.WebApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MainContext context)
        {
            Seed(context);
        }

        public static void Seed(MainContext context)
        {
            MovieSeed.Initialize(context);
            StudentSeed.Initialize(context);
            InstructorSeed.Initialize(context);
            DepartmentSeed.Initialize(context);
            CourseSeed.Initialize(context);
            OfficeAssignmentSeed.Initialize(context);
            CourseAssignmentSeed.Initialize(context);
            EnrollmentSeed.Initialize(context);
        }
    }
}