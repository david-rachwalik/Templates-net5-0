using System;
using System.ComponentModel.DataAnnotations;

namespace Templates_net5_0.SqlDb.WebApp.Models.ViewModels
{
    public class CourseVM
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }
        public string DepartmentName { get; set; }
    }
}
