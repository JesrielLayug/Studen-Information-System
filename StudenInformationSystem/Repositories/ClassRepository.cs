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
    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext db;

        public ClassRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public async Task<Class> Add(Class @class)
        {
            var classTobeAdded = db.Classes.Add(@class);
            await db.SaveChangesAsync();
            return classTobeAdded;
        }

        public async Task Delete(Class @class)
        {
            db.Classes.Remove(@class);
            await db.SaveChangesAsync();
        }

        public async Task<Class> FindByCourse(int courseId)
        {
            var classByCourseId = await db.Classes.FirstOrDefaultAsync(c => c.CourseId == courseId);
            return classByCourseId;
        }

        public async Task<IEnumerable<Class>> GetAll()
        {
            var classes = db.Set<Class>().ToList();
            return classes;
        }

        public async Task<Class> Update(Class @class)
        {
            var classTobeUpdated = db.Classes.Find(@class.Id);
            if(classTobeUpdated != null)
            {
                db.Entry(classTobeUpdated).CurrentValues.SetValues(@class);
                db.Entry(classTobeUpdated).State = EntityState.Modified;
                await db.SaveChangesAsync();
            }
            return classTobeUpdated;
        }
    }
}
