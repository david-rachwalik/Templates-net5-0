using System;
using System.ComponentModel.DataAnnotations;

namespace Templates_net5_0.SqlDb.WebApp.Models.ViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int StudentCount { get; set; }
    }
}