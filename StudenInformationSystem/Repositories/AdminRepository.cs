using StudenInformationSystem.Data;
using StudenInformationSystem.Models;
using StudenInformationSystem.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext db;

        public AdminRepository(ApplicationDbContext _db)
        {
            db = _db;
        }

        public async Task<Admin> GetByUsername(string username)
        {
            var admin = await db.Admins.FirstOrDefaultAsync(a => a.Username == username);
            return admin;   
        }
    }
}
