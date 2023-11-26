using StudenInformationSystem.Models;
using StudenInformationSystem.Models.DTOs;
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
    public partial class ShowInformationView : Form
    {
        public DTOStudentInformation StudentInformation { get; set; }
        public ShowInformationView()
        {
            InitializeComponent();
        }

        private void BTNClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInformationView_Load(object sender, EventArgs e)
        {
            if(StudentInformation != null)
            {
                ValueStudentId.Text = StudentInformation.ID.ToString();
                ValueFirstname.Text = StudentInformation.Firstname;
                ValueLastname.Text = StudentInformation.Lastname;
                ValueGender.Text = StudentInformation.Gender;
                ValueAge.Text = StudentInformation.Age.ToString();
                ValueEnrollmentId.Text = StudentInformation.EnrollmentId.ToString();
                ValueCourse.Text = StudentInformation.Course;
                ValueCredits.Text = StudentInformation.Credits;
                ValueYear.Text = StudentInformation.Year.ToString();
                ValueSemester.Text = StudentInformation.Semester;
                foreach(var item in StudentInformation.Subjects)
                {
                    listBoxSubject.Items.Add(item);
                }

            }
        }
    }
}
