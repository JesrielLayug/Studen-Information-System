using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories.Contracts
{
    public interface IClassRepository
    {
        Task<Class> Add(Class @class);
        Task<Class> Update(Class @class);
        Task Delete(Class @class);
        Task<IEnumerable<Class>> GetAll();
        Task<Class> FindByCourse(int courseId);
    }
}
