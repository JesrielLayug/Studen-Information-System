using Serilog;
using StudenInformationSystem.Models;
using StudenInformationSystem.Models.DTOs;
using StudenInformationSystem.Repositories;
using StudenInformationSystem.Services;
using StudenInformationSystem.Services.Contracts;
using StudenInformationSystem.Utilities;
using StudenInformationSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudenInformationSystem.Views
{
    public partial class MainView : Form
    {
        private readonly IAdminService adminService;
        private readonly IClassService classService;
        private readonly ICourseService courseService;
        private readonly IEnrollmentService enrollmentService;
        private readonly IStudentService studentService;
        private readonly ISubjectService subjectService;

        AddStudentView addStudentView;

        public MainView(IAdminService adminService, IClassService classService, ICourseService courseService,
                        IEnrollmentService enrollmentService, IStudentService studentService, ISubjectService subjectService)
        {
            InitializeComponent();
            this.adminService = adminService;
            this.classService = classService;
            this.courseService = courseService;
            this.enrollmentService = enrollmentService;
            this.studentService = studentService;
            this.subjectService = subjectService;

            InitializeGridView().Wait();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            AddStudentView addStudentView = new AddStudentView(adminService, classService, courseService, enrollmentService, studentService, subjectService);
            addStudentView.StudentIsAdded += AddStudentView_StudentIsAdded;
            addStudentView.ShowDialog();
        }

        private void AddStudentView_StudentIsUpdated(object sender, EventArgs e)
        {
            DGVStudents.Controls.Clear();
            InitializeGridView().Wait();
        }

        private void AddStudentView_StudentIsAdded(object sender, EventArgs e)
        {
            DGVStudents.Controls.Clear();
            InitializeGridView().Wait();
        }

        public async Task InitializeGridView()
        {
            try
            {
                var students = await studentService.GetAll();
                var courses = await courseService.GetAll();
                var classes = await classService.GetAll();

                if (students != null && courses != null && classes != null)
                {
                    var studentInformations = students.Convert(courses, classes);

                    if (studentInformations.Count() != 0)
                    {
                        DGVStudents.DataSource = studentInformations;
                    }
                    else
                    {
                        Log.Error("Convert method returned null");
                    }
                }
                else
                {
                    Log.Error("One or more services returned null");
                }
            }
            catch (Exception ex)
            {
                Log.Error($"An error occurred in InitializeGridView: {ex.Message}");
                throw;
            }

        }

        private void DGVStudents_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = DGVStudents.Columns[e.ColumnIndex].Name;
                object newValue = DGVStudents.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                var student = DGVStudents.Rows[e.RowIndex].DataBoundItem as DTOStudentInformation;
                if (student != null)
                {
                    typeof(DTOStudentInformation).GetProperty(columnName)?.SetValue(student, newValue);
                }
            }
        }

        private async void BTNDelete_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count > 0)
            {
                var selectedStudent = (DTOStudentInformation)DGVStudents.SelectedRows[0].DataBoundItem;
                var isStudentDeleted = await studentService.Delete(selectedStudent.ID);

                if (isStudentDeleted.IsSucess)
                {
                    await courseService.Delete(selectedStudent.ID);
                    await classService.Delete(selectedStudent.ID);
                    await enrollmentService.Delete(selectedStudent.ID);
                    await subjectService.Delete(selectedStudent.ID);

                    DialogResult result = MessageBox.Show(isStudentDeleted.Message, "Success Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        DGVStudents.Controls.Clear();
                        await InitializeGridView();
                    }

                }
            }
        }

        private async void BTNEdit_Click(object sender, EventArgs e)
        {
            if (DGVStudents.SelectedRows.Count == 1)
            {
                var selectedStudent = (DTOStudentInformation)DGVStudents.SelectedRows[0].DataBoundItem;
                var student = await studentService.FindById(selectedStudent.ID);
                if(student != null)
                {
                    var subjects = await subjectService.GetByStudent(student.Id);
                    var course = await courseService.FindByStudent(student.Id);
                    var @class = await classService.FindByCourse(course.Id);

                    var subjectNames = new List<string>();
                    foreach (var subject in subjects)
                    {
                        subjectNames.Add(subject.Name);
                    }

                    var studentFullInformation = new DTOStudentInformation
                    {
                        ID = student.Id,
                        Firstname = student.Firstname,
                        Lastname = student.Lastname,
                        Age = student.Age,
                        Gender = student.Gender,
                        Course = course.CourseName,
                        Semester = @class.Semester,
                        Year = @class.Year,
                        Credits = course.Credits,
                        Subjects = subjectNames
                    };

                    addStudentView = new AddStudentView(adminService, classService, courseService, enrollmentService, studentService, subjectService);
                    addStudentView.StudentIsUpdated += AddStudentView_StudentIsUpdated;
                    addStudentView.selectedStudent = studentFullInformation;
                    addStudentView.ShowDialog();
                }
            }
        }

    }
}


//if (DGVStudents.SelectedRows.Count == 1)
//{
//    var selectedRow = (DTOStudentInformation)DGVStudents.SelectedRows[0].DataBoundItem;
//    AddStudentView addStudentView = new AddStudentView(adminService, classService, courseService, enrollmentService, studentService, subjectService);
//    addStudentView.TBFirstname.Text = selectedRow.Firstname;
//    addStudentView.TBLastname.Text = selectedRow.Lastname;
//    addStudentView.TBAge.Text = selectedRow.Age.ToString();
//    addStudentView.CBGender.Text = selectedRow.Gender;
//    addStudentView.TBCourse.Text = selectedRow.Course;
//    addStudentView.TBCredits.Text = selectedRow.Credits;
//    addStudentView.TBYear.Text = selectedRow.Year;
//    addStudentView.TBSemester.Text = selectedRow.Semester;

//    var studentSubjects = await subjectService.GetByStudent(selectedRow.ID);
//    foreach (var subject in studentSubjects)
//    {
//        addStudentView.ListBoxSubjects.Items.Add(subject.Name);
//    }
//    addStudentView.BTNSubmit.Text = "Update";

//    // Removing the event click
//    //addStudentView.BTNSubmit.Click -= addStudentView.BTNSubmit_Click;

//    if (addStudentView.ShowDialog() == DialogResult.OK)
//    {
//        addStudentView.BTNSubmit.Click += async (s, ev) =>
//        {
//            var updatedStudent = await studentService.Update(new Student
//            {
//                Id = selectedRow.ID,
//                Firstname = addStudentView.TBFirstname.Text,
//                Lastname = addStudentView.TBLastname.Text,
//                Age = int.Parse(addStudentView.TBAge.Text),
//                Gender = addStudentView.CBGender.Text
//            });

//            if (updatedStudent.IsSucess)
//            {
//                // Updating the course by studentId
//                var courseId = await courseService.Update(selectedRow.ID, new Course
//                {
//                    CourseName = addStudentView.TBCourse.Text,
//                    Credits = addStudentView.TBCredits.Text,
//                });

//                // Updating the class by courseId
//                await classService.Update(courseId, new Class
//                {
//                    Semester = addStudentView.TBSemester.Text,
//                    Year = addStudentView.TBYear.Text,
//                });

//                var subjectDeleted = await subjectService.Delete(selectedRow.ID);
//                if (subjectDeleted)
//                {
//                    foreach (var item in addStudentView.ListBoxSubjects.Items)
//                    {
//                        await subjectService.Add(selectedRow.ID, item.ToString());
//                    }
//                    var result = MessageBox.Show(updatedStudent.Message, "Update Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                    if (result == DialogResult.OK)
//                    {
//                        // Close the current AddStudentView
//                        addStudentView.Close();

//                        var subjects = new List<string>();
//                        foreach (var item in addStudentView.ListBoxSubjects.Items)
//                        {
//                            subjects.Add(item.ToString());
//                        }

//                        //updatedStudent.Data = new DTOStudentInformation
//                        //{
//                        //    Firstname = addStudentView.TBFirstname.Text,
//                        //    Lastname = addStudentView.TBLastname.Text,
//                        //    Age = int.Parse(addStudentView.TBAge.Text),
//                        //    Gender = addStudentView.CBGender.Text,
//                        //    Course = addStudentView.TBCourse.Text,
//                        //    Credits = addStudentView.TBCredits.Text,
//                        //    Semester = addStudentView.TBSemester.Text,
//                        //    Year = addStudentView.TBYear.Text,
//                        //    Subjects = subjects,
//                        //};

//                        // Create a new AddStudentView with the updated data
//                        AddStudentView updatedAddStudentView = new AddStudentView(adminService, classService, courseService, enrollmentService, studentService, subjectService);
//                        await updatedAddStudentView.UpdateData(updatedStudent.Data);
//                        updatedAddStudentView.BTNSubmit.Text = "Update";
//                        updatedAddStudentView.ShowDialog();

//                        DGVStudents.Controls.Clear();
//                        await InitializeGridView();
//                    }
//                }
//            }
//            MessageBox.Show(updatedStudent.Message, "Failed to Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        };
//    }

//    // Overriding the event click of submit button in addStudentView

//}