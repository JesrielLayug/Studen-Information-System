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
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext db;

        public SubjectRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Subject> Add(Subject subject)
        {
            var subjectTobeAdded = db.Subjects.Add(subject);
            await db.SaveChangesAsync();
            return subjectTobeAdded;
        }

        public async Task Delete(Subject subject)
        {
            db.Subjects.Remove(subject);
            await db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Subject>> GetByStudent(int studentId)
        {
            var subjects = await db.Subjects.Where(s => s.StudentId == studentId).ToListAsync();
            return subjects;
        }

        public async Task<Subject> Update(Subject subject)
        {
            var subjectTobeUpdated = db.Subjects.Find(subject.Id);
            if(subjectTobeUpdated != null)
            {
                db.Entry(subjectTobeUpdated).CurrentValues.SetValues(subject);
                db.Entry(subjectTobeUpdated).State = System.Data.Entity.EntityState.Modified;

                await db.SaveChangesAsync();
            }
            return subjectTobeUpdated;
        }
    }
}
