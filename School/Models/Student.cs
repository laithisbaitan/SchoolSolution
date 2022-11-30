using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace School.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int? StudentId { get; set; }
        public string? StudentName { get; set; }

        public IList<Grade> Grades { get; set; }
    }
}
