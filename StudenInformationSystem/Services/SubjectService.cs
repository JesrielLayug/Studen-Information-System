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
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository subjectRepository;

        public SubjectService(ISubjectRepository subjectRepository)
        {
            this.subjectRepository = subjectRepository;
        }

        public async Task<bool> Add(int studentId, string subjectName)
        {
            try
            {
                var newSubject = new Subject
                {
                    StudentId = studentId,
                    Name = subjectName
                };
                await subjectRepository.Add(newSubject);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(int studentId)
        {
            var studentSubjects = await subjectRepository.GetByStudent(studentId);
            foreach (var subject in studentSubjects)
            {
                await subjectRepository.Delete(subject);
            }
            return true;
        }

        public async Task<IEnumerable<Subject>> GetByStudent(int studentId)
        {
            try
            {
                var existingSubjects = await subjectRepository.GetByStudent(studentId);
                return existingSubjects;
            }
            catch
            {
                throw;
            }
        }

    }
}
