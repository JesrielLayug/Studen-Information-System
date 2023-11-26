using StudenInformationSystem.Models;
using StudenInformationSystem.Models.DTOs;
using StudenInformationSystem.Services.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace StudenInformationSystem.Views
{
    public partial class AddStudentView : Form
    {
        private readonly IAdminService adminService;
        private readonly IClassService classService;
        private readonly ICourseService courseService;
        private readonly IEnrollmentService enrollmentService;
        private readonly IStudentService studentService;
        private readonly ISubjectService subjectService;

        public event EventHandler StudentIsAdded;
        public event EventHandler StudentIsUpdated;
        public DTOStudentInformation selectedStudent { get; set; }

        public AddStudentView(IAdminService adminService, IClassService classService, ICourseService courseService,
                        IEnrollmentService enrollmentService, IStudentService studentService, ISubjectService subjectService)
        {
            InitializeComponent();
            this.adminService = adminService;
            this.classService = classService;
            this.courseService = courseService;
            this.enrollmentService = enrollmentService;
            this.studentService = studentService;
            this.subjectService = subjectService;
        }

        private void BTNAddSubject_Click(object sender, EventArgs e)
        {
            ListBoxSubjects.Items.Add(TBSubject.Text);
            TBSubject.Clear();
        }

        private void BTNClearSubjects_Click(object sender, EventArgs e)
        {
            ListBoxSubjects.Items.Remove(ListBoxSubjects.SelectedItem);
        }

        private void BTNCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public async void BTNSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TBFirstname.Text) && !string.IsNullOrEmpty(TBLastname.Text) &&
                !string.IsNullOrEmpty(CBGender.Text) && !string.IsNullOrEmpty(TBAge.Text) && !string.IsNullOrEmpty(TBCourse.Text)
                && !string.IsNullOrEmpty(TBCredits.Text) && !string.IsNullOrEmpty(TBSemester.Text) && !string.IsNullOrEmpty(TBCourse.Text)
                && ListBoxSubjects.Items.Count != 0)
            {
                // Check if the selected student from grid is null
                if(selectedStudent == null)
                {
                    // Create the student if it does not exist
                    var studentAdded = await studentService.Add(TBFirstname.Text, TBLastname.Text, CBGender.Text, int.Parse(TBAge.Text));
                    var courseAdded = await courseService.Add(TBCourse.Text, TBCredits.Text, studentAdded.Id);
                    var classAdded = await classService.Add(courseAdded.Id, TBSemester.Text, TBYear.Text);

                    foreach (var item in ListBoxSubjects.Items)
                    {
                        await subjectService.Add(studentAdded.Id, item.ToString());
                    }

                    if (studentAdded != null && courseAdded != null && classAdded != null)
                    {
                        await enrollmentService.Add(studentAdded.Id, classAdded.Id);
                        DialogResult result = MessageBox.Show("Successfully register the student.", "Register Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (result == DialogResult.OK)
                        {
                            StudentIsAdded?.Invoke(this, EventArgs.Empty);
                            this.Close();
                        }
                    }
                }
                else
                {
                    // Update the student if it exist
                    var updateStudent = await studentService.Update(new Student
                    {
                        Id = selectedStudent.ID,
                        Firstname = TBFirstname.Text,
                        Lastname = TBLastname.Text,
                        Age = int.Parse(TBAge.Text),
                        Gender = CBGender.Text,
                    });

                    if (updateStudent.IsSucess)
                    {
                        // Updating the student course
                        var courseId = await courseService.Update(selectedStudent.ID, new Course
                        {
                            CourseName = TBCourse.Text,
                            StudentId = selectedStudent.ID,
                            Credits = TBCredits.Text,
                        });

                        // Updating the student class
                        var isClassUpdated = await classService.Update(courseId, new Class
                        {
                            CourseId = courseId,
                            Year = TBYear.Text,
                            Semester = TBSemester.Text,
                        });

                        // Updating the student subjects
                        var subjects = ListBoxSubjects.Items.Cast<string>();
                        var isSubjectsUpdated = await subjectService.Update(selectedStudent.ID, subjects);

                        // Checks if updating the class and subjects are successful
                        if (isClassUpdated && isSubjectsUpdated)
                        {
                            var result = MessageBox.Show("Successfully updated all the student information", "Update Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(result == DialogResult.OK)
                            {
                                StudentIsUpdated?.Invoke(this, EventArgs.Empty);
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to update the student.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Register Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddStudentView_Load(object sender, EventArgs e)
        {
            if(selectedStudent != null)
            {
                TBFirstname.Text = selectedStudent.Firstname;
                TBLastname.Text= selectedStudent.Lastname;
                TBAge.Text = selectedStudent.Age.ToString();
                CBGender.Text = selectedStudent.Gender;
                TBCourse.Text = selectedStudent.Course;
                TBCredits.Text = selectedStudent.Credits;
                TBSemester.Text = selectedStudent.Semester;
                TBYear.Text = selectedStudent.Year;
                foreach(var item in selectedStudent.Subjects)
                {
                    ListBoxSubjects.Items.Add(item);
                }
            }
        }
    }
}
