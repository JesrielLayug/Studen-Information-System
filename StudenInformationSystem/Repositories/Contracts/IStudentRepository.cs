using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories.Contracts
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetAll();
        Task<Student> Add(Student student);
        Task<Student> Update(Student student);
        Task Delete(Student student);
        Task<Student> FindById(int id);
    }
}
