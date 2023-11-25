using StudenInformationSystem.Data;
using StudenInformationSystem.Models;
using StudenInformationSystem.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ApplicationDbContext _db;

        public CourseRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task<Course> Add(Course course)
        {
            var courseTobeAdded = _db.Courses.Add(course);
            await _db.SaveChangesAsync();
            return courseTobeAdded;
        }

        public async Task Delete(Course course)
        {
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
        }

        public async Task<int> FindById(int id)
        {
            var courseId = await _db.Courses.FirstOrDefaultAsync(c => c.Id == id);
            return courseId == null ? 0 : courseId.Id;
        }

        public async Task<Course> FindByStudent(int studentId)
        {
            var courseOfStudent = await _db.Courses.FirstOrDefaultAsync(c => c.StudentId == studentId);
            return courseOfStudent;
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            var courses = _db.Set<Course>().ToList() ;
            return courses;
        }

        public async Task<Course> Update(Course course)
        {
            var existingCourse = await _db.Courses.FindAsync(course.Id);
            if (existingCourse != null)
            {
                _db.Entry(existingCourse).CurrentValues.SetValues(course);
                _db.Entry(existingCourse).State = System.Data.Entity.EntityState.Modified;
                await _db.SaveChangesAsync();
            }
            return existingCourse;
        }
    }
}
