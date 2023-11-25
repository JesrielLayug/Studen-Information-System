using StudenInformationSystem.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace StudenInformationSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Enrollment> Enrollments { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
    }

}