using System;

namespace Templates_net5_0.SqlDb.WebApp.Models.ViewModels
{
    public class StudentVM
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }
    }
}
