using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services.Contracts
{
    public interface ISubjectService
    {
        Task<bool> Add(int studentId, string subjectName);
        Task<bool> Delete(int studentId);
        Task<IEnumerable<Subject>> GetByStudent(int studentId);
        Task<bool> Update(int studentId, IEnumerable<string> subjects);
    }
}
