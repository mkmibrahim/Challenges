using System.ComponentModel.DataAnnotations;

namespace _71_MVCApplication.Models.SchoolViewModels
{
    public class EnrollmentDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? EnrollmentDate { get; set; }

        public int Studentcount { get; set; }
    }
}
