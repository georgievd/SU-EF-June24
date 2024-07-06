using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsSystem.Data.Models
{
    [Table("Students")]
    public class Student
    {
        public Student()
        {
            StudentsCourses = new HashSet<StudentCourse>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public DateTime? Birthday { get; set; }

        public ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}
