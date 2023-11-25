using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services.Contracts
{
    public interface IEnrollmentService
    {
        Task<bool> Add(int studentId, int classId);
        Task Delete(int studentId);
    }
}
