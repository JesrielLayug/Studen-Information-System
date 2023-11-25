using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories.Contracts
{
    public interface ICourseRepository
    {
        Task<Course> Add(Course course);
        Task<Course> Update(Course course);
        Task Delete(Course course);
        Task<int> FindById(int id);
        Task<IEnumerable<Course>> GetAll();
        Task<Course> FindByStudent(int studentId);
    }
}
