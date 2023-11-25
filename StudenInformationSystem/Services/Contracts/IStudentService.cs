using StudenInformationSystem.Models;
using StudenInformationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services.Contracts
{
    public interface IStudentService
    {
        Task<Student> Add(string firstname, string lastname, string gender, int age);
        Task<Response> Update(Student student);
        Task<Response> Delete(int id);
        Task<IEnumerable<Student>> GetAll();
    }
}
