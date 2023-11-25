using StudenInformationSystem.Models;
using StudenInformationSystem.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Utilities
{
    public static class DTOConvertion
    {
        public static IEnumerable<DTOStudentInformation> Convert(
                                                                 this IEnumerable<Student> students,
                                                                 IEnumerable<Course> courses,
                                                                 IEnumerable<Class> classes)
        {
            return (from student in students
                    join course in courses on student.Id equals course.StudentId
                    join @class in classes on course.Id equals @class.CourseId
                    select new DTOStudentInformation
                    {
                        ID = student.Id,
                        Firstname = student.Firstname,
                        Lastname = student.Lastname,
                        Gender = student.Gender,
                        Age = student.Age,
                        Course = course.CourseName,
                        Credits = course.Credits,
                        Semester = @class.Semester,
                        Year = @class.Year
                    }).ToList();
        }
    }
}
