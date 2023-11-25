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
    public class EnrollmentService : IEnrollmentService
    {
        private readonly IEnrollmentRepository enrollmentRepository;

        public EnrollmentService(IEnrollmentRepository enrollmentRepository)
        {
            this.enrollmentRepository = enrollmentRepository;
        }

        public async Task<bool> Add(int studentId, int classId)
        {
            try
            {
                var enrollment = new Enrollment
                {
                    StudentId = studentId,
                    ClassId = classId
                };
                await enrollmentRepository.Add(enrollment);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task Delete(int studentId)
        {
            var studentEnrollment = await enrollmentRepository.FindByStudent(studentId);
            if (studentEnrollment != null)
            {
                await enrollmentRepository.Delete(studentEnrollment);
            }
        }
    }
}
