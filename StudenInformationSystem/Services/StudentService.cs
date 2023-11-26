using StudenInformationSystem.Models;
using StudenInformationSystem.Models.DTOs;
using StudenInformationSystem.Repositories.Contracts;
using StudenInformationSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudenInformationSystem.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            this.studentRepository = studentRepository;
            
        }

        public async Task<Student> Add(string firstname, string lastname, string gender, int age)
        {
            try
            {
                var student = new Student
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    Gender = gender,
                    Age = age,
                };

                var studentAdded = await studentRepository.Add(student);
                return studentAdded;
            }
            catch
            {
                throw;
            }
        }

        public async Task<Response> Delete(int id)
        {
            try
            {
                var student = await studentRepository.FindById(id);
                if (student != null)
                {
                    await studentRepository.Delete(student);
                    return new Response
                    {
                        IsSucess = true,
                        Message = "Successfully delete the student."
                    };
                }
                return new Response
                {
                    IsSucess = false,
                    Message = "Student does not exist."
                };
            }
            catch
            {
                return new Response { IsSucess = false, Message = "Error deleting the student from database." };
            }
        }

        public async Task<Student> FindById(int id)
        {
            var student = await studentRepository.FindById(id);
            return student;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            try
            {
                var students = await studentRepository.GetAll();

                if (students != null)
                {
                    return students;
                }
                else
                {
                    Serilog.Log.Error("The repository returned null in GetAll method of StudentService");
                    throw new Exception("The repository returned null in GetAll method of StudentService");
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error($"An error occurred in GetAll method of StudentService: {ex.Message}");
                throw;
            }
        }

        public async Task<Response> Update(Student student)
        {
            try
            {
                var existingStudent = await studentRepository.FindById(student.Id);
                if (existingStudent != null)
                {
                    existingStudent.Firstname = student.Firstname;
                    existingStudent.Lastname = student.Lastname;
                    existingStudent.Gender = student.Gender;
                    existingStudent.Age = student.Age;

                    var updatedStudent = await studentRepository.Update(existingStudent);
                    if (updatedStudent != null)
                    {
                        return new Response
                        {
                            IsSucess = true,
                            Message = "Successfully updated the student."
                        };
                    }
                }
                return new Response { IsSucess = false, Message = "Failed to update the student" };
            }
            catch
            {
                return new Response
                {
                    IsSucess = false,
                    Message = "Error accessing the database."
                };
            }
        }
    }
}
