using Microsoft.AspNetCore.Mvc;
using School.Models;

namespace School.Controllers
{
    public class Control : Controller
    {
        private const string year = "2022";
        private SchoolContext context;
        public Control(SchoolContext cc)
        {
            context = cc;
        }
        public IActionResult Create()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentName = "laith"},
                new Student(){StudentName = "omar"},
                new Student(){StudentName = "yousef"},
                new Student(){StudentName = "ahmad"},
                new Student(){StudentName = "majd"}
            };

            List<Course> courseList = new List<Course>()
            {
                new Course(){CourseName = "math"},
                new Course(){CourseName = "physics"},
                new Course(){CourseName = "aravic"},
                new Course(){CourseName = "english"}
            };

            List<Grade> gradeList = new List<Grade> 
            {
                new Grade(){StudentId = 1,CourseId = 1,year = year,grade = 79},
                new Grade(){StudentId = 1,CourseId = 2,year = year,grade = 90},
                new Grade(){StudentId = 1,CourseId = 3,year = year,grade = 69},
                new Grade(){StudentId = 1,CourseId = 4,year = year,grade = 80},

                new Grade(){StudentId = 2,CourseId = 1,year = year,grade = 99},
                new Grade(){StudentId = 2,CourseId = 2,year = year,grade = 40},
                new Grade(){StudentId = 2,CourseId = 3,year = year,grade = 83},
                new Grade(){StudentId = 2,CourseId = 4,year = year,grade = 72},

                new Grade(){StudentId = 3,CourseId = 1,year = year,grade = 88},
                new Grade(){StudentId = 3,CourseId = 2,year = year,grade = 76},
                new Grade(){StudentId = 3,CourseId = 3,year = year,grade = 92},
                new Grade(){StudentId = 3,CourseId = 4,year = year,grade = 78},

                new Grade(){StudentId = 4,CourseId = 1,year = year,grade = 90},
                new Grade(){StudentId = 4,CourseId = 2,year = year,grade = 88},
                new Grade(){StudentId = 4,CourseId = 3,year = year,grade = 40},
                new Grade(){StudentId = 4,CourseId = 4,year = year,grade = 89},

                new Grade(){StudentId = 5,CourseId = 1,year = year,grade = 77},
                new Grade(){StudentId = 5,CourseId = 2,year = year,grade = 89},
                new Grade(){StudentId = 5,CourseId = 3,year = year,grade = 69},
                new Grade(){StudentId = 5,CourseId = 4,year = year,grade = 78}
            };

            context.AddRange(studentList, courseList, gradeList);
            context.SaveChanges();
            return View();
        }

        
    }
}
