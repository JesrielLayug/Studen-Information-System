using Microsoft.VisualBasic.Logging;
using StudenInformationSystem.Data;
using StudenInformationSystem.Models;
using StudenInformationSystem.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;

        public StudentRepository(ApplicationDbContext _db)
        {
            this.db = _db;
        }
        public async Task<Student> Add(Student student)
        {
            var newStudent = db.Students.Add(student);
            await db.SaveChangesAsync();
            return newStudent;
        }

        public async Task Delete(Student student)
        {
            db.Students.Remove(student);
            await db.SaveChangesAsync();
        }

        public async Task<Student> FindById(int id)
        {
            var student = await db.Students.FirstOrDefaultAsync(s => s.Id == id);
            return student;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            try
            {
                //var students = await db.Students.ToListAsync();
                var students = db.Set<Student>().ToList();

                if (students.Any())
                {
                    return students;
                }
                else
                {
                    Serilog.Log.Error("The database query returned an empty collection in GetAll method of StudentRepository");
                    throw new Exception("The database query returned an empty collection in GetAll method of StudentRepository");
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error($"An error occurred in GetAll method of StudentRepository: {ex.Message}");
                throw;
            }
        }

        public async Task<Student> Update(Student student)
        {
            var existingStudent = db.Students.Find(student.Id);

            if (existingStudent != null)
            {
                db.Entry(existingStudent).CurrentValues.SetValues(student);

                db.Entry(existingStudent).State = EntityState.Modified;

                await db.SaveChangesAsync();
            }

            return existingStudent;
        }
    }
}
