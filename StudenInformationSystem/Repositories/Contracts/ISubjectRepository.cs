using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories.Contracts
{
    public interface ISubjectRepository
    {
        Task<Subject> Add(Subject subject);
        Task<Subject> Update(Subject subject);  
        Task Delete(Subject subject);
        Task<IEnumerable<Subject>> GetByStudent(int studentId);
    }
}
