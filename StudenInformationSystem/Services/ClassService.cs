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
    public class ClassService : IClassService
    {
        private readonly IClassRepository classRepository;

        public ClassService(IClassRepository classRepository)
        {
            this.classRepository = classRepository;
        }

        public async Task<Class> Add(int courseId, string semester, string year)
        {
            try
            {
                var newClass = new Class
                {
                    CourseId = courseId,
                    Semester = semester,
                    Year = year
                };
                var classAdded = await classRepository.Add(newClass);
                return classAdded;
            }
            catch
            {
                throw;
            }
        }

        public async Task Delete(int courseId)
        {
            try
            {
                var @class = await classRepository.FindByCourse(courseId);
                if(@class != null)
                {
                    await classRepository.Delete(@class);
                }
            }
            catch
            {
                throw;
            }
        }

        public async Task<Class> FindByCourse(int courseId)
        {
            var classCourse = await classRepository.FindByCourse(courseId);
            return classCourse;
        }

        public async Task<IEnumerable<Class>> GetAll()
        {
            try
            {
                var classes = await classRepository.GetAll();
                return classes;
            }
            catch
            {
                throw;
            }
        }

        public async Task<bool> Update(int courseId, Class courseClass)
        {
            try
            {
                var existingClass = await classRepository.FindByCourse(courseId);
                if (existingClass != null)
                {
                    existingClass.Semester = courseClass.Semester;
                    existingClass.Year = courseClass.Year;
                    await classRepository.Update(existingClass);
                    return true;
                }
                return false;
            }
            catch { return false; }
        }
    }
}
