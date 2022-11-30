using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? CourseId { get; set; }
        public string? CourseName { get; set; }

        public IList<Grade> Grades { get; set; }
    }
}
