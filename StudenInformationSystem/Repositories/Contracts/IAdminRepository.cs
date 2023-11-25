using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories.Contracts
{
    public interface IAdminRepository
    {
        Task<Admin> GetByUsername(string username);
    }
}
