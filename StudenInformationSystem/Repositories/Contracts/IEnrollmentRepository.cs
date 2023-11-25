using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories.Contracts
{
    public interface IEnrollmentRepository
    {
        Task<Enrollment> Add(Enrollment enrollment);
        Task<Enrollment> Update(Enrollment enrollment);
        Task Delete(Enrollment enrollment);
        Task<Enrollment> FindByStudent(int  studentId);
    }
}
