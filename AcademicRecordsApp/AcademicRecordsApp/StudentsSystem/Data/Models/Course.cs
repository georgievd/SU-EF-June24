using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsSystem.Data.Models
{
    [Table("Courses")]
    public class Course
    {
        public Course()
        {
            StudentsCourses = new HashSet<StudentCourse>();
            Resources = new HashSet<Resource>();
        }

        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public ICollection<Resource> Resources { get; set; }
        public ICollection<StudentCourse> StudentsCourses { get; set; }
    }
}
