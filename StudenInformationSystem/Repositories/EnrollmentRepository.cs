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
    public class EnrollmentRepository : IEnrollmentRepository
    {
        private readonly ApplicationDbContext _db;

        public EnrollmentRepository(ApplicationDbContext db)
        {
            this._db = db;
        }

        public async Task<Enrollment> Add(Enrollment enrollment)
        {
            var enrollmentTobeAdded = _db.Enrollments.Add(enrollment);
            await _db.SaveChangesAsync();
            return enrollmentTobeAdded;
        }

        public async Task Delete(Enrollment enrollment)
        {
            _db.Enrollments.Remove(enrollment);
            await _db.SaveChangesAsync();
        }

        public async Task<Enrollment> FindByStudent(int studentId)
        {
            var enrollment = await _db.Enrollments.FirstOrDefaultAsync(e => e.StudentId ==  studentId);
            return enrollment;
        }

        public async Task<Enrollment> Update(Enrollment enrollment)
        {
            var enrollmentTobeUpdated = _db.Enrollments.Find(enrollment.Id);
            if(enrollmentTobeUpdated != null)
            {
                _db.Entry(enrollmentTobeUpdated).CurrentValues.SetValues(enrollment);
                _db.Entry(enrollmentTobeUpdated).State = System.Data.Entity.EntityState.Modified;
                await _db.SaveChangesAsync();   
            }
            return enrollmentTobeUpdated;
        }
    }
}
