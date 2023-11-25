using StudenInformationSystem.Services.Contracts;
using System;
using System.Windows.Forms;

namespace StudenInformationSystem.Views
{
    public partial class LoginView : Form
    {
        private readonly IAdminService adminService;
        private readonly IClassService classService;
        private readonly ICourseService courseService;
        private readonly IEnrollmentService enrollmentService;
        private readonly IStudentService studentService;
        private readonly ISubjectService subjectService;

        public LoginView(IAdminService adminService, IClassService classService, ICourseService courseService,
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

        private async void BTNLogin_Click(object sender, EventArgs e)
        {
            string username = TBUsername.Text;
            string password = TBPassword.Text;

            var response = await adminService.Login(username, password);
            if(response.IsSucess == true)
            {
                MessageBox.Show(response.Message, "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainView main = new MainView(adminService, classService, courseService, enrollmentService, studentService, subjectService);
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(response.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
