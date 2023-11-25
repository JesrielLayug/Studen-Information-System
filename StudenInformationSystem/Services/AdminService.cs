using StudenInformationSystem.Models;
using StudenInformationSystem.Repositories.Contracts;
using StudenInformationSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository adminRepository;

        public AdminService(IAdminRepository _adminRepository)
        {
            adminRepository = _adminRepository;
        }

        public async Task<Response> Login(string username, string password)
        {
            try
            {
                var adminAcount = await adminRepository.GetByUsername(username);
                if (adminAcount != null)
                {
                    if(adminAcount.Username == username && adminAcount.Password == password)
                    {
                        return new Response
                        {
                            IsSucess = true,
                            Message = "Successfully log in."
                        };
                    }
                    return new Response
                    {
                        IsSucess = false,
                        Message = "Wrong email or password."
                    };
                }

                return new Response
                {
                    IsSucess = false,
                    Message = "Account does not exist."
                };
            }
            catch
            {
                throw;
            }

        }
    }
}
