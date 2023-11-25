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
                    
                    if(result == DialogResult.OK)
                    {
                        StudentIsAdded?.Invoke(this, EventArgs.Empty);
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Register Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public async Task UpdateData(DTOStudentInformation updatedData)
        {
            // Update the controls with the new data
            TBFirstname.Text = updatedData.Firstname;
            TBLastname.Text = updatedData.Lastname;
            TBAge.Text = updatedData.Age.ToString();
            CBGender.Text = updatedData.Gender;
            TBCourse.Text = updatedData.Course;
            TBCredits.Text = updatedData.Credits;
            TBYear.Text = updatedData.Year;
            TBSemester.Text = updatedData.Semester;

            // Clear existing items in ListBoxSubjects
            ListBoxSubjects.Items.Clear();

            // Add new items from the updatedData
            var studentSubjects = await subjectService.GetByStudent(updatedData.ID);
            foreach (var subject in studentSubjects)
            {
                ListBoxSubjects.Items.Add(subject.Name);
            }
        }
    }
}
