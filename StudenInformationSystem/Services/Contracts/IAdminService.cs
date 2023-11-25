using StudenInformationSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services.Contracts
{
    public interface IAdminService
    {
        Task<Response> Login(string username, string password);
    }
}
