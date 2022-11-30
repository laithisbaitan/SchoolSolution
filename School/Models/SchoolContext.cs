using Microsoft.EntityFrameworkCore;
using School.Models;

namespace School.Models
{
    public class SchoolContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-B9QHK7H;database=SchoolDB;Trusted_Connection=True;encrypt=false");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Grade>().HasKey(sc => new { sc.StudentId, sc.CourseId });
        }
        //entities
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}