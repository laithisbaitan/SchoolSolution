namespace School.Models
{
    public class Grade
    {

        public int? StudentId { get; set; }
        public Student Students { get; set; }

        public int? CourseId { get; set; }
        public Course Course { get; set;}

        public string? year { get; set; }
        public int? grade { get; set; }
    }
}
