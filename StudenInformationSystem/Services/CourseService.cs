using StudenInformationSystem.Models;
using StudenInformationSystem.Repositories.Contracts;
using StudenInformationSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            this.courseRepository = courseRepository;
        }

        public async Task<Course> Add(string courseName, string credits, int studentId)
        {
            try
            {
                var course = new Course
                {
                    CourseName = courseName,
                    Credits = credits,
                    StudentId = studentId
                };
                var addedCourse = await courseRepository.Add(course);

                return addedCourse;
            }
            catch
            {
               throw;
            }
        }

        public async Task Delete(int studentId)
        {
            try
            {
                var courseOfStudent = await courseRepository.FindByStudent(studentId);
                if (courseOfStudent != null)
                {
                    await courseRepository.Delete(courseOfStudent);
                }
            }
            catch { throw; }
        }

        public async Task<IEnumerable<Course>> GetAll()
        {
            try
            {
                var courses = await courseRepository.GetAll();
                return courses;
            }
            catch
            {
                throw;
            }
        }

        public async Task<int> Update(int studentId, Course course)
        {
            try
            {
                var existingCourse = await courseRepository.FindByStudent(studentId);
                if(existingCourse != null)
                {
                    existingCourse.CourseName = course.CourseName;
                    existingCourse.Credits = course.Credits;

                    await courseRepository.Update(existingCourse);
                    return existingCourse.Id;
                }
                return 0;
            }
            catch
            {
                throw;
            }
        }
    }
}
