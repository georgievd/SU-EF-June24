using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentsSystem.Data.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }

        [ForeignKey(nameof(Course))]
        public int? CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
