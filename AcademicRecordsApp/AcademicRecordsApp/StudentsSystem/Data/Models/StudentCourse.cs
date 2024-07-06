using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsSystem.Data.Models
{
    public class StudentCourse
    {
        [ForeignKey(nameof(Student))]
        public int StudentId { get; set; }
        public Student Student { get; set; }

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
