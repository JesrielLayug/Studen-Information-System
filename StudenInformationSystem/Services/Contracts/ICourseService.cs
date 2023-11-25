using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services.Contracts
{
    public interface ICourseService
    {
        Task<Course> Add(string courseName, string credits, int studentId);
        Task<IEnumerable<Course>> GetAll();
        Task Delete(int studentId);
        Task<int> Update(int studentId, Course course);
    }
}
