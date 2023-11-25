using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services.Contracts
{
    public interface IClassService
    {
        Task<Class> Add(int courseId, string semester, string year);
        Task<IEnumerable<Class>> GetAll();
        Task Delete(int courseId);
        Task<bool> Update(int courseId, Class courseClass);
    }
}
