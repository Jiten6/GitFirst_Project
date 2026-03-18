using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ToDoListWithSacffolding.Models
{
    public class Student
    {
        [DisplayName("Student ID")]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Age { get; set; }

        [DisplayName("Date Of Birth")]
        [DataType(DataType.Date)]
        public DateOnly DOB { get; set; }   // ✅ Date only format

        [DisplayName("Mobile Number")]
        [Required]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Mobile number must be 10 digits")]
        public string Mobile_Number { get; set; } = string.Empty;  // ✅ Must be string

        public string Address { get; set; } = string.Empty;

        public int Class { get; set; } 

        public string Gender { get; set; } = string.Empty;

        public bool IsFeePaid { get; set; }

    }
}
